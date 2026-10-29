using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace StargateControlLibrary
{
    public partial class PlanetInfo : UserControl
    {
        public PlanetInfo()
        {
            InitializeComponent();
        }

        public PlanetInfo(string nom, string nomEsp, string pourcen, string path, List<List<string>> EspInfo)
        {
            InitializeComponent();

            this.lblNom.Text = nom;

            if (!string.IsNullOrEmpty(pourcen) && pourcen != "100%")
            {
                this.lblNomEsp.Text = nomEsp;
                this.lblPourcentageEsp.Text = "Présence : " + pourcen;
            }

            if (System.IO.File.Exists(path))
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image    = Image.FromFile(path);
            }

            flpEsp.Controls.Clear();

            foreach (List<string> infoAlien in EspInfo)
            {
                string nomEspece  = infoAlien[0];
                string idEspece   = infoAlien[1];
                string degres     = infoAlien[2];
                string armeInstru = infoAlien[3];
                string estMechant = infoAlien[4];
                string dateContact = infoAlien[5];
                string pctPresence = infoAlien.Count > 6 ? infoAlien[6] : "0";
                string couleur     = infoAlien.Count > 7 ? infoAlien[7] : "";

                Alien carteAlien;
                if (estMechant == "non")
                    carteAlien = new Alien(nomEspece, idEspece, degres, armeInstru, "Non", dateContact);
                else
                    carteAlien = new Alien(nomEspece, idEspece, degres, armeInstru, "Oui");

                if (!string.IsNullOrEmpty(couleur))
                {
                    string cheminAlien = System.IO.Path.Combine(
                        Application.StartupPath, "Alien", couleur + ".png");
                    carteAlien.ChargImage(cheminAlien);
                }

                carteAlien.PourcentagePresence = pctPresence + "%";
                carteAlien.AlienSelectionne   += Alien_ClicSelection;
                flpEsp.Controls.Add(carteAlien);
            }
        }

        private void Alien_ClicSelection(object sender, EventArgs e)
        {
            Alien alienClique = sender as Alien;
            if (alienClique != null)
            {
                lblNomEsp.Text         = alienClique.NomEspece;
                lblPourcentageEsp.Text = "Présence : " + alienClique.PourcentagePresence;
            }
        }

        private void PlanetInfo_Load(object sender, EventArgs e) { }

        private void lblNom_Click(object sender, EventArgs e) { }
    }
}
