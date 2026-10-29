namespace StargateControlLibrary
{
    partial class Alien
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
            this.picAlien               = new System.Windows.Forms.PictureBox();
            this.lblTypeAlien           = new System.Windows.Forms.Label();
            this.lblIdAlien             = new System.Windows.Forms.Label();
            this.lblAgressifOn          = new System.Windows.Forms.Label();
            this.lblDatePremierContact  = new System.Windows.Forms.Label();
            this.pnlSep                 = new System.Windows.Forms.Panel();
            this.lblDegresBA            = new System.Windows.Forms.Label();
            this.lblArmeInstru          = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAlien)).BeginInit();
            this.SuspendLayout();

            // ── picAlien ────────────────────────────────────────────
            this.picAlien.Location  = new System.Drawing.Point(8, 8);
            this.picAlien.Name      = "picAlien";
            this.picAlien.Size      = new System.Drawing.Size(150, 196);
            this.picAlien.SizeMode  = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAlien.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.picAlien.TabIndex  = 0;
            this.picAlien.TabStop   = false;

            // ── lblTypeAlien — nom de l'espèce ───────────────────────
            this.lblTypeAlien.Location  = new System.Drawing.Point(170, 10);
            this.lblTypeAlien.Name      = "lblTypeAlien";
            this.lblTypeAlien.Size      = new System.Drawing.Size(262, 32);
            this.lblTypeAlien.Font      = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTypeAlien.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblTypeAlien.TabIndex  = 1;

            // ── lblIdAlien ───────────────────────────────────────────
            this.lblIdAlien.Location  = new System.Drawing.Point(170, 48);
            this.lblIdAlien.Name      = "lblIdAlien";
            this.lblIdAlien.Size      = new System.Drawing.Size(262, 22);
            this.lblIdAlien.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIdAlien.ForeColor = System.Drawing.Color.FromArgb(110, 130, 170);
            this.lblIdAlien.TabIndex  = 2;

            // ── lblAgressifOn — badge statut ─────────────────────────
            this.lblAgressifOn.Location  = new System.Drawing.Point(170, 80);
            this.lblAgressifOn.Name      = "lblAgressifOn";
            this.lblAgressifOn.Size      = new System.Drawing.Size(140, 28);
            this.lblAgressifOn.Font      = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblAgressifOn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAgressifOn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAgressifOn.TabIndex  = 3;

            // ── lblDatePremierContact ────────────────────────────────
            this.lblDatePremierContact.Location  = new System.Drawing.Point(170, 120);
            this.lblDatePremierContact.Name      = "lblDatePremierContact";
            this.lblDatePremierContact.Size      = new System.Drawing.Size(262, 22);
            this.lblDatePremierContact.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDatePremierContact.ForeColor = System.Drawing.Color.FromArgb(150, 165, 195);
            this.lblDatePremierContact.TabIndex  = 4;

            // ── pnlSep — séparateur horizontal ───────────────────────
            this.pnlSep.Location  = new System.Drawing.Point(8, 213);
            this.pnlSep.Name      = "pnlSep";
            this.pnlSep.Size      = new System.Drawing.Size(424, 1);
            this.pnlSep.BackColor = System.Drawing.Color.FromArgb(45, 65, 120);
            this.pnlSep.TabIndex  = 6;

            // ── lblDegresBA ──────────────────────────────────────────
            this.lblDegresBA.Location  = new System.Drawing.Point(8, 222);
            this.lblDegresBA.Name      = "lblDegresBA";
            this.lblDegresBA.Size      = new System.Drawing.Size(208, 36);
            this.lblDegresBA.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDegresBA.ForeColor = System.Drawing.Color.FromArgb(160, 175, 200);
            this.lblDegresBA.TabIndex  = 5;

            // ── lblArmeInstru ────────────────────────────────────────
            this.lblArmeInstru.Location  = new System.Drawing.Point(224, 222);
            this.lblArmeInstru.Name      = "lblArmeInstru";
            this.lblArmeInstru.Size      = new System.Drawing.Size(208, 36);
            this.lblArmeInstru.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblArmeInstru.ForeColor = System.Drawing.Color.FromArgb(160, 175, 200);
            this.lblArmeInstru.TabIndex  = 7;

            // ── Alien (contrôle) ─────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode  = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor      = System.Drawing.Color.FromArgb(20, 30, 58);
            this.Font           = new System.Drawing.Font("Segoe UI", 10F);
            this.Margin         = new System.Windows.Forms.Padding(6);
            this.Name           = "Alien";
            this.Size           = new System.Drawing.Size(440, 265);
            this.Controls.Add(this.picAlien);
            this.Controls.Add(this.lblTypeAlien);
            this.Controls.Add(this.lblIdAlien);
            this.Controls.Add(this.lblAgressifOn);
            this.Controls.Add(this.lblDatePremierContact);
            this.Controls.Add(this.pnlSep);
            this.Controls.Add(this.lblDegresBA);
            this.Controls.Add(this.lblArmeInstru);

            ((System.ComponentModel.ISupportInitialize)(this.picAlien)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox picAlien;
        private System.Windows.Forms.Label      lblTypeAlien;
        private System.Windows.Forms.Label      lblIdAlien;
        private System.Windows.Forms.Label      lblAgressifOn;
        private System.Windows.Forms.Label      lblDatePremierContact;
        private System.Windows.Forms.Panel      pnlSep;
        private System.Windows.Forms.Label      lblDegresBA;
        private System.Windows.Forms.Label      lblArmeInstru;
    }
}
