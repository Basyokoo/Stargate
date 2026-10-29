using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Stargate
{
    /// <summary>
    /// Popup d'ajout d'une dépense.
    /// Règles métier :
    ///  - La date choisie ne peut pas être AVANT la date de la dernière entrée du journal.
    ///  - L'ajout d'une dépense crée AUTOMATIQUEMENT une entrée dans le journal de bord
    ///    pour la même date (concaténation si entrée existante ce jour-là).
    /// Les deux insertions se font dans une transaction pour garantir la cohérence.
    /// </summary>
    public partial class FormAjoutDepense : Form
    {
        private string nomPlanete;
        private int numeroMission;
        private DateTime dateDerniereEntree;
        private int budgetRestant;

        public bool Succes { get; private set; } = false;

        // Constructeur sans paramètre requis par le designer Visual Studio
        public FormAjoutDepense() : this("", 0, DateTime.Today) { }

        public FormAjoutDepense(string nomPlanete, int numeroMission, DateTime dateDerniereEntree, int budgetRestant = int.MaxValue)
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
            nudMontant.Maximum = budgetRestant > 0 ? budgetRestant : 1;
            nudMontant.Value = Math.Min(100, budgetRestant > 0 ? budgetRestant : 1);
            btnValider.FlatAppearance.BorderColor = Color.FromArgb(60, 160, 100);
            btnAnnuler.FlatAppearance.BorderColor = Color.FromArgb(160, 60, 60);

            txtMotif.TextChanged += (s, e) => MettreAJourPreviewJournal();
            dtpDate.ValueChanged += (s, e) => MettreAJourPreviewJournal();
            cmbType.SelectedIndexChanged += (s, e) => MettreAJourPreviewJournal();

            ChargerTypesDepense();
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void MettreAJourPreviewJournal()
        {
            string type = cmbType.SelectedItem != null ? cmbType.SelectedItem.ToString() : "Dépense";
            string motif = string.IsNullOrWhiteSpace(txtMotif.Text) ? "(sans motif)" : txtMotif.Text.Trim();
            int montant = (int)nudMontant.Value;
            txtCommentaireJournal.Text =
                "Dépense enregistrée [" + type + "] : " + motif + " — " + montant + " €";
        }

        private void ChargerTypesDepense()
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Stargate.db"))
                {
                    conn.Open();
                    SQLiteCommand cmd = new SQLiteCommand(
                        "SELECT id, libelle FROM TypeDepense ORDER BY libelle", conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();
                    cmbType.Items.Clear();
                    while (reader.Read())
                        cmbType.Items.Add(new TypeDepenseItem(
                            Convert.ToInt32(reader["id"]), reader["libelle"].ToString()));
                    if (cmbType.Items.Count > 0) cmbType.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur chargement types : " + ex.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMotif.Text))
            {
                MessageBox.Show("Le motif ne peut pas être vide.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cmbType.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un type de dépense.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int montant = (int)nudMontant.Value;

            if (montant > budgetRestant)
            {
                MessageBox.Show(
                    "Impossible d'enregistrer cette dépense !\n" +
                    "Montant saisi : " + montant.ToString("N0") + " €\n" +
                    "Budget restant : " + budgetRestant.ToString("N0") + " €\n\n" +
                    "La dépense ne peut pas dépasser le budget disponible.",
                    "Budget insuffisant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dateChoisie = dtpDate.Value.ToString("yyyy-MM-dd");
            string motif = txtMotif.Text.Trim();
            int idType = ((TypeDepenseItem)cmbType.SelectedItem).Id;
            string commentaireJournal = txtCommentaireJournal.Text.Trim();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Stargate.db"))
                {
                    conn.Open();
                    using (SQLiteTransaction tx = conn.BeginTransaction())
                    {
                        try
                        {
                            SQLiteCommand cmdMaxId = new SQLiteCommand(
                                "SELECT COALESCE(MAX(id), 0) + 1 FROM Depense " +
                                "WHERE nomPlanete = @p AND numeroMission = @n", conn, tx);
                            cmdMaxId.Parameters.AddWithValue("@p", nomPlanete);
                            cmdMaxId.Parameters.AddWithValue("@n", numeroMission);
                            int prochainId = Convert.ToInt32(cmdMaxId.ExecuteScalar());

                            SQLiteCommand cmdDep = new SQLiteCommand(
                                "INSERT INTO Depense (nomPlanete, numeroMission, id, dateD, montant, motif, idTypeDepense) " +
                                "VALUES (@p, @n, @id, @d, @m, @mo, @t)", conn, tx);
                            cmdDep.Parameters.AddWithValue("@p", nomPlanete);
                            cmdDep.Parameters.AddWithValue("@n", numeroMission);
                            cmdDep.Parameters.AddWithValue("@id", prochainId);
                            cmdDep.Parameters.AddWithValue("@d", dateChoisie);
                            cmdDep.Parameters.AddWithValue("@m", montant);
                            cmdDep.Parameters.AddWithValue("@mo", motif);
                            cmdDep.Parameters.AddWithValue("@t", idType);
                            cmdDep.ExecuteNonQuery();

                            AjouterOuConcatenerJournal(conn, tx, nomPlanete, numeroMission,
                                dateChoisie, commentaireJournal);

                            tx.Commit();
                            MessageBox.Show(
                                "Dépense de " + montant + " € enregistrée.\n" +
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

        /// <summary>
        /// Méthode partagée : ajoute ou concatène une entrée de journal de bord.
        /// Utilisable depuis FormAjoutDepense et FormAjoutNegociation.
        /// </summary>
        public static void AjouterOuConcatenerJournal(
            SQLiteConnection conn, SQLiteTransaction tx,
            string nomPlanete, int numeroMission,
            string dateChoisie, string commentaire)
        {
            SQLiteCommand cmdCheck = new SQLiteCommand(
                "SELECT commentaires FROM JournalDeBord " +
                "WHERE nomPlanete = @p AND numero = @n AND dateJ = @d",
                conn, tx);
            cmdCheck.Parameters.AddWithValue("@p", nomPlanete);
            cmdCheck.Parameters.AddWithValue("@n", numeroMission);
            cmdCheck.Parameters.AddWithValue("@d", dateChoisie);
            object existing = cmdCheck.ExecuteScalar();

            if (existing != null && existing != DBNull.Value)
            {
                SQLiteCommand cmdUpd = new SQLiteCommand(
                    "UPDATE JournalDeBord SET commentaires = @c " +
                    "WHERE nomPlanete = @p AND numero = @n AND dateJ = @d",
                    conn, tx);
                cmdUpd.Parameters.AddWithValue("@c", existing.ToString() + "\n" + commentaire);
                cmdUpd.Parameters.AddWithValue("@p", nomPlanete);
                cmdUpd.Parameters.AddWithValue("@n", numeroMission);
                cmdUpd.Parameters.AddWithValue("@d", dateChoisie);
                cmdUpd.ExecuteNonQuery();
            }
            else
            {
                SQLiteCommand cmdIns = new SQLiteCommand(
                    "INSERT INTO JournalDeBord (nomPlanete, numero, dateJ, commentaires) " +
                    "VALUES (@p, @n, @d, @c)",
                    conn, tx);
                cmdIns.Parameters.AddWithValue("@p", nomPlanete);
                cmdIns.Parameters.AddWithValue("@n", numeroMission);
                cmdIns.Parameters.AddWithValue("@d", dateChoisie);
                cmdIns.Parameters.AddWithValue("@c", commentaire);
                cmdIns.ExecuteNonQuery();
            }
        }
    }

    // Classe helper pour le ComboBox des types de dépense
    public class TypeDepenseItem
    {
        public int Id { get; }
        private string Libelle;
        public TypeDepenseItem(int id, string libelle) { Id = id; Libelle = libelle; }
        public override string ToString() => Libelle;
    }
}
