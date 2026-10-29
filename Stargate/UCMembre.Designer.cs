namespace Stargate
{
    partial class UCMembre
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlCarte = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.lblNomPrenom = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.pnlCarte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCarte
            // 
            this.pnlCarte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(60)))), ((int)(((byte)(100)))));
            this.pnlCarte.Controls.Add(this.picAvatar);
            this.pnlCarte.Controls.Add(this.lblNomPrenom);
            this.pnlCarte.Controls.Add(this.lblRole);
            this.pnlCarte.Controls.Add(this.lblType);
            this.pnlCarte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCarte.Location = new System.Drawing.Point(0, 0);
            this.pnlCarte.Name = "pnlCarte";
            this.pnlCarte.Size = new System.Drawing.Size(111, 139);
            this.pnlCarte.TabIndex = 0;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Location = new System.Drawing.Point(34, 9);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(43, 43);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 3;
            this.picAvatar.TabStop = false;
            // 
            // lblNomPrenom
            // 
            this.lblNomPrenom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNomPrenom.ForeColor = System.Drawing.Color.White;
            this.lblNomPrenom.Location = new System.Drawing.Point(4, 59);
            this.lblNomPrenom.Name = "lblNomPrenom";
            this.lblNomPrenom.Size = new System.Drawing.Size(103, 35);
            this.lblNomPrenom.TabIndex = 0;
            this.lblNomPrenom.Text = "Nom\nPrenom";
            this.lblNomPrenom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRole
            // 
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Italic);
            this.lblRole.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblRole.Location = new System.Drawing.Point(4, 95);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(103, 17);
            this.lblRole.TabIndex = 1;
            this.lblRole.Text = "Role";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lblType.Location = new System.Drawing.Point(4, 114);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(103, 17);
            this.lblType.TabIndex = 2;
            this.lblType.Text = "Type";
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCMembre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlCarte);
            this.Name = "UCMembre";
            this.Size = new System.Drawing.Size(111, 139);
            this.pnlCarte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        public System.Windows.Forms.Panel pnlCarte;
        public System.Windows.Forms.Label lblNomPrenom;
        public System.Windows.Forms.Label lblRole;
        public System.Windows.Forms.Label lblType;
        public System.Windows.Forms.PictureBox picAvatar;
    }
}
