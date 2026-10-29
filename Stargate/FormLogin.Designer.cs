namespace Stargate
{
    partial class FormLogin
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.sep = new System.Windows.Forms.Panel();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblMdp = new System.Windows.Forms.Label();
            this.txtMdp = new System.Windows.Forms.TextBox();
            this.lblErreur = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.pnlCarte.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlCarte — carte de connexion avec bordure peinte
            //
            this.pnlCarte.BackColor = System.Drawing.Color.FromArgb(18, 28, 52);
            this.pnlCarte.Controls.Add(this.lblTitre);
            this.pnlCarte.Controls.Add(this.lblSousTitre);
            this.pnlCarte.Controls.Add(this.sep);
            this.pnlCarte.Controls.Add(this.lblLogin);
            this.pnlCarte.Controls.Add(this.txtLogin);
            this.pnlCarte.Controls.Add(this.lblMdp);
            this.pnlCarte.Controls.Add(this.txtMdp);
            this.pnlCarte.Controls.Add(this.lblErreur);
            this.pnlCarte.Controls.Add(this.btnConnexion);
            this.pnlCarte.Location = new System.Drawing.Point(30, 25);
            this.pnlCarte.Size = new System.Drawing.Size(390, 330);
            //
            // lblTitre — titre principal en or
            //
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblTitre.Location = new System.Drawing.Point(0, 22);
            this.lblTitre.Size = new System.Drawing.Size(390, 34);
            this.lblTitre.Text = "✦  STARGATE COMMAND  ✦";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblSousTitre — texte secondaire italique
            //
            this.lblSousTitre.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblSousTitre.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblSousTitre.Location = new System.Drawing.Point(0, 60);
            this.lblSousTitre.Size = new System.Drawing.Size(390, 24);
            this.lblSousTitre.Text = "Accès réservé — Créer une mission";
            this.lblSousTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // sep — séparateur bleu horizontal
            //
            this.sep.BackColor = System.Drawing.Color.FromArgb(40, 80, 160);
            this.sep.Location = new System.Drawing.Point(30, 92);
            this.sep.Size = new System.Drawing.Size(330, 1);
            //
            // lblLogin — étiquette du champ identifiant
            //
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblLogin.ForeColor = System.Drawing.Color.FromArgb(50, 130, 255);
            this.lblLogin.Location = new System.Drawing.Point(30, 108);
            this.lblLogin.Size = new System.Drawing.Size(330, 24);
            this.lblLogin.Text = "Identifiant";
            //
            // txtLogin — champ de saisie de l'identifiant
            //
            this.txtLogin.BackColor = System.Drawing.Color.FromArgb(28, 40, 70);
            this.txtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLogin.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtLogin.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtLogin.Location = new System.Drawing.Point(30, 136);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(330, 33);
            //
            // lblMdp — étiquette du champ mot de passe
            //
            this.lblMdp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblMdp.ForeColor = System.Drawing.Color.FromArgb(50, 130, 255);
            this.lblMdp.Location = new System.Drawing.Point(30, 184);
            this.lblMdp.Size = new System.Drawing.Size(330, 24);
            this.lblMdp.Text = "Mot de passe";
            //
            // txtMdp — champ de saisie du mot de passe (masqué)
            //
            this.txtMdp.BackColor = System.Drawing.Color.FromArgb(28, 40, 70);
            this.txtMdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMdp.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtMdp.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtMdp.Location = new System.Drawing.Point(30, 212);
            this.txtMdp.Name = "txtMdp";
            this.txtMdp.PasswordChar = '●';
            this.txtMdp.Size = new System.Drawing.Size(330, 33);
            //
            // lblErreur — message d'erreur rouge (masqué par défaut)
            //
            this.lblErreur.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Italic);
            this.lblErreur.ForeColor = System.Drawing.Color.FromArgb(255, 80, 80);
            this.lblErreur.Location = new System.Drawing.Point(30, 255);
            this.lblErreur.Size = new System.Drawing.Size(330, 24);
            this.lblErreur.Text = "";
            this.lblErreur.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnConnexion — bouton principal de connexion
            //
            this.btnConnexion.BackColor = System.Drawing.Color.FromArgb(25, 65, 140);
            this.btnConnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnexion.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnConnexion.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnConnexion.Location = new System.Drawing.Point(30, 284);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(330, 40);
            this.btnConnexion.Text = "🔓  Se connecter";
            this.btnConnexion.Click += new System.EventHandler(this.BtnConnexion_Click);
            //
            // FormLogin — dialogue d'authentification Stargate
            //
            this.AcceptButton = this.btnConnexion;
            this.BackColor = System.Drawing.Color.FromArgb(8, 12, 25);
            this.ClientSize = new System.Drawing.Size(450, 385);
            this.Controls.Add(this.pnlCarte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stargate — Authentification";
            this.pnlCarte.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlCarte;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.Panel sep;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.TextBox txtMdp;
        private System.Windows.Forms.Label lblErreur;
        private System.Windows.Forms.Button btnConnexion;
    }
}
