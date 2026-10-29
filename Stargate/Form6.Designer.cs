namespace Stargate
{
    partial class volet6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarTitre = new System.Windows.Forms.Label();
            this.pnlSidebarSep = new System.Windows.Forms.Panel();
            this.pnlContenu = new System.Windows.Forms.Panel();
            this.lblTitreVolet = new System.Windows.Forms.Label();
            this.flpPlanet = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSidebar.SuspendLayout();
            this.pnlContenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.pnlSidebar.Controls.Add(this.lblSidebarTitre);
            this.pnlSidebar.Controls.Add(this.pnlSidebarSep);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(395, 1041);
            this.pnlSidebar.TabIndex = 1;
            // 
            // lblSidebarTitre
            // 
            this.lblSidebarTitre.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.lblSidebarTitre.Location = new System.Drawing.Point(8, 12);
            this.lblSidebarTitre.Name = "lblSidebarTitre";
            this.lblSidebarTitre.Size = new System.Drawing.Size(379, 82);
            this.lblSidebarTitre.TabIndex = 0;
            this.lblSidebarTitre.Text = "✦ STARGATE ✦";
            this.lblSidebarTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSidebarSep
            // 
            this.pnlSidebarSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.pnlSidebarSep.Location = new System.Drawing.Point(12, 102);
            this.pnlSidebarSep.Name = "pnlSidebarSep";
            this.pnlSidebarSep.Size = new System.Drawing.Size(371, 2);
            this.pnlSidebarSep.TabIndex = 1;
            // 
            // pnlContenu
            // 
            this.pnlContenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.pnlContenu.Controls.Add(this.lblTitreVolet);
            this.pnlContenu.Controls.Add(this.flpPlanet);
            this.pnlContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenu.Location = new System.Drawing.Point(395, 0);
            this.pnlContenu.Name = "pnlContenu";
            this.pnlContenu.Size = new System.Drawing.Size(1509, 1041);
            this.pnlContenu.TabIndex = 0;
            // 
            // lblTitreVolet
            // 
            this.lblTitreVolet.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitreVolet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.lblTitreVolet.Location = new System.Drawing.Point(10, 10);
            this.lblTitreVolet.Name = "lblTitreVolet";
            this.lblTitreVolet.Size = new System.Drawing.Size(900, 46);
            this.lblTitreVolet.TabIndex = 0;
            this.lblTitreVolet.Text = "🌍  Volet 6 — Informations sur les planètes";
            // 
            // flpPlanet
            // 
            this.flpPlanet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpPlanet.AutoScroll = true;
            this.flpPlanet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.flpPlanet.Location = new System.Drawing.Point(17, 75);
            this.flpPlanet.Name = "flpPlanet";
            this.flpPlanet.Size = new System.Drawing.Size(1480, 954);
            this.flpPlanet.TabIndex = 1;
            // 
            // volet6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlContenu);
            this.Controls.Add(this.pnlSidebar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "volet6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Stargate — Volet 6 : Planètes";
            this.Load += new System.EventHandler(this.volet5_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarTitre;
        private System.Windows.Forms.Panel pnlSidebarSep;
        private System.Windows.Forms.Panel pnlContenu;
        private System.Windows.Forms.Label lblTitreVolet;
        private System.Windows.Forms.FlowLayoutPanel flpPlanet;
    }
}
