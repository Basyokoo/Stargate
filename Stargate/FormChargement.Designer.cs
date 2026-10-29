namespace Stargate
{
    partial class FormChargement
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlContenu = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblSousTitre = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.pnlContenu.SuspendLayout();
            this.SuspendLayout();
            //
            // pnlContenu — carte centrale avec bordure bleue
            //
            this.pnlContenu.BackColor = System.Drawing.Color.FromArgb(18, 28, 52);
            this.pnlContenu.Controls.Add(this.lblMessage);
            this.pnlContenu.Controls.Add(this.lblSousTitre);
            this.pnlContenu.Controls.Add(this.progressBar);
            this.pnlContenu.Location = new System.Drawing.Point(15, 15);
            this.pnlContenu.Name = "pnlContenu";
            this.pnlContenu.Size = new System.Drawing.Size(370, 120);
            //
            // lblMessage — titre de l'opération en cours
            //
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblMessage.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblMessage.Location = new System.Drawing.Point(10, 15);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(350, 28);
            this.lblMessage.Text = "⏳  Chargement en cours";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblSousTitre — texte secondaire d'attente
            //
            this.lblSousTitre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.lblSousTitre.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblSousTitre.Location = new System.Drawing.Point(10, 50);
            this.lblSousTitre.Name = "lblSousTitre";
            this.lblSousTitre.Size = new System.Drawing.Size(350, 24);
            this.lblSousTitre.Text = "Veuillez patienter...";
            this.lblSousTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // progressBar — barre de progression en mode défilant
            //
            this.progressBar.Location = new System.Drawing.Point(20, 84);
            this.progressBar.MarqueeAnimationSpeed = 25;
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(330, 16);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            //
            // FormChargement — fenêtre de chargement sans contrôle de fermeture
            //
            this.BackColor = System.Drawing.Color.FromArgb(8, 12, 25);
            this.ClientSize = new System.Drawing.Size(400, 150);
            this.ControlBox = false;
            this.Controls.Add(this.pnlContenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChargement";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Chargement...";
            this.pnlContenu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlContenu;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblSousTitre;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}
