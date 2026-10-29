namespace Stargate
{
    partial class FormAjoutJournal
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
            this.lblDate = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.TextBox();
            this.pnlBoutons = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.pnlBoutons.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitre
            //
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblTitre.Location = new System.Drawing.Point(15, 12);
            this.lblTitre.Size = new System.Drawing.Size(440, 28);
            this.lblTitre.Text = "\U0001f4cb Nouvelle entrée de journal";
            //
            // lblInfo
            //
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblInfo.Location = new System.Drawing.Point(15, 44);
            this.lblInfo.Size = new System.Drawing.Size(440, 18);
            this.lblInfo.Text = "ℹ Date plancher : —  Si entrée existante ce jour : texte ajouté à la suite.";
            //
            // lblDate
            //
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblDate.Location = new System.Drawing.Point(15, 75);
            this.lblDate.Size = new System.Drawing.Size(160, 22);
            this.lblDate.Text = "Date de l'événement :";
            //
            // dtpDate
            //
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(185, 72);
            this.dtpDate.Size = new System.Drawing.Size(150, 22);
            //
            // lblCommentaire
            //
            this.lblCommentaire.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblCommentaire.Location = new System.Drawing.Point(15, 108);
            this.lblCommentaire.Size = new System.Drawing.Size(160, 22);
            this.lblCommentaire.Text = "Commentaire :";
            //
            // txtCommentaire
            //
            this.txtCommentaire.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.txtCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommentaire.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCommentaire.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtCommentaire.Location = new System.Drawing.Point(15, 130);
            this.txtCommentaire.Multiline = true;
            this.txtCommentaire.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommentaire.Size = new System.Drawing.Size(440, 100);
            //
            // pnlBoutons
            //
            this.pnlBoutons.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.pnlBoutons.Controls.Add(this.btnValider);
            this.pnlBoutons.Controls.Add(this.btnAnnuler);
            this.pnlBoutons.Location = new System.Drawing.Point(0, 240);
            this.pnlBoutons.Size = new System.Drawing.Size(480, 45);
            //
            // btnValider
            //
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(30, 80, 50);
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnValider.Location = new System.Drawing.Point(270, 8);
            this.btnValider.Size = new System.Drawing.Size(90, 28);
            this.btnValider.Text = "✔  Valider";
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            //
            // btnAnnuler
            //
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(80, 30, 30);
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnAnnuler.Location = new System.Drawing.Point(375, 8);
            this.btnAnnuler.Size = new System.Drawing.Size(90, 28);
            this.btnAnnuler.Text = "✖  Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            //
            // FormAjoutJournal
            //
            this.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.ClientSize = new System.Drawing.Size(480, 285);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.txtCommentaire);
            this.Controls.Add(this.pnlBoutons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvelle entrée de journal";
            this.pnlBoutons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.TextBox txtCommentaire;
        private System.Windows.Forms.Panel pnlBoutons;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
