using System;
using System.Drawing;
using System.Windows.Forms;

namespace StargateControlLibrary
{
    public partial class Alien : UserControl
    {
        public event EventHandler AlienSelectionne;
        public string PourcentagePresence { get; set; } = "0%";

        public string NomEspece
        {
            get { return lblTypeAlien.Text; }
            set { lblTypeAlien.Text = value; }
        }

        public Alien()
        {
            InitializeComponent();
            AssocierClicEvenement(this);
        }

        public Alien(string nomEsp, string IdEsp, string degresAB, string ArmeInstru, string estMech) : this()
        {
            this.lblTypeAlien.Text          = nomEsp;
            this.lblIdAlien.Text            = "Identifiant : " + IdEsp;
            this.lblDegresBA.Text           = "Agressivité : " + degresAB;
            this.lblArmeInstru.Text         = "⚔  Arme : " + ArmeInstru;
            this.lblDatePremierContact.Visible = false;
            AppliquerStatut(estMech);
        }

        public Alien(string nomEsp, string IdEsp, string degresAB, string ArmeInstru, string estMech, string dtPremierContact) : this()
        {
            this.lblTypeAlien.Text             = nomEsp;
            this.lblIdAlien.Text               = "Identifiant : " + IdEsp;
            this.lblDegresBA.Text              = "Bienveillance : " + degresAB;
            this.lblArmeInstru.Text            = "♪  Instrument : " + ArmeInstru;
            this.lblDatePremierContact.Text    = "📅  1er contact : " + dtPremierContact;
            AppliquerStatut(estMech);
        }

        private void AppliquerStatut(string estMech)
        {
            bool ennemi = estMech == "Oui" || estMech == "oui";
            if (ennemi)
            {
                this.lblAgressifOn.Text      = "⚔  Ennemi";
                this.lblAgressifOn.ForeColor = Color.FromArgb(255, 85, 85);
                this.lblAgressifOn.BackColor = Color.FromArgb(55, 12, 12);
            }
            else
            {
                this.lblAgressifOn.Text      = "✦  Allié";
                this.lblAgressifOn.ForeColor = Color.FromArgb(55, 220, 115);
                this.lblAgressifOn.BackColor = Color.FromArgb(10, 45, 22);
            }
        }

        public void ChargImage(string cheminImage)
        {
            if (System.IO.File.Exists(cheminImage))
            {
                picAlien.SizeMode = PictureBoxSizeMode.Zoom;
                picAlien.Image    = Image.FromFile(cheminImage);
            }
        }

        private void AssocierClicEvenement(Control parent)
        {
            parent.Click += CarteAlien_Click;
            foreach (Control enfant in parent.Controls)
                AssocierClicEvenement(enfant);
        }

        private void CarteAlien_Click(object sender, EventArgs e)
        {
            AlienSelectionne?.Invoke(this, EventArgs.Empty);
        }
    }
}
