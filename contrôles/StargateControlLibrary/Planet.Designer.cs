namespace StargateControlLibrary
{
    partial class Planet
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
            this.picPlanet          = new System.Windows.Forms.PictureBox();
            this.lblPlanetName      = new System.Windows.Forms.Label();
            this.pnlSep             = new System.Windows.Forms.Panel();
            this.lblPlanetTemp      = new System.Windows.Forms.Label();
            this.lblPlanetGrav      = new System.Windows.Forms.Label();
            this.lblPlanetDataBazOn = new System.Windows.Forms.Label();
            this.button1            = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlanet)).BeginInit();
            this.SuspendLayout();

            // ── picPlanet ────────────────────────────────────────────
            this.picPlanet.Location  = new System.Drawing.Point(8, 8);
            this.picPlanet.Name      = "picPlanet";
            this.picPlanet.Size      = new System.Drawing.Size(284, 186);
            this.picPlanet.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPlanet.BackColor = System.Drawing.Color.FromArgb(8, 12, 25);
            this.picPlanet.TabIndex  = 0;
            this.picPlanet.TabStop   = false;

            // ── lblPlanetName ────────────────────────────────────────
            this.lblPlanetName.Location  = new System.Drawing.Point(8, 202);
            this.lblPlanetName.Name      = "lblPlanetName";
            this.lblPlanetName.Size      = new System.Drawing.Size(284, 32);
            this.lblPlanetName.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPlanetName.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblPlanetName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlanetName.TabIndex  = 1;
            this.lblPlanetName.Click    += new System.EventHandler(this.lblPlanetName_Click);

            // ── pnlSep ───────────────────────────────────────────────
            this.pnlSep.Location  = new System.Drawing.Point(8, 240);
            this.pnlSep.Name      = "pnlSep";
            this.pnlSep.Size      = new System.Drawing.Size(284, 1);
            this.pnlSep.BackColor = System.Drawing.Color.FromArgb(45, 65, 120);
            this.pnlSep.TabIndex  = 5;

            // ── lblPlanetTemp ────────────────────────────────────────
            this.lblPlanetTemp.Location  = new System.Drawing.Point(12, 249);
            this.lblPlanetTemp.Name      = "lblPlanetTemp";
            this.lblPlanetTemp.Size      = new System.Drawing.Size(276, 22);
            this.lblPlanetTemp.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPlanetTemp.ForeColor = System.Drawing.Color.FromArgb(175, 190, 215);
            this.lblPlanetTemp.TabIndex  = 2;

            // ── lblPlanetGrav ────────────────────────────────────────
            this.lblPlanetGrav.Location  = new System.Drawing.Point(12, 276);
            this.lblPlanetGrav.Name      = "lblPlanetGrav";
            this.lblPlanetGrav.Size      = new System.Drawing.Size(276, 22);
            this.lblPlanetGrav.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPlanetGrav.ForeColor = System.Drawing.Color.FromArgb(175, 190, 215);
            this.lblPlanetGrav.TabIndex  = 3;

            // ── lblPlanetDataBazOn ───────────────────────────────────
            this.lblPlanetDataBazOn.Location  = new System.Drawing.Point(12, 303);
            this.lblPlanetDataBazOn.Name      = "lblPlanetDataBazOn";
            this.lblPlanetDataBazOn.Size      = new System.Drawing.Size(276, 22);
            this.lblPlanetDataBazOn.Font      = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPlanetDataBazOn.TabIndex  = 4;

            // ── button1 ──────────────────────────────────────────────
            this.button1.Location   = new System.Drawing.Point(8, 336);
            this.button1.Name       = "button1";
            this.button1.Size       = new System.Drawing.Size(284, 34);
            this.button1.Text       = "Plus d'informations  →";
            this.button1.Font       = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.button1.BackColor  = System.Drawing.Color.FromArgb(28, 55, 115);
            this.button1.ForeColor  = System.Drawing.Color.FromArgb(210, 230, 255);
            this.button1.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(50, 100, 200);
            this.button1.FlatAppearance.BorderSize  = 1;
            this.button1.Cursor     = System.Windows.Forms.Cursors.Hand;
            this.button1.TabIndex   = 6;
            this.button1.Click     += new System.EventHandler(this.button1_Click);

            // ── Planet (contrôle) ────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode  = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor      = System.Drawing.Color.FromArgb(20, 30, 58);
            this.Font           = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin         = new System.Windows.Forms.Padding(6);
            this.Name           = "Planet";
            this.Size           = new System.Drawing.Size(300, 378);
            this.Controls.Add(this.picPlanet);
            this.Controls.Add(this.lblPlanetName);
            this.Controls.Add(this.pnlSep);
            this.Controls.Add(this.lblPlanetTemp);
            this.Controls.Add(this.lblPlanetGrav);
            this.Controls.Add(this.lblPlanetDataBazOn);
            this.Controls.Add(this.button1);
            this.Load += new System.EventHandler(this.Planet_Load);

            ((System.ComponentModel.ISupportInitialize)(this.picPlanet)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picPlanet;
        private System.Windows.Forms.Label      lblPlanetName;
        private System.Windows.Forms.Panel      pnlSep;
        private System.Windows.Forms.Label      lblPlanetTemp;
        private System.Windows.Forms.Label      lblPlanetGrav;
        private System.Windows.Forms.Label      lblPlanetDataBazOn;
        private System.Windows.Forms.Button     button1;
    }
}
