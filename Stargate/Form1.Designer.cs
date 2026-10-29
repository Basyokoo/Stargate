namespace Stargate
{
    partial class Volet1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        private void InitializeComponent()
        {
            this.flpVolet1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblTitreApp = new System.Windows.Forms.Label();
            this.pnlSep = new System.Windows.Forms.Panel();
            this.pnlFiltres = new System.Windows.Forms.Panel();
            this.lblFiltreLabel = new System.Windows.Forms.Label();
            this.btnFiltreToutes = new System.Windows.Forms.Button();
            this.btnFiltreEnCours = new System.Windows.Forms.Button();
            this.btnFiltreAVenir = new System.Windows.Forms.Button();
            this.btnFiltreTermine = new System.Windows.Forms.Button();
            this.pnlFiltres.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            //
            // flpVolet1 — conteneur scrollable des cartes missions
            //
            this.flpVolet1.AutoScroll = true;
            this.flpVolet1.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.flpVolet1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpVolet1.Location = new System.Drawing.Point(401, 68);
            this.flpVolet1.Name = "flpVolet1";
            this.flpVolet1.Size = new System.Drawing.Size(1491, 961);
            this.flpVolet1.TabIndex = 0;
            this.flpVolet1.WrapContents = false;
            //
            // pnlSidebar — panneau latéral gauche de navigation
            //
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.pnlSidebar.Controls.Add(this.lblTitreApp);
            this.pnlSidebar.Controls.Add(this.pnlSep);
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(395, 1041);
            this.pnlSidebar.TabIndex = 4;
            //
            // lblTitreApp — titre "STARGATE" dans la sidebar
            //
            this.lblTitreApp.AutoSize = false;
            this.lblTitreApp.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblTitreApp.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblTitreApp.Location = new System.Drawing.Point(8, 12);
            this.lblTitreApp.Name = "lblTitreApp";
            this.lblTitreApp.Size = new System.Drawing.Size(379, 82);
            this.lblTitreApp.Text = "✦ STARGATE ✦";
            this.lblTitreApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlSep — séparateur horizontal sous le titre
            //
            this.pnlSep.BackColor = System.Drawing.Color.FromArgb(40, 80, 160);
            this.pnlSep.Location = new System.Drawing.Point(12, 102);
            this.pnlSep.Name = "pnlSep";
            this.pnlSep.Size = new System.Drawing.Size(371, 2);
            //
            // pnlFiltres — barre de filtres des missions au-dessus du tableau de bord
            //
            this.pnlFiltres.BackColor = System.Drawing.Color.FromArgb(18, 25, 45);
            this.pnlFiltres.Controls.Add(this.lblFiltreLabel);
            this.pnlFiltres.Controls.Add(this.btnFiltreToutes);
            this.pnlFiltres.Controls.Add(this.btnFiltreEnCours);
            this.pnlFiltres.Controls.Add(this.btnFiltreAVenir);
            this.pnlFiltres.Controls.Add(this.btnFiltreTermine);
            this.pnlFiltres.Location = new System.Drawing.Point(401, 10);
            this.pnlFiltres.Name = "pnlFiltres";
            this.pnlFiltres.Size = new System.Drawing.Size(1491, 52);
            //
            // lblFiltreLabel — libellé "Filtrer :"
            //
            this.lblFiltreLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblFiltreLabel.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblFiltreLabel.Location = new System.Drawing.Point(10, 12);
            this.lblFiltreLabel.Size = new System.Drawing.Size(100, 28);
            this.lblFiltreLabel.Text = "Filtrer :";
            this.lblFiltreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // btnFiltreToutes — afficher toutes les missions
            //
            this.btnFiltreToutes.BackColor = System.Drawing.Color.FromArgb(50, 80, 150);
            this.btnFiltreToutes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltreToutes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltreToutes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnFiltreToutes.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnFiltreToutes.Location = new System.Drawing.Point(120, 8);
            this.btnFiltreToutes.Name = "btnFiltreToutes";
            this.btnFiltreToutes.Size = new System.Drawing.Size(150, 36);
            this.btnFiltreToutes.Text = "Toutes";
            this.btnFiltreToutes.Click += new System.EventHandler(this.btnFiltreToutes_Click);
            //
            // btnFiltreEnCours — missions en cours seulement
            //
            this.btnFiltreEnCours.BackColor = System.Drawing.Color.FromArgb(18, 40, 80);
            this.btnFiltreEnCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltreEnCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltreEnCours.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnFiltreEnCours.ForeColor = System.Drawing.Color.FromArgb(100, 200, 255);
            this.btnFiltreEnCours.Location = new System.Drawing.Point(286, 8);
            this.btnFiltreEnCours.Name = "btnFiltreEnCours";
            this.btnFiltreEnCours.Size = new System.Drawing.Size(150, 36);
            this.btnFiltreEnCours.Text = "▶ En cours";
            this.btnFiltreEnCours.Click += new System.EventHandler(this.btnFiltreEnCours_Click);
            //
            // btnFiltreAVenir — missions à venir seulement
            //
            this.btnFiltreAVenir.BackColor = System.Drawing.Color.FromArgb(60, 48, 12);
            this.btnFiltreAVenir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltreAVenir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltreAVenir.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnFiltreAVenir.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.btnFiltreAVenir.Location = new System.Drawing.Point(452, 8);
            this.btnFiltreAVenir.Name = "btnFiltreAVenir";
            this.btnFiltreAVenir.Size = new System.Drawing.Size(150, 36);
            this.btnFiltreAVenir.Text = "⏳ À venir";
            this.btnFiltreAVenir.Click += new System.EventHandler(this.btnFiltreAVenir_Click);
            //
            // btnFiltreTermine — missions terminées seulement
            //
            this.btnFiltreTermine.BackColor = System.Drawing.Color.FromArgb(15, 40, 25);
            this.btnFiltreTermine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltreTermine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltreTermine.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnFiltreTermine.ForeColor = System.Drawing.Color.FromArgb(80, 200, 130);
            this.btnFiltreTermine.Location = new System.Drawing.Point(618, 8);
            this.btnFiltreTermine.Name = "btnFiltreTermine";
            this.btnFiltreTermine.Size = new System.Drawing.Size(150, 36);
            this.btnFiltreTermine.Text = "✔ Terminé";
            this.btnFiltreTermine.Click += new System.EventHandler(this.btnFiltreTermine_Click);
            //
            // Volet1 — tableau de bord principal
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlFiltres);
            this.Controls.Add(this.flpVolet1);
            this.Controls.Add(this.pnlSidebar);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Volet1";
            this.Text = "Stargate — Tableau de bord";
            this.Load += new System.EventHandler(this.Volet1_Load);
            this.pnlFiltres.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpVolet1;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblTitreApp;
        private System.Windows.Forms.Panel pnlSep;
        private System.Windows.Forms.Panel pnlFiltres;
        private System.Windows.Forms.Label lblFiltreLabel;
        private System.Windows.Forms.Button btnFiltreToutes;
        private System.Windows.Forms.Button btnFiltreEnCours;
        private System.Windows.Forms.Button btnFiltreAVenir;
        private System.Windows.Forms.Button btnFiltreTermine;
    }
}
