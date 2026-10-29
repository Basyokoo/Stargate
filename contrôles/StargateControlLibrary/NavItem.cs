using System;
using System.Drawing;
using System.Windows.Forms;
using Svg;

namespace StargateControlLibrary
{
    /// <summary>
    /// Élément de la barre de navigation latérale.
    /// Affiche une icône SVG, un nom de section et une barre d'accent au survol.
    /// </summary>
    public partial class NavItem : UserControl
    {
        private Color m_couleurSurvol;
        private Color m_couleurNormal;

        public NavItem(string nom, string svgPath, Color couleurSurvol, Color couleurNormal, EventHandler onClick)
        {
            InitializeComponent();

            lblNom.Text = nom;
            lblNom.ForeColor = couleurNormal;

            m_couleurSurvol = couleurSurvol;
            m_couleurNormal = couleurNormal;

            // Chargement de l'icône SVG
            try
            {
                var svgDoc = SvgDocument.Open(svgPath);
                pbxIcon.Image = svgDoc.Draw(46, 46);
            }
            catch { /* SVG introuvable — la case icône reste vide */ }

            // Abonnement aux événements de survol et de clic sur tous les sous-contrôles
            foreach (Control ctrl in new Control[] { this, pbxIcon, lblNom })
            {
                ctrl.MouseEnter += OnSurvol;
                ctrl.MouseLeave += OnQuitter;
                ctrl.Click += onClick;
            }
        }

        private void OnSurvol(object sender, EventArgs e)
        {
            lblNom.ForeColor = m_couleurSurvol;
            pnlAccent.Visible = true;
            // Légère surbrillance de fond au survol
            this.BackColor = Color.FromArgb(30, 50, 130, 255);
        }

        private void OnQuitter(object sender, EventArgs e)
        {
            // Vérifier que le curseur a vraiment quitté le contrôle (évite les faux déclenchements)
            if (!this.ClientRectangle.Contains(this.PointToClient(Cursor.Position)))
            {
                lblNom.ForeColor = m_couleurNormal;
                pnlAccent.Visible = false;
                this.BackColor = Color.Transparent;
            }
        }
    }
}
