using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Stargate
{
    /// <summary>
    /// Popup d'ajout d'une entrée dans le journal de bord.
    /// Règles métier :
    ///  - La date choisie ne peut pas être AVANT la date de la dernière entrée existante.
    ///  - Si une entrée existe déjà à cette date, le texte est AJOUTÉ (concaténé), pas remplacé.
    /// </summary>
    public partial class FormAjoutJournal : Form
    {
        private string nomPlanete;
        private int numeroMission;
        private DateTime dateDerniereEntree;

        public bool Succes { get; private set; } = false;

        // Constructeur sans paramètre requis par le designer Visual Studio
        public FormAjoutJournal() : this("", 0, DateTime.Today) { }

        public FormAjoutJournal(string nomPlanete, int numeroMission, DateTime dateDerniereEntree)
        {
            this.nomPlanete = nomPlanete;
            this.numeroMission = numeroMission;
            this.dateDerniereEntree = dateDerniereEntree;

            InitializeComponent();

            lblInfo.Text = "ℹ Date plancher : " + dateDerniereEntree.ToShortDateString() +
                           "  |  Si entrée existante ce jour : texte ajouté à la suite.";
            dtpDate.MinDate = dateDerniereEntree;
            dtpDate.Value = dateDerniereEntree > DateTime.Today ? dateDerniereEntree : DateTime.Today;
            btnValider.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 160, 100);
            btnAnnuler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(160, 60, 60);
        }

        private void BtnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void BtnValider_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCommentaire.Text))
            {
                MessageBox.Show("Le commentaire ne peut pas être vide.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string dateChoisie = dtpDate.Value.ToString("yyyy-MM-dd");
            string commentaire = txtCommentaire.Text.Trim();

            try
            {
                using (SQLiteConnection conn = new SQLiteConnection("Data Source=Stargate.db"))
                {
                    conn.Open();
                    using (SQLiteTransaction tx = conn.BeginTransaction())
                    {
                        try
                        {
                            FormAjoutDepense.AjouterOuConcatenerJournal(
                                conn, tx, nomPlanete, numeroMission, dateChoisie, commentaire);
                            tx.Commit();

                            MessageBox.Show(
                                "Entrée de journal enregistrée pour le " +
                                dtpDate.Value.ToShortDateString() + ".",
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
}
