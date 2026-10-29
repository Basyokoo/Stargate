namespace StargateControlLibrary
{
    partial class NavItem
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pbxIcon = new System.Windows.Forms.PictureBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.pnlAccent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).BeginInit();
            this.SuspendLayout();
            //
            // pbxIcon — icône SVG de la section de navigation
            //
            this.pbxIcon.BackColor = System.Drawing.Color.Transparent;
            this.pbxIcon.Location = new System.Drawing.Point(16, 10);
            this.pbxIcon.Name = "pbxIcon";
            this.pbxIcon.Size = new System.Drawing.Size(46, 46);
            this.pbxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxIcon.TabIndex = 0;
            this.pbxIcon.TabStop = false;
            //
            // lblNom — nom de la section (taille augmentée)
            //
            this.lblNom.AutoSize = false;
            this.lblNom.BackColor = System.Drawing.Color.Transparent;
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNom.Location = new System.Drawing.Point(72, 11);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(260, 44);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Section";
            this.lblNom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // pnlAccent — barre verticale gauche visible au survol
            //
            this.pnlAccent.BackColor = System.Drawing.Color.FromArgb(50, 130, 255);
            this.pnlAccent.Location = new System.Drawing.Point(0, 0);
            this.pnlAccent.Name = "pnlAccent";
            this.pnlAccent.Size = new System.Drawing.Size(4, 66);
            this.pnlAccent.Visible = false;
            //
            // NavItem — élément de navigation de la sidebar
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlAccent);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.pbxIcon);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "NavItem";
            this.Size = new System.Drawing.Size(376, 66);
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcon)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.PictureBox pbxIcon;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Panel pnlAccent;
    }
}
