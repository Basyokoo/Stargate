namespace StargateControlLibrary
{
    partial class MissionViewer
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlStatusBar = new System.Windows.Forms.Panel();
            this.picAfficherMission = new System.Windows.Forms.PictureBox();
            this.lblNomMission = new System.Windows.Forms.Label();
            this.lblDateDeb = new System.Windows.Forms.Label();
            this.lblDateFin = new System.Windows.Forms.Label();
            this.lblChef = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.pnlStatutBadge = new System.Windows.Forms.Panel();
            this.lblStatut = new System.Windows.Forms.Label();
            this.btnAfficherMission = new System.Windows.Forms.Button();
            this.pnlSep = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picAfficherMission)).BeginInit();
            this.pnlStatutBadge.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlStatusBar — barre colorée gauche indiquant le statut de la mission
            //
            this.pnlStatusBar.Location = new System.Drawing.Point(0, 0);
            this.pnlStatusBar.Name = "pnlStatusBar";
            this.pnlStatusBar.Size = new System.Drawing.Size(6, 130);
            this.pnlStatusBar.BackColor = System.Drawing.Color.FromArgb(140, 155, 180);
            //
            // picAfficherMission — image de la planète (fond jaune = placeholder)
            //
            this.picAfficherMission.BackColor = System.Drawing.Color.FromArgb(255, 200, 0);
            this.picAfficherMission.Location = new System.Drawing.Point(18, 15);
            this.picAfficherMission.Name = "picAfficherMission";
            this.picAfficherMission.Size = new System.Drawing.Size(90, 90);
            this.picAfficherMission.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAfficherMission.TabStop = false;
            //
            // lblNomMission — nom de la mission en grand titre or
            //
            this.lblNomMission.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblNomMission.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblNomMission.Location = new System.Drawing.Point(124, 8);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(580, 32);
            //
            // lblDateDeb — date de départ de la mission
            //
            this.lblDateDeb.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDateDeb.ForeColor = System.Drawing.Color.FromArgb(100, 200, 255);
            this.lblDateDeb.Location = new System.Drawing.Point(124, 46);
            this.lblDateDeb.Name = "lblDateDeb";
            this.lblDateDeb.Size = new System.Drawing.Size(400, 26);
            //
            // lblDateFin — date de retour prévue
            //
            this.lblDateFin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDateFin.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblDateFin.Location = new System.Drawing.Point(124, 76);
            this.lblDateFin.Name = "lblDateFin";
            this.lblDateFin.Size = new System.Drawing.Size(400, 26);
            //
            // lblChef — nom du chef de mission
            //
            this.lblChef.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblChef.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblChef.Location = new System.Drawing.Point(540, 46);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(480, 26);
            //
            // lblBudget — budget alloué à la mission
            //
            this.lblBudget.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblBudget.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblBudget.Location = new System.Drawing.Point(540, 76);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(480, 26);
            //
            // pnlStatutBadge — badge coloré indiquant En cours / À venir / Terminé
            //
            this.pnlStatutBadge.BackColor = System.Drawing.Color.FromArgb(30, 50, 90);
            this.pnlStatutBadge.Controls.Add(this.lblStatut);
            this.pnlStatutBadge.Location = new System.Drawing.Point(1080, 12);
            this.pnlStatutBadge.Name = "pnlStatutBadge";
            this.pnlStatutBadge.Size = new System.Drawing.Size(150, 32);
            //
            // lblStatut — texte du statut dans le badge
            //
            this.lblStatut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStatut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblStatut.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblStatut.Location = new System.Drawing.Point(0, 0);
            this.lblStatut.Name = "lblStatut";
            this.lblStatut.Size = new System.Drawing.Size(150, 32);
            this.lblStatut.Text = "—";
            this.lblStatut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnAfficherMission — bouton pour ouvrir le récapitulatif de la mission
            //
            this.btnAfficherMission.BackColor = System.Drawing.Color.FromArgb(30, 60, 110);
            this.btnAfficherMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAfficherMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAfficherMission.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnAfficherMission.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnAfficherMission.Location = new System.Drawing.Point(1270, 30);
            this.btnAfficherMission.Name = "btnAfficherMission";
            this.btnAfficherMission.Size = new System.Drawing.Size(170, 60);
            this.btnAfficherMission.Text = "▶  Voir la\nmission";
            this.btnAfficherMission.Click += new System.EventHandler(this.btnAfficherMission_Click);
            //
            // pnlSep — ligne de séparation en bas de la carte
            //
            this.pnlSep.BackColor = System.Drawing.Color.FromArgb(35, 50, 80);
            this.pnlSep.Location = new System.Drawing.Point(0, 129);
            this.pnlSep.Name = "pnlSep";
            this.pnlSep.Size = new System.Drawing.Size(1460, 1);
            //
            // MissionViewer — carte de mission avec indicateur de statut
            //
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.Controls.Add(this.pnlStatusBar);
            this.Controls.Add(this.picAfficherMission);
            this.Controls.Add(this.lblNomMission);
            this.Controls.Add(this.lblDateDeb);
            this.Controls.Add(this.lblDateFin);
            this.Controls.Add(this.lblChef);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.pnlStatutBadge);
            this.Controls.Add(this.btnAfficherMission);
            this.Controls.Add(this.pnlSep);
            this.Margin = new System.Windows.Forms.Padding(8, 6, 8, 6);
            this.Name = "MissionViewer";
            this.Size = new System.Drawing.Size(1460, 130);
            this.Load += new System.EventHandler(this.MissionViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAfficherMission)).EndInit();
            this.pnlStatutBadge.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // Contrôles déclarés
        private System.Windows.Forms.Panel pnlStatusBar;
        private System.Windows.Forms.PictureBox picAfficherMission;
        private System.Windows.Forms.Label lblNomMission;
        private System.Windows.Forms.Label lblDateDeb;
        private System.Windows.Forms.Label lblDateFin;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Panel pnlStatutBadge;
        private System.Windows.Forms.Label lblStatut;
        private System.Windows.Forms.Button btnAfficherMission;
        private System.Windows.Forms.Panel pnlSep;
    }
}
