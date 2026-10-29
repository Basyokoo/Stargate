namespace Stargate
{
    partial class FormAjoutDepense
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
            this.lblMontant = new System.Windows.Forms.Label();
            this.nudMontant = new System.Windows.Forms.NumericUpDown();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblMotif = new System.Windows.Forms.Label();
            this.txtMotif = new System.Windows.Forms.TextBox();
            this.lblJournal = new System.Windows.Forms.Label();
            this.txtCommentaireJournal = new System.Windows.Forms.TextBox();
            this.pnlBoutons = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).BeginInit();
            this.pnlBoutons.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitre
            //
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblTitre.Location = new System.Drawing.Point(15, 12);
            this.lblTitre.Size = new System.Drawing.Size(460, 28);
            this.lblTitre.Text = "\U0001f4b0 Nouvelle dépense";
            //
            // lblInfo
            //
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblInfo.Location = new System.Drawing.Point(15, 44);
            this.lblInfo.Size = new System.Drawing.Size(460, 18);
            this.lblInfo.Text = "ℹ Date plancher : —  Budget restant : —";
            //
            // lblDate
            //
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblDate.Location = new System.Drawing.Point(15, 75);
            this.lblDate.Size = new System.Drawing.Size(155, 22);
            this.lblDate.Text = "Date de la dépense :";
            //
            // dtpDate
            //
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(175, 72);
            this.dtpDate.Size = new System.Drawing.Size(150, 22);
            //
            // lblMontant
            //
            this.lblMontant.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblMontant.Location = new System.Drawing.Point(15, 108);
            this.lblMontant.Size = new System.Drawing.Size(155, 22);
            this.lblMontant.Text = "Montant (€) :";
            //
            // nudMontant
            //
            this.nudMontant.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.nudMontant.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.nudMontant.Location = new System.Drawing.Point(175, 105);
            this.nudMontant.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudMontant.Size = new System.Drawing.Size(150, 22);
            this.nudMontant.Value = new decimal(new int[] { 100, 0, 0, 0 });
            //
            // lblType
            //
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblType.Location = new System.Drawing.Point(15, 141);
            this.lblType.Size = new System.Drawing.Size(155, 22);
            this.lblType.Text = "Type de dépense :";
            //
            // cmbType
            //
            this.cmbType.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.cmbType.Location = new System.Drawing.Point(175, 138);
            this.cmbType.Size = new System.Drawing.Size(200, 22);
            //
            // lblMotif
            //
            this.lblMotif.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblMotif.Location = new System.Drawing.Point(15, 174);
            this.lblMotif.Size = new System.Drawing.Size(155, 22);
            this.lblMotif.Text = "Motif :";
            //
            // txtMotif
            //
            this.txtMotif.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.txtMotif.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMotif.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtMotif.Location = new System.Drawing.Point(15, 196);
            this.txtMotif.Multiline = true;
            this.txtMotif.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMotif.Size = new System.Drawing.Size(460, 60);
            //
            // lblJournal
            //
            this.lblJournal.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblJournal.ForeColor = System.Drawing.Color.FromArgb(80, 180, 120);
            this.lblJournal.Location = new System.Drawing.Point(15, 268);
            this.lblJournal.Size = new System.Drawing.Size(460, 18);
            this.lblJournal.Text = "\U0001f4cb Commentaire journal (généré automatiquement pour cette date) :";
            //
            // txtCommentaireJournal
            //
            this.txtCommentaireJournal.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.txtCommentaireJournal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCommentaireJournal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCommentaireJournal.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtCommentaireJournal.Location = new System.Drawing.Point(15, 290);
            this.txtCommentaireJournal.Multiline = true;
            this.txtCommentaireJournal.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCommentaireJournal.Size = new System.Drawing.Size(460, 60);
            //
            // pnlBoutons
            //
            this.pnlBoutons.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.pnlBoutons.Controls.Add(this.btnValider);
            this.pnlBoutons.Controls.Add(this.btnAnnuler);
            this.pnlBoutons.Location = new System.Drawing.Point(0, 365);
            this.pnlBoutons.Size = new System.Drawing.Size(500, 45);
            //
            // btnValider
            //
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(30, 80, 50);
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnValider.Location = new System.Drawing.Point(290, 8);
            this.btnValider.Size = new System.Drawing.Size(90, 28);
            this.btnValider.Text = "✔  Valider";
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            //
            // btnAnnuler
            //
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(80, 30, 30);
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnAnnuler.Location = new System.Drawing.Point(395, 8);
            this.btnAnnuler.Size = new System.Drawing.Size(90, 28);
            this.btnAnnuler.Text = "✖  Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            //
            // FormAjoutDepense
            //
            this.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.ClientSize = new System.Drawing.Size(500, 410);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblMontant);
            this.Controls.Add(this.nudMontant);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.txtMotif);
            this.Controls.Add(this.lblJournal);
            this.Controls.Add(this.txtCommentaireJournal);
            this.Controls.Add(this.pnlBoutons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvelle dépense";
            ((System.ComponentModel.ISupportInitialize)(this.nudMontant)).EndInit();
            this.pnlBoutons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblMontant;
        private System.Windows.Forms.NumericUpDown nudMontant;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox txtMotif;
        private System.Windows.Forms.Label lblJournal;
        private System.Windows.Forms.TextBox txtCommentaireJournal;
        private System.Windows.Forms.Panel pnlBoutons;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
