using System;
using System.Drawing;
using System.Windows.Forms;

namespace Stargate
{
    // User Control représentant une carte membre de l'équipage
    public partial class UCMembre : UserControl
    {
        public UCMembre()
        {
            InitializeComponent();
        }

        // Constructeur surchargé pour initialiser le contrôle avec les données du membre
        public UCMembre(string nom, string prenom, string role, string type, bool estChef = false)
        {
            InitializeComponent();

            lblNomPrenom.Text = nom + "\n" + prenom;
            lblRole.Text = role;
            lblType.Text = type;

            // Couleur différente selon le type
            if (type == "Militaire")
            {
                pnlCarte.BackColor = Color.FromArgb(30, 60, 100);
                lblType.ForeColor = Color.FromArgb(100, 180, 255);

                picAvatar.Image = Image.FromFile("militaire.png");
                picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else
            {
                pnlCarte.BackColor = Color.FromArgb(30, 80, 60);
                lblType.ForeColor = Color.FromArgb(100, 220, 160);

                picAvatar.Image = Image.FromFile("civil.png");
                picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }

            // Mise en évidence du chef
            if (estChef)
            {
                pnlCarte.BackColor = Color.FromArgb(80, 50, 10);
                lblType.ForeColor = Color.FromArgb(255, 200, 50);
                lblType.Text = "⭐ Chef - " + role;

                picAvatar.Image = Image.FromFile("vero.png");
                picAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            }

            
        }
    }
}
