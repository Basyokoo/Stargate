namespace Stargate
{
    partial class FormCreerCompte
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblMdpConfirm = new System.Windows.Forms.Label();
            this.txtMdpConfirm = new System.Windows.Forms.TextBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.pnlBoutons = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.pnlBoutons.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitre
            //
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(50, 130, 255);
            this.lblTitre.Location = new System.Drawing.Point(15, 12);
            this.lblTitre.Size = new System.Drawing.Size(360, 28);
            this.lblTitre.Text = "➕ Création d'un compte";
            //
            // lblLogin
            //
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(50, 130, 255);
            this.lblLogin.Location = new System.Drawing.Point(15, 52);
            this.lblLogin.Size = new System.Drawing.Size(360, 18);
            this.lblLogin.Text = "Identifiant";
            //
            // txtLogin
            //
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(28, 40, 70);
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtLogin.Location = new System.Drawing.Point(15, 72);
            this.txtLogin.Size = new System.Drawing.Size(355, 26);
            //
            // lblMdp
            //
            this.lblMdp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMdp.ForeColor = System.Drawing.Color.FromArgb(50, 130, 255);
            this.lblMdp.Location = new System.Drawing.Point(15, 108);
            this.lblMdp.Size = new System.Drawing.Size(360, 18);
            this.lblMdp.Text = "Mot de passe";
            //
            // txtMdp
            //
            this.txtMdp.BackColor = System.Drawing.Color.FromArgb(28, 40, 70);
            this.txtMdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMdp.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMdp.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtMdp.Location = new System.Drawing.Point(15, 128);
            this.txtMdp.PasswordChar = '●';
            this.txtMdp.Size = new System.Drawing.Size(355, 26);
            //
            // lblMdpConfirm
            //
            this.lblMdpConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMdpConfirm.ForeColor = System.Drawing.Color.FromArgb(50, 130, 255);
            this.lblMdpConfirm.Location = new System.Drawing.Point(15, 164);
            this.lblMdpConfirm.Size = new System.Drawing.Size(360, 18);
            this.lblMdpConfirm.Text = "Confirmer le mot de passe";
            //
            // txtMdpConfirm
            //
            this.txtMdpConfirm.BackColor = System.Drawing.Color.FromArgb(28, 40, 70);
            this.txtMdpConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMdpConfirm.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMdpConfirm.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtMdpConfirm.Location = new System.Drawing.Point(15, 184);
            this.txtMdpConfirm.PasswordChar = '●';
            this.txtMdpConfirm.Size = new System.Drawing.Size(355, 26);
            //
            // lblErreur
            //
            this.lblErreur.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Italic);
            this.lblErreur.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.lblErreur.Location = new System.Drawing.Point(15, 218);
            this.lblErreur.Size = new System.Drawing.Size(355, 18);
            this.lblErreur.Text = "";
            this.lblErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlBoutons
            //
            this.pnlBoutons.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.pnlBoutons.Controls.Add(this.btnValider);
            this.pnlBoutons.Controls.Add(this.btnAnnuler);
            this.pnlBoutons.Location = new System.Drawing.Point(0, 285);
            this.pnlBoutons.Size = new System.Drawing.Size(400, 45);
            //
            // btnValider
            //
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(30, 80, 50);
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnValider.Location = new System.Drawing.Point(200, 8);
            this.btnValider.Size = new System.Drawing.Size(90, 28);
            this.btnValider.Text = "✔  Créer";
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            //
            // btnAnnuler
            //
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(80, 30, 30);
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnAnnuler.Location = new System.Drawing.Point(300, 8);
            this.btnAnnuler.Size = new System.Drawing.Size(90, 28);
            this.btnAnnuler.Text = "✖  Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            //
            // FormCreerCompte
            //
            this.AcceptButton = this.btnValider;
            this.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.ClientSize = new System.Drawing.Size(400, 330);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.txtMdp);
            this.Controls.Add(this.lblMdpConfirm);
            this.Controls.Add(this.txtMdpConfirm);
            this.Controls.Add(this.lblErreur);
            this.Controls.Add(this.pnlBoutons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Créer un compte";
            this.pnlBoutons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblMdpConfirm;
        private System.Windows.Forms.TextBox txtMdpConfirm;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Panel pnlBoutons;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
