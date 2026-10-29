using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Stargate
{
    /// <summary>
    /// Popup d'ajout d'une négociation (contact informateur).
    /// Règles métier :
    ///  - La date choisie ne peut pas être AVANT la date de la dernière entrée du journal.
    ///  - L'ajout crée AUTOMATIQUEMENT :
    ///      • une dépense de type "Informateur" pour la somme versée
    ///      • une entrée dans le journal de bord (concaténation si existante ce jour-là)
    ///  - Si un contact existait déjà à la même date avec le même informateur,
    ///    la somme est cumulée et l'appréciation concaténée.
    /// Tout se fait dans une transaction atomique.
    /// </summary>
    public partial class FormAjoutNegociation : Form
    {
        private string nomPlanete;
        private int numeroMission;
        private DateTime dateDerniereEntree;
        private int budgetRestant;

        public bool Succes { get; private set; } = false;

        // Constructeur sans paramètre requis par le designer Visual Studio
        public FormAjoutNegociation() : this("", 0, DateTime.Today) { }

        public FormAjoutNegociation(string nomPlanete, int numeroMission, DateTime dateDerniereEntree, int budgetRestant = int.MaxValue)
        {
            this.nomPlanete = nomPlanete;
            this.numeroMission = numeroMission;
            this.dateDerniereEntree = dateDerniereEntree;
            this.budgetRestant = budgetRestant;

            InitializeComponent();

            lblInfo.Text = "ℹ Date plancher : " + dateDerniereEntree.ToShortDateString() +
                           "  —  Budget restant : " + budgetRestant.ToString("N0") + " €";
            dtpDate.MinDate = dateDerniereEntree;
            dtpDate.Value = dateDerniereEntree > DateTime.Today ? dateDerniereEntree : DateTime.Today;
            nudSomme.Maximum = budgetRestant > 0 ? budgetRestant : 1;
            nudSomme.Value = Math.Min(100, budgetRestant > 0 ? budgetRestant : 1);
            btnValider.FlatAppearance.BorderColor = Color.FromArgb(60, 160, 100);
            btnAnnuler.FlatAppearance.BorderColor = Color.FromArgb(160, 60, 60);
            pnlAuto.Paint += (s, e) => {
                e.Graphics.DrawRectangle(new System.Drawing.Pen(Color.FromArgb(80, 180, 120), 1),
                    0, 0, pnlAuto.Width - 1, pnlAuto.Height - 1);
            };

            ChargerInformateurs();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ChargerInformateurs()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Stargate.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(
                        "SELECT i.nomCode, i.nom, e.nom as espece " +
                        "FROM Informateur i JOIN Espece e ON i.idEspeceEnnemi = e.id " +
                        "ORDER BY i.nomCode", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    cmbInformateur.Items.Clear();
                    while (reader.Read())
                        cmbInformateur.Items.Add(new InformateurItem(
                            reader["nomCode"].ToString(),
                            reader["nom"].ToString(),
                            reader["espece"].ToString()));
                    if (cmbInformateur.Items.Count > 0) cmbInformateur.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement informateurs : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtApprec.Text))
            {
                MessageBox.Show("L'appréciation ne peut pas être vide.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbInformateur.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un informateur.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dateChoisie = dtpDate.Value.ToString("yyyy-MM-dd");
            var info = (InformateurItem)cmbInformateur.SelectedItem;
            string nomCode = info.NomCode;
            int somme = (int)nudSomme.Value;
            string apprec = txtApprec.Text.Trim();

            if (somme > budgetRestant)
            {
                MessageBox.Show(
                    "Impossible d'enregistrer cette négociation !\n" +
                    "Somme versée : " + somme.ToString("N0") + " $\n" +
                    "Budget restant : " + budgetRestant.ToString("N0") + " €\n\n" +
                    "La dépense générée ne peut pas dépasser le budget disponible.",
                    "Budget insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string commentaireJournal =
                "Contact informateur [" + nomCode + " - " + info.NomAffichage + "] : " +
                apprec + " — " + somme + " $ versés";

            string motifDepense =
                "Paiement informateur " + nomCode + " (" + info.NomAffichage + ")";

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Stargate.db"))
                {
                    conn.Open();
                    using (SQLiteTransaction tx = conn.BeginTransaction())
                    {
                        try
                        {
                            SQLiteCommand cmdCheck = new SQLiteCommand(
                                "SELECT sommeVersee, appreciation FROM Contact " +
                                "WHERE nomPlanete=@p AND numeroMission=@n AND dateC=@d AND nomCodeInformateur=@code",
                                conn, tx);
                            cmdCheck.Parameters.AddWithValue("@p", nomPlanete);
                            cmdCheck.Parameters.AddWithValue("@n", numeroMission);
                            cmdCheck.Parameters.AddWithValue("@d", dateChoisie);
                            cmdCheck.Parameters.AddWithValue("@code", nomCode);
                            SQLiteDataReader reader = cmdCheck.ExecuteReader();

                            if (reader.Read())
                            {
                                int ancSomme = Convert.ToInt32(reader["sommeVersee"]);
                                string ancApprec = reader["appreciation"].ToString();
                                reader.Close();
                                somme += ancSomme;
                                apprec = ancApprec + "\n" + apprec;

                                SQLiteCommand cmdUpd = new SQLiteCommand(
                                    "UPDATE Contact SET sommeVersee=@s, appreciation=@a " +
                                    "WHERE nomPlanete=@p AND numeroMission=@n AND dateC=@d AND nomCodeInformateur=@code",
                                    conn, tx);
                                cmdUpd.Parameters.AddWithValue("@s", somme);
                                cmdUpd.Parameters.AddWithValue("@a", apprec);
                                cmdUpd.Parameters.AddWithValue("@p", nomPlanete);
                                cmdUpd.Parameters.AddWithValue("@n", numeroMission);
                                cmdUpd.Parameters.AddWithValue("@d", dateChoisie);
                                cmdUpd.Parameters.AddWithValue("@code", nomCode);
                                cmdUpd.ExecuteNonQuery();
                            }
                            else
                            {
                                reader.Close();
                                SQLiteCommand cmdIns = new SQLiteCommand(
                                    "INSERT INTO Contact (nomPlanete, numeroMission, dateC, sommeVersee, appreciation, nomCodeInformateur) " +
                                    "VALUES (@p, @n, @d, @s, @a, @code)",
                                    conn, tx);
                                cmdIns.Parameters.AddWithValue("@p", nomPlanete);
                                cmdIns.Parameters.AddWithValue("@n", numeroMission);
                                cmdIns.Parameters.AddWithValue("@d", dateChoisie);
                                cmdIns.Parameters.AddWithValue("@s", somme);
                                cmdIns.Parameters.AddWithValue("@a", apprec);
                                cmdIns.Parameters.AddWithValue("@code", nomCode);
                                cmdIns.ExecuteNonQuery();
                            }

                            SQLiteCommand cmdMaxId = new SQLiteCommand(
                                "SELECT COALESCE(MAX(id), 0) + 1 FROM Depense " +
                                "WHERE nomPlanete=@p AND numeroMission=@n", conn, tx);
                            cmdMaxId.Parameters.AddWithValue("@p", nomPlanete);
                            cmdMaxId.Parameters.AddWithValue("@n", numeroMission);
                            int prochainId = Convert.ToInt32(cmdMaxId.ExecuteScalar());

                            SQLiteCommand cmdTypeId = new SQLiteCommand(
                                "SELECT id FROM TypeDepense WHERE libelle = 'Informateur' LIMIT 1",
                                conn, tx);
                            object typeIdObj = cmdTypeId.ExecuteScalar();
                            int idTypeInformateur = typeIdObj != null ? Convert.ToInt32(typeIdObj) : 2;

                            SQLiteCommand cmdDep = new SQLiteCommand(
                                "INSERT INTO Depense (nomPlanete, numeroMission, id, dateD, montant, motif, idTypeDepense) " +
                                "VALUES (@p, @n, @id, @d, @m, @mo, @t)",
                                conn, tx);
                            cmdDep.Parameters.AddWithValue("@p", nomPlanete);
                            cmdDep.Parameters.AddWithValue("@n", numeroMission);
                            cmdDep.Parameters.AddWithValue("@id", prochainId);
                            cmdDep.Parameters.AddWithValue("@d", dateChoisie);
                            cmdDep.Parameters.AddWithValue("@m", (int)nudSomme.Value);
                            cmdDep.Parameters.AddWithValue("@mo", motifDepense);
                            cmdDep.Parameters.AddWithValue("@t", idTypeInformateur);
                            cmdDep.ExecuteNonQuery();

                            FormAjoutDepense.AjouterOuConcatenerJournal(
                                conn, tx, nomPlanete, numeroMission, dateChoisie, commentaireJournal);

                            tx.Commit();

                            MessageBox.Show(
                                "Négociation enregistrée.\n" +
                                "Dépense « Informateur » de " + nudSomme.Value + " $ créée.\n" +
                                "Entrée de journal ajoutée pour le " + dtpDate.Value.ToShortDateString() + ".",
                                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Succes = true;
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        catch
                        {
                            tx.Rollback();
                            throw;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    // Classe helper pour le ComboBox des informateurs
    public class InformateurItem
    {
        public string NomCode { get; }
        public string NomAffichage { get; }
        private string Espece;
        public InformateurItem(string nomCode, string nom, string espece)
        {
            NomCode = nomCode;
            NomAffichage = nom;
            Espece = espece;
        }
        public override string ToString() => NomCode + "  —  " + NomAffichage + "  (" + Espece + ")";
    }
}
