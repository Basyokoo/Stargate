namespace Stargate
{
    partial class FormAjoutNegociation
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
            this.lblInformateur = new System.Windows.Forms.Label();
            this.cmbInformateur = new System.Windows.Forms.ComboBox();
            this.lblSomme = new System.Windows.Forms.Label();
            this.nudSomme = new System.Windows.Forms.NumericUpDown();
            this.lblApprec = new System.Windows.Forms.Label();
            this.txtApprec = new System.Windows.Forms.TextBox();
            this.pnlAuto = new System.Windows.Forms.Panel();
            this.lblAutoInfo = new System.Windows.Forms.Label();
            this.pnlBoutons = new System.Windows.Forms.Panel();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSomme)).BeginInit();
            this.pnlAuto.SuspendLayout();
            this.pnlBoutons.SuspendLayout();
            this.SuspendLayout();
            //
            // lblTitre
            //
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblTitre.Location = new System.Drawing.Point(15, 12);
            this.lblTitre.Size = new System.Drawing.Size(470, 28);
            this.lblTitre.Text = "\U0001f575️ Nouveau contact / négociation";
            //
            // lblInfo
            //
            this.lblInfo.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Italic);
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblInfo.Location = new System.Drawing.Point(15, 44);
            this.lblInfo.Size = new System.Drawing.Size(470, 18);
            this.lblInfo.Text = "ℹ Date plancher : —  Budget restant : —";
            //
            // lblDate
            //
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblDate.Location = new System.Drawing.Point(15, 78);
            this.lblDate.Size = new System.Drawing.Size(155, 22);
            this.lblDate.Text = "Date du contact :";
            //
            // dtpDate
            //
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(175, 75);
            this.dtpDate.Size = new System.Drawing.Size(150, 22);
            //
            // lblInformateur
            //
            this.lblInformateur.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblInformateur.Location = new System.Drawing.Point(15, 113);
            this.lblInformateur.Size = new System.Drawing.Size(155, 22);
            this.lblInformateur.Text = "Informateur :";
            //
            // cmbInformateur
            //
            this.cmbInformateur.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.cmbInformateur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInformateur.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.cmbInformateur.Location = new System.Drawing.Point(175, 110);
            this.cmbInformateur.Size = new System.Drawing.Size(305, 22);
            //
            // lblSomme
            //
            this.lblSomme.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblSomme.Location = new System.Drawing.Point(15, 148);
            this.lblSomme.Size = new System.Drawing.Size(155, 22);
            this.lblSomme.Text = "Somme versée ($) :";
            //
            // nudSomme
            //
            this.nudSomme.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.nudSomme.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.nudSomme.Location = new System.Drawing.Point(175, 145);
            this.nudSomme.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudSomme.Size = new System.Drawing.Size(150, 22);
            this.nudSomme.Value = new decimal(new int[] { 100, 0, 0, 0 });
            //
            // lblApprec
            //
            this.lblApprec.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblApprec.Location = new System.Drawing.Point(15, 183);
            this.lblApprec.Size = new System.Drawing.Size(155, 22);
            this.lblApprec.Text = "Appréciation :";
            //
            // txtApprec
            //
            this.txtApprec.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.txtApprec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApprec.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtApprec.Location = new System.Drawing.Point(15, 205);
            this.txtApprec.Multiline = true;
            this.txtApprec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtApprec.Size = new System.Drawing.Size(470, 80);
            //
            // pnlAuto
            //
            this.pnlAuto.BackColor = System.Drawing.Color.FromArgb(18, 40, 28);
            this.pnlAuto.Controls.Add(this.lblAutoInfo);
            this.pnlAuto.Location = new System.Drawing.Point(15, 298);
            this.pnlAuto.Size = new System.Drawing.Size(470, 50);
            //
            // lblAutoInfo
            //
            this.lblAutoInfo.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblAutoInfo.ForeColor = System.Drawing.Color.FromArgb(80, 180, 120);
            this.lblAutoInfo.Location = new System.Drawing.Point(8, 6);
            this.lblAutoInfo.Size = new System.Drawing.Size(454, 38);
            this.lblAutoInfo.Text = "✔ Dépense « Informateur » créée automatiquement pour la somme versée.\r\n✔ Entrée de journal ajoutée automatiquement (concaténation si existante).";
            //
            // pnlBoutons
            //
            this.pnlBoutons.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.pnlBoutons.Controls.Add(this.btnValider);
            this.pnlBoutons.Controls.Add(this.btnAnnuler);
            this.pnlBoutons.Location = new System.Drawing.Point(0, 360);
            this.pnlBoutons.Size = new System.Drawing.Size(510, 45);
            //
            // btnValider
            //
            this.btnValider.BackColor = System.Drawing.Color.FromArgb(30, 80, 50);
            this.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValider.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnValider.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnValider.Location = new System.Drawing.Point(300, 8);
            this.btnValider.Size = new System.Drawing.Size(90, 28);
            this.btnValider.Text = "✔  Valider";
            this.btnValider.Click += new System.EventHandler(this.BtnValider_Click);
            //
            // btnAnnuler
            //
            this.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(80, 30, 30);
            this.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnAnnuler.Location = new System.Drawing.Point(405, 8);
            this.btnAnnuler.Size = new System.Drawing.Size(90, 28);
            this.btnAnnuler.Text = "✖  Annuler";
            this.btnAnnuler.Click += new System.EventHandler(this.BtnAnnuler_Click);
            //
            // FormAjoutNegociation
            //
            this.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.ClientSize = new System.Drawing.Size(510, 405);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblInformateur);
            this.Controls.Add(this.cmbInformateur);
            this.Controls.Add(this.lblSomme);
            this.Controls.Add(this.nudSomme);
            this.Controls.Add(this.lblApprec);
            this.Controls.Add(this.txtApprec);
            this.Controls.Add(this.pnlAuto);
            this.Controls.Add(this.pnlBoutons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nouvelle négociation";
            ((System.ComponentModel.ISupportInitialize)(this.nudSomme)).EndInit();
            this.pnlAuto.ResumeLayout(false);
            this.pnlBoutons.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblInformateur;
        private System.Windows.Forms.ComboBox cmbInformateur;
        private System.Windows.Forms.Label lblSomme;
        private System.Windows.Forms.NumericUpDown nudSomme;
        private System.Windows.Forms.Label lblApprec;
        private System.Windows.Forms.TextBox txtApprec;
        private System.Windows.Forms.Panel pnlAuto;
        private System.Windows.Forms.Label lblAutoInfo;
        private System.Windows.Forms.Panel pnlBoutons;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnAnnuler;
    }
}
