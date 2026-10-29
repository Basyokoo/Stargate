namespace Stargate
{
    partial class FormMajCaptures
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
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblColEspece = new System.Windows.Forms.Label();
            this.lblColObjectif = new System.Windows.Forms.Label();
            this.lblColCaptures = new System.Windows.Forms.Label();
            this.pnlScroll = new System.Windows.Forms.Panel();
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
            this.lblTitre.Size = new System.Drawing.Size(520, 28);
            this.lblTitre.Text = "\U0001f504 Mise à jour des captures d'aliens";
            //
            // lblInfo
            //
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblInfo.Location = new System.Drawing.Point(15, 44);
            this.lblInfo.Size = new System.Drawing.Size(520, 18);
            this.lblInfo.Text = "Modifiez le nombre de captures réalisées pour chaque espèce.";
            //
            // lblColEspece
            //
            this.lblColEspece.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblColEspece.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblColEspece.Location = new System.Drawing.Point(15, 68);
            this.lblColEspece.Size = new System.Drawing.Size(280, 20);
            this.lblColEspece.Text = "Espèce";
            //
            // lblColObjectif
            //
            this.lblColObjectif.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblColObjectif.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblColObjectif.Location = new System.Drawing.Point(300, 68);
            this.lblColObjectif.Size = new System.Drawing.Size(80, 20);
            this.lblColObjectif.Text = "Objectif";
            //
            // lblColCaptures
            //
            this.lblColCaptures.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblColCaptures.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblColCaptures.Location = new System.Drawing.Point(390, 68);
            this.lblColCaptures.Size = new System.Drawing.Size(130, 20);
            this.lblColCaptures.Text = "Captures";
            //
            // pnlScroll
            //
            this.pnlScroll.AutoScroll = true;
            this.pnlScroll.BackColor = System.Drawing.Color.FromArgb(15, 20, 40);
            this.pnlScroll.Location = new System.Drawing.Point(15, 92);
            this.pnlScroll.Size = new System.Drawing.Size(520, 400);
            //
            // pnlBoutons
            //
            this.pnlBoutons.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.pnlBoutons.Controls.Add(this.btnValider);
            this.pnlBoutons.Controls.Add(this.btnAnnuler);
            this.pnlBoutons.Location = new System.Drawing.Point(0, 500);
            this.pnlBoutons.Size = new System.Drawing.Size(560, 45);
            //
            // btnValider
            //
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(30, 80, 50);
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnValider.Location = new System.Drawing.Point(360, 8);
            this.btnValider.Size = new System.Drawing.Size(90, 28);
            this.btnValider.Text = "✔  Valider";
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            //
            // btnAnnuler
            //
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(80, 30, 30);
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnAnnuler.Location = new System.Drawing.Point(460, 8);
            this.btnAnnuler.Size = new System.Drawing.Size(90, 28);
            this.btnAnnuler.Text = "✖  Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            //
            // FormMajCaptures
            //
            this.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.ClientSize = new System.Drawing.Size(560, 545);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblColEspece);
            this.Controls.Add(this.lblColObjectif);
            this.Controls.Add(this.lblColCaptures);
            this.Controls.Add(this.pnlScroll);
            this.Controls.Add(this.pnlBoutons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mise à jour des captures";
            this.pnlBoutons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblColEspece;
        private System.Windows.Forms.Label lblColObjectif;
        private System.Windows.Forms.Label lblColCaptures;
        private System.Windows.Forms.Panel pnlScroll;
        private System.Windows.Forms.Panel pnlBoutons;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
