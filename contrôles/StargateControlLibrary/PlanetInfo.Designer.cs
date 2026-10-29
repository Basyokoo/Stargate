namespace StargateControlLibrary
{
    partial class PlanetInfo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader          = new System.Windows.Forms.Panel();
            this.pictureBox1        = new System.Windows.Forms.PictureBox();
            this.lblNom             = new System.Windows.Forms.Label();
            this.pnlSelectedAlien   = new System.Windows.Forms.Panel();
            this.lblNomEsp          = new System.Windows.Forms.Label();
            this.lblPourcentageEsp  = new System.Windows.Forms.Label();
            this.pnlSepH            = new System.Windows.Forms.Panel();
            this.flpEsp             = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlSelectedAlien.SuspendLayout();
            this.SuspendLayout();

            // ── pnlHeader (Dock=Top) ─────────────────────────────────
            this.pnlHeader.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Height    = 210;
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(14, 22, 45);
            this.pnlHeader.Name      = "pnlHeader";
            this.pnlHeader.Padding   = new System.Windows.Forms.Padding(8);

            // ── pictureBox1 ──────────────────────────────────────────
            this.pictureBox1.Location  = new System.Drawing.Point(8, 8);
            this.pictureBox1.Name      = "pictureBox1";
            this.pictureBox1.Size      = new System.Drawing.Size(210, 192);
            this.pictureBox1.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(8, 12, 25);
            this.pictureBox1.TabIndex  = 0;
            this.pictureBox1.TabStop   = false;

            // ── lblNom — nom de la planète ───────────────────────────
            this.lblNom.Location  = new System.Drawing.Point(232, 12);
            this.lblNom.Name      = "lblNom";
            this.lblNom.Size      = new System.Drawing.Size(500, 46);
            this.lblNom.Font      = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblNom.TabIndex  = 1;
            this.lblNom.Anchor    = System.Windows.Forms.AnchorStyles.Top
                                  | System.Windows.Forms.AnchorStyles.Left
                                  | System.Windows.Forms.AnchorStyles.Right;
            this.lblNom.Click    += new System.EventHandler(this.lblNom_Click);

            // ── pnlSelectedAlien — panneau espèce sélectionnée ───────
            this.pnlSelectedAlien.Location  = new System.Drawing.Point(232, 68);
            this.pnlSelectedAlien.Name      = "pnlSelectedAlien";
            this.pnlSelectedAlien.Size      = new System.Drawing.Size(500, 90);
            this.pnlSelectedAlien.BackColor = System.Drawing.Color.FromArgb(20, 32, 65);
            this.pnlSelectedAlien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectedAlien.TabIndex  = 2;
            this.pnlSelectedAlien.Anchor    = System.Windows.Forms.AnchorStyles.Top
                                            | System.Windows.Forms.AnchorStyles.Left
                                            | System.Windows.Forms.AnchorStyles.Right;

            // lblNomEsp
            this.lblNomEsp.Location  = new System.Drawing.Point(10, 10);
            this.lblNomEsp.Name      = "lblNomEsp";
            this.lblNomEsp.Size      = new System.Drawing.Size(480, 28);
            this.lblNomEsp.Font      = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblNomEsp.ForeColor = System.Drawing.Color.FromArgb(210, 225, 255);
            this.lblNomEsp.Text      = "— Cliquez sur une espèce —";
            this.lblNomEsp.TabIndex  = 0;

            // lblPourcentageEsp
            this.lblPourcentageEsp.Location  = new System.Drawing.Point(10, 46);
            this.lblPourcentageEsp.Name      = "lblPourcentageEsp";
            this.lblPourcentageEsp.Size      = new System.Drawing.Size(480, 26);
            this.lblPourcentageEsp.Font      = new System.Drawing.Font("Segoe UI", 10F);
            this.lblPourcentageEsp.ForeColor = System.Drawing.Color.FromArgb(130, 160, 210);
            this.lblPourcentageEsp.TabIndex  = 1;

            // ── pnlSepH — séparateur sous le header ──────────────────
            this.pnlSepH.Dock      = System.Windows.Forms.DockStyle.Top;
            this.pnlSepH.Height    = 2;
            this.pnlSepH.BackColor = System.Drawing.Color.FromArgb(45, 65, 120);
            this.pnlSepH.Name      = "pnlSepH";

            // ── flpEsp — liste des espèces (Dock=Fill) ───────────────
            this.flpEsp.Dock          = System.Windows.Forms.DockStyle.Fill;
            this.flpEsp.AutoScroll    = true;
            this.flpEsp.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flpEsp.WrapContents  = true;
            this.flpEsp.BackColor     = System.Drawing.Color.FromArgb(12, 18, 35);
            this.flpEsp.Padding       = new System.Windows.Forms.Padding(8);
            this.flpEsp.Name          = "flpEsp";
            this.flpEsp.TabIndex      = 3;

            // ── Assemblage ───────────────────────────────────────────
            this.pnlSelectedAlien.Controls.Add(this.lblNomEsp);
            this.pnlSelectedAlien.Controls.Add(this.lblPourcentageEsp);

            this.pnlHeader.Controls.Add(this.pictureBox1);
            this.pnlHeader.Controls.Add(this.lblNom);
            this.pnlHeader.Controls.Add(this.pnlSelectedAlien);

            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode  = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor      = System.Drawing.Color.FromArgb(12, 18, 35);
            this.Font           = new System.Drawing.Font("Segoe UI", 10F);
            this.Name           = "PlanetInfo";
            this.Size           = new System.Drawing.Size(900, 700);

            // Ordre d'ajout important pour Dock : Fill en dernier
            this.Controls.Add(this.flpEsp);
            this.Controls.Add(this.pnlSepH);
            this.Controls.Add(this.pnlHeader);

            this.Load += new System.EventHandler(this.PlanetInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlSelectedAlien.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel          pnlHeader;
        private System.Windows.Forms.PictureBox     pictureBox1;
        private System.Windows.Forms.Label          lblNom;
        private System.Windows.Forms.Panel          pnlSelectedAlien;
        private System.Windows.Forms.Label          lblNomEsp;
        private System.Windows.Forms.Label          lblPourcentageEsp;
        private System.Windows.Forms.Panel          pnlSepH;
        private System.Windows.Forms.FlowLayoutPanel flpEsp;
    }
}
