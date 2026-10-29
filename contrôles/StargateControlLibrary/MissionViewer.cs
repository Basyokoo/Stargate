using System;
using System.Drawing;
using System.Windows.Forms;

namespace StargateControlLibrary
{
    /// <summary>
    /// Carte d'affichage d'une mission sur le tableau de bord.
    /// Affiche le nom, les dates, le chef et le budget, avec un indicateur coloré selon le statut.
    /// </summary>
    [ToolboxBitmap(typeof(MissionViewer))]
    public partial class MissionViewer : UserControl
    {
        // Délégué permettant à Form1 de réagir au clic "Voir la mission"
        public delegate void afficherMission(object sender, EventArgs e);
        public afficherMission afficheur;

        private string m_NomMission;

        public MissionViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Construit une carte de mission avec toutes ses informations.
        /// Le statut est déduit automatiquement des dates.
        /// </summary>
        public MissionViewer(string NomImage, string NomMission, string DateDeb, string DateFin, string NomChef, string Budget)
        {
            InitializeComponent();

            m_NomMission = NomMission;

            // Remplissage des libellés
            lblNomMission.Text = NomMission;
            lblDateDeb.Text = "🚀 Départ : " + DateDeb;
            lblDateFin.Text = "🏠 Retour prévu : " + DateFin;
            lblChef.Text = "👤 Chef : " + NomChef;
            lblBudget.Text = "💰 Budget : " + Budget;

            // Chargement de l'image de la planète (le fond jaune reste visible si le fichier manque)
            try
            {
                if (!string.IsNullOrEmpty(NomImage))
                    picAfficherMission.Image = Image.FromFile(NomImage);
            }
            catch { /* Image introuvable — le placeholder jaune reste affiché */ }

            // Calcul et application du statut
            AppliquerStatut(DateDeb, DateFin);
        }

        // ────────────────────────────────────────────────────────────
        // Statut de la mission
        // ────────────────────────────────────────────────────────────

        /// <summary>
        /// Détermine le statut à partir des dates et colorie la barre et le badge en conséquence.
        /// </summary>
        private void AppliquerStatut(string dateDeb, string dateFin)
        {
            string statut = CalculerStatut(dateDeb, dateFin);
            Color couleurAccent;
            Color couleurFond;
            Color couleurTexte;

            switch (statut)
            {
                case "En cours":
                    couleurAccent = Color.FromArgb(50, 130, 255);  // bleu
                    couleurFond   = Color.FromArgb(18, 40, 80);
                    couleurTexte  = Color.FromArgb(100, 200, 255);
                    break;
                case "À venir":
                    couleurAccent = Color.FromArgb(255, 200, 50);  // or
                    couleurFond   = Color.FromArgb(60, 48, 12);
                    couleurTexte  = Color.FromArgb(255, 200, 50);
                    break;
                case "Terminé":
                    couleurAccent = Color.FromArgb(80, 180, 120);  // vert
                    couleurFond   = Color.FromArgb(15, 40, 25);
                    couleurTexte  = Color.FromArgb(80, 200, 130);
                    break;
                default:
                    couleurAccent = Color.FromArgb(140, 155, 180);
                    couleurFond   = Color.FromArgb(30, 40, 60);
                    couleurTexte  = Color.FromArgb(140, 155, 180);
                    break;
            }

            pnlStatusBar.BackColor     = couleurAccent;
            pnlStatutBadge.BackColor   = couleurFond;
            btnAfficherMission.FlatAppearance.BorderColor = couleurAccent;
            lblStatut.ForeColor        = couleurTexte;
            lblStatut.Text             = statut;

            // Teinte légère de la carte selon le statut
            this.BackColor = Color.FromArgb(22, 32, 55);
        }

        /// <summary>
        /// Retourne "En cours", "À venir", "Terminé" ou "Inconnu" selon les dates.
        /// </summary>
        private static string CalculerStatut(string dateDeb, string dateFin)
        {
            if (DateTime.TryParse(dateDeb, out DateTime debut) && DateTime.TryParse(dateFin, out DateTime fin))
            {
                DateTime aujourd_hui = DateTime.Today;
                if (aujourd_hui < debut)  return "À venir";
                if (aujourd_hui > fin)    return "Terminé";
                return "En cours";
            }
            return "Inconnu";
        }

        // ────────────────────────────────────────────────────────────
        // Accesseurs
        // ────────────────────────────────────────────────────────────

        public string get_NomMission() => m_NomMission;

        // ────────────────────────────────────────────────────────────
        // Événements
        // ────────────────────────────────────────────────────────────

        private void MissionViewer_Load(object sender, EventArgs e) { }

        private void btnAfficherMission_Click(object sender, EventArgs e)
        {
            afficheur?.Invoke(sender, e);
        }
    }
}
