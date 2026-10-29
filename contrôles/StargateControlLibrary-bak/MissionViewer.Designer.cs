namespace StargateControlLibrary
{
    partial class MissionViewer
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MissionViewer));
            this.btnAfficherMission = new System.Windows.Forms.Button();
            this.picAfficherMission = new System.Windows.Forms.PictureBox();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.lblAfficherMissionDateDeb = new System.Windows.Forms.Label();
            this.lblAfficherMissionDateFin = new System.Windows.Forms.Label();
            this.lblAfficherMissionChef = new System.Windows.Forms.Label();
            this.lblAfficherMissionBudget = new System.Windows.Forms.Label();
            this.grpAfficherMission = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAfficherMission)).BeginInit();
            this.grpAfficherMission.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAfficherMission
            // 
            resources.ApplyResources(this.btnAfficherMission, "btnAfficherMission");
            this.btnAfficherMission.Name = "btnAfficherMission";
            this.btnAfficherMission.UseVisualStyleBackColor = true;
            this.btnAfficherMission.Click += new System.EventHandler(this.btnAfficherMission_Click);
            // 
            // picAfficherMission
            // 
            resources.ApplyResources(this.picAfficherMission, "picAfficherMission");
            this.picAfficherMission.Name = "picAfficherMission";
            this.picAfficherMission.TabStop = false;
            // 
            // lblNomMission
            // 
            resources.ApplyResources(this.lblNomMission, "lblNomMission");
            this.lblNomMission.Name = "lblNomMission";
            // 
            // lblAfficherMissionDateDeb
            // 
            resources.ApplyResources(this.lblAfficherMissionDateDeb, "lblAfficherMissionDateDeb");
            this.lblAfficherMissionDateDeb.Name = "lblAfficherMissionDateDeb";
            // 
            // lblAfficherMissionDateFin
            // 
            resources.ApplyResources(this.lblAfficherMissionDateFin, "lblAfficherMissionDateFin");
            this.lblAfficherMissionDateFin.Name = "lblAfficherMissionDateFin";
            // 
            // lblAfficherMissionChef
            // 
            resources.ApplyResources(this.lblAfficherMissionChef, "lblAfficherMissionChef");
            this.lblAfficherMissionChef.Name = "lblAfficherMissionChef";
            // 
            // lblAfficherMissionBudget
            // 
            resources.ApplyResources(this.lblAfficherMissionBudget, "lblAfficherMissionBudget");
            this.lblAfficherMissionBudget.Name = "lblAfficherMissionBudget";
            // 
            // grpAfficherMission
            // 
            this.grpAfficherMission.Controls.Add(this.lblAfficherMissionBudget);
            this.grpAfficherMission.Controls.Add(this.lblAfficherMissionDateDeb);
            this.grpAfficherMission.Controls.Add(this.lblAfficherMissionChef);
            this.grpAfficherMission.Controls.Add(this.lblAfficherMissionDateFin);
            resources.ApplyResources(this.grpAfficherMission, "grpAfficherMission");
            this.grpAfficherMission.Name = "grpAfficherMission";
            this.grpAfficherMission.TabStop = false;
            // 
            // MissionViewer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNomMission);
            this.Controls.Add(this.picAfficherMission);
            this.Controls.Add(this.btnAfficherMission);
            this.Controls.Add(this.grpAfficherMission);
            this.Name = "MissionViewer";
            this.Load += new System.EventHandler(this.MissionViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAfficherMission)).EndInit();
            this.grpAfficherMission.ResumeLayout(false);
            this.grpAfficherMission.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAfficherMission;
        private System.Windows.Forms.PictureBox picAfficherMission;
        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.Label lblAfficherMissionDateDeb;
        private System.Windows.Forms.Label lblAfficherMissionDateFin;
        private System.Windows.Forms.Label lblAfficherMissionChef;
        private System.Windows.Forms.Label lblAfficherMissionBudget;
        private System.Windows.Forms.GroupBox grpAfficherMission;
    }
}
