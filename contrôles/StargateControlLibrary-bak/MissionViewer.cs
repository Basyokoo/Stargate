using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StargateControlLibrary
{
    [ToolboxBitmap(typeof(MissionViewer), "MissionViewer.png")]
    public partial class MissionViewer: UserControl
    {
        public delegate void afficherMission(object sender, EventArgs e);
       
        public MissionViewer()
        {
            InitializeComponent();
        }

        public MissionViewer(string NomImage, string NomMission, string DateDeb, string DateFin, string NomChef, string Budget)
        {
            InitializeComponent();
            this.lblNomMission.Text = NomMission;
            this.lblAfficherMissionDateDeb.Text = DateDeb;
            this.lblAfficherMissionDateFin.Text = DateFin;
            this.lblAfficherMissionChef.Text = NomChef;
            this.lblAfficherMissionBudget.Text = Budget;
             try
            {
                this.picAfficherMission.Image = Image.FromFile(NomImage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement de l'image : " + ex.Message);
            }
        }

        public afficherMission afficheur;

        private void MissionViewer_Load(object sender, EventArgs e)
        {

        }

        private void btnAfficherMission_Click(object sender, EventArgs e)
        {
            if(this.afficheur != null)
            {
                this.afficheur(sender, e);
            }
        }
    }
}
