using System;
using System.Drawing;
using System.Windows.Forms;
using static StargateControlLibrary.MissionViewer;

namespace StargateControlLibrary
{
    public partial class Planet : UserControl
    {
        public delegate void afficherPlanet(object sender, EventArgs e);

        public Planet()
        {
            InitializeComponent();
        }

        public Planet(string nom, string degres, string gravité, string dataBaz, string path, int tag)
        {
            InitializeComponent();

            this.lblPlanetName.Text = nom;
            this.lblPlanetTemp.Text = "🌡  Température : " + degres + " °C";
            this.lblPlanetGrav.Text = "⚖  Gravité : " + gravité + " g";

            if (dataBaz == "non")
            {
                this.lblPlanetDataBazOn.Text      = "🚫  Pas de Stargate";
                this.lblPlanetDataBazOn.ForeColor = Color.FromArgb(255, 85, 85);
            }
            else
            {
                this.lblPlanetDataBazOn.Text      = "🚪  Stargate présente";
                this.lblPlanetDataBazOn.ForeColor = Color.FromArgb(55, 220, 115);
            }

            if (System.IO.File.Exists(path))
            {
                this.picPlanet.SizeMode = PictureBoxSizeMode.Zoom;
                this.picPlanet.Image    = Image.FromFile(path);
            }

            button1.Tag = tag;
        }

        public afficherPlanet afficheur;

        private void Planet_Load(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.afficheur != null)
                this.afficheur(sender, e);
        }

        private void lblPlanetName_Click(object sender, EventArgs e) { }
    }
}
