namespace Stargate
{
    partial class UCJournal
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlJournal = new System.Windows.Forms.Panel();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCommentaire = new System.Windows.Forms.RichTextBox();
            this.picIcone = new System.Windows.Forms.Label();
            this.pnlJournal.SuspendLayout();
            this.SuspendLayout();

            // pnlJournal
            this.pnlJournal.BackColor = System.Drawing.Color.FromArgb(20, 30, 50);
            this.pnlJournal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pnlJournal.Controls.Add(this.picIcone);
            this.pnlJournal.Controls.Add(this.lblDate);
            this.pnlJournal.Controls.Add(this.txtCommentaire);
            this.pnlJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlJournal.Location = new System.Drawing.Point(0, 0);
            this.pnlJournal.Name = "pnlJournal";
            this.pnlJournal.Padding = new System.Windows.Forms.Padding(10);
            this.pnlJournal.Size = new System.Drawing.Size(500, 100);

            // picIcone (étoile décorative)
            this.picIcone.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.picIcone.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.picIcone.Location = new System.Drawing.Point(10, 10);
            this.picIcone.Name = "picIcone";
            this.picIcone.Size = new System.Drawing.Size(30, 30);
            this.picIcone.Text = "📋";
            this.picIcone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // lblDate
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(150, 200, 255);
            this.lblDate.Location = new System.Drawing.Point(45, 15);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(120, 20);
            this.lblDate.Text = "Date";

            // txtCommentaire
            this.txtCommentaire.BackColor = System.Drawing.Color.FromArgb(20, 30, 50);
            this.txtCommentaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCommentaire.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtCommentaire.ForeColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.txtCommentaire.Location = new System.Drawing.Point(45, 38);
            this.txtCommentaire.Name = "txtCommentaire";
            this.txtCommentaire.ReadOnly = true;
            this.txtCommentaire.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtCommentaire.Size = new System.Drawing.Size(445, 55);
            this.txtCommentaire.TabIndex = 1;

            // UCJournal
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlJournal);
            this.Name = "UCJournal";
            this.Size = new System.Drawing.Size(500, 100);
            this.pnlJournal.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        public System.Windows.Forms.Panel pnlJournal;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.RichTextBox txtCommentaire;
        public System.Windows.Forms.Label picIcone;
    }
}
