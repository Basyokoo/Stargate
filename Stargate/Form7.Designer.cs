namespace Stargate
{
    partial class Form7
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
            // ── Sidebar ──────────────────────────────────────────────────────
            this.pnlSidebar       = new System.Windows.Forms.Panel();
            this.lblSidebarTitre  = new System.Windows.Forms.Label();
            this.pnlSidebarSep    = new System.Windows.Forms.Panel();
            // ── Zone principale ───────────────────────────────────────────────
            this.lblTitre     = new System.Windows.Forms.Label();
            this.tabControl1  = new System.Windows.Forms.TabControl();
            this.tabPage1     = new System.Windows.Forms.TabPage();
            this.dgvReq1      = new System.Windows.Forms.DataGridView();
            this.lblResultatReq1 = new System.Windows.Forms.Label();
            this.btnRechercherMembre = new System.Windows.Forms.Button();
            this.cmbMembre    = new System.Windows.Forms.ComboBox();
            this.lblReq1      = new System.Windows.Forms.Label();
            this.tabPage2     = new System.Windows.Forms.TabPage();
            this.dgvReq2      = new System.Windows.Forms.DataGridView();
            this.lblResultatReq2 = new System.Windows.Forms.Label();
            this.btnReq2      = new System.Windows.Forms.Button();
            this.lblReq2      = new System.Windows.Forms.Label();
            this.tabPage3     = new System.Windows.Forms.TabPage();
            this.dgvReq3      = new System.Windows.Forms.DataGridView();
            this.lblResultatReq3 = new System.Windows.Forms.Label();
            this.btnReq3      = new System.Windows.Forms.Button();
            this.lblReq3      = new System.Windows.Forms.Label();
            this.tabPage4     = new System.Windows.Forms.TabPage();
            this.dgvReq4      = new System.Windows.Forms.DataGridView();
            this.lblResultatReq4 = new System.Windows.Forms.Label();
            this.btnReq4      = new System.Windows.Forms.Button();
            this.lblReq4      = new System.Windows.Forms.Label();
            this.tabPage5     = new System.Windows.Forms.TabPage();
            this.dgvReq5      = new System.Windows.Forms.DataGridView();
            this.lblResultatReq5 = new System.Windows.Forms.Label();
            this.btnRechercherMission = new System.Windows.Forms.Button();
            this.cmbMission   = new System.Windows.Forms.ComboBox();
            this.lblReq5      = new System.Windows.Forms.Label();

            this.pnlSidebar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq5)).BeginInit();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════
            // pnlSidebar
            // ════════════════════════════════════════════════════════════════
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.pnlSidebar.Controls.Add(this.lblSidebarTitre);
            this.pnlSidebar.Controls.Add(this.pnlSidebarSep);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Width = 395;

            this.lblSidebarTitre.AutoSize = false;
            this.lblSidebarTitre.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitre.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblSidebarTitre.Location = new System.Drawing.Point(8, 12);
            this.lblSidebarTitre.Size = new System.Drawing.Size(379, 82);
            this.lblSidebarTitre.Text = "✦ STARGATE ✦";
            this.lblSidebarTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.pnlSidebarSep.BackColor = System.Drawing.Color.FromArgb(40, 80, 160);
            this.pnlSidebarSep.Location = new System.Drawing.Point(12, 102);
            this.pnlSidebarSep.Size = new System.Drawing.Size(371, 2);

            // ════════════════════════════════════════════════════════════════
            // lblTitre — en-tête du volet 7
            // ════════════════════════════════════════════════════════════════
            this.lblTitre.BackColor = System.Drawing.Color.FromArgb(15, 15, 30);
            this.lblTitre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitre.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitre.ForeColor = System.Drawing.Color.FromArgb(120, 200, 255);
            this.lblTitre.Location = new System.Drawing.Point(0, 0);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(1509, 56);
            this.lblTitre.Text = "⭐  Volet 7 — Données Statistiques";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // ════════════════════════════════════════════════════════════════
            // tabControl1 — onglets des 5 requêtes statistiques
            // ════════════════════════════════════════════════════════════════
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.tabControl1.Location = new System.Drawing.Point(0, 56);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1509, 985);
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);

            System.Drawing.Color tabBg    = System.Drawing.Color.FromArgb(15, 20, 38);
            System.Drawing.Color tabFg    = System.Drawing.Color.FromArgb(230, 235, 255);
            System.Drawing.Color tabAcc   = System.Drawing.Color.FromArgb(120, 200, 255);
            System.Drawing.Color gridBg   = System.Drawing.Color.FromArgb(15, 20, 38);
            System.Drawing.Color gridLine = System.Drawing.Color.FromArgb(50, 50, 80);

            // ── Méthode locale pour styler un onglet ─────────────────────
            void StylerOnglet(System.Windows.Forms.TabPage tab, System.Windows.Forms.DataGridView dgv,
                System.Windows.Forms.Label lblReq, System.Windows.Forms.Label lblRes,
                System.Windows.Forms.Button btn)
            {
                tab.BackColor = tabBg;
                dgv.AllowUserToAddRows = false;
                dgv.BackgroundColor = gridBg;
                dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
                dgv.GridColor = gridLine;
                dgv.Location = new System.Drawing.Point(12, 110);
                dgv.ReadOnly = true;
                dgv.RowHeadersVisible = false;
                dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
                dgv.Size = new System.Drawing.Size(1100, 400);
                lblReq.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Italic);
                lblReq.ForeColor = System.Drawing.Color.FromArgb(180, 180, 220);
                lblReq.Location = new System.Drawing.Point(12, 12);
                lblReq.Size = new System.Drawing.Size(1100, 50);
                lblRes.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
                lblRes.ForeColor = tabAcc;
                lblRes.Location = new System.Drawing.Point(12, 518);
                lblRes.Size = new System.Drawing.Size(600, 28);
                btn.BackColor = System.Drawing.Color.FromArgb(30, 80, 140);
                btn.Cursor = System.Windows.Forms.Cursors.Hand;
                btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(60, 120, 200);
                btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
                btn.ForeColor = System.Drawing.Color.White;
                btn.Size = new System.Drawing.Size(290, 42);
                btn.UseVisualStyleBackColor = false;
            }

            // ── Onglet 1 ──────────────────────────────────────────────────
            this.tabPage1.Controls.Add(this.dgvReq1);
            this.tabPage1.Controls.Add(this.lblResultatReq1);
            this.tabPage1.Controls.Add(this.btnRechercherMembre);
            this.tabPage1.Controls.Add(this.cmbMembre);
            this.tabPage1.Controls.Add(this.lblReq1);
            this.tabPage1.Name = "tabPage1"; this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1 — Co-équipiers";

            StylerOnglet(tabPage1, dgvReq1, lblReq1, lblResultatReq1, btnRechercherMembre);
            this.lblReq1.Text = "Liste des personnes (nom, prénom, type) avec qui un membre a déjà partagé une mission :";
            this.cmbMembre.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.cmbMembre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMembre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMembre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbMembre.ForeColor = tabFg;
            this.cmbMembre.Location = new System.Drawing.Point(12, 68);
            this.cmbMembre.Size = new System.Drawing.Size(380, 34);
            this.btnRechercherMembre.Location = new System.Drawing.Point(408, 68);
            this.btnRechercherMembre.Text = "🔍  Rechercher";
            this.btnRechercherMembre.Click += new System.EventHandler(this.btnRechercherMembre_Click);

            // ── Onglet 2 ──────────────────────────────────────────────────
            this.tabPage2.Controls.Add(this.dgvReq2);
            this.tabPage2.Controls.Add(this.lblResultatReq2);
            this.tabPage2.Controls.Add(this.btnReq2);
            this.tabPage2.Controls.Add(this.lblReq2);
            this.tabPage2.Name = "tabPage2"; this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "2 — Missions > 10 membres";

            StylerOnglet(tabPage2, dgvReq2, lblReq2, lblResultatReq2, btnReq2);
            this.lblReq2.Text = "Pour les missions avec équipage > 10 personnes : dépenses effectuées, budgets initiaux et actuels.";
            this.btnReq2.Location = new System.Drawing.Point(12, 68);
            this.btnReq2.Text = "📊  Afficher les résultats";
            this.btnReq2.Click += new System.EventHandler(this.btnReq2_Click);

            // ── Onglet 3 ──────────────────────────────────────────────────
            this.tabPage3.Controls.Add(this.dgvReq3);
            this.tabPage3.Controls.Add(this.lblResultatReq3);
            this.tabPage3.Controls.Add(this.btnReq3);
            this.tabPage3.Controls.Add(this.lblReq3);
            this.tabPage3.Name = "tabPage3"; this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "3 — Missions / planète";

            StylerOnglet(tabPage3, dgvReq3, lblReq3, lblResultatReq3, btnReq3);
            this.lblReq3.Text = "Pour chaque planète, nombre de missions effectuées (les planètes sans mission apparaissent aussi).";
            this.btnReq3.Location = new System.Drawing.Point(12, 68);
            this.btnReq3.Text = "🌍  Afficher les résultats";
            this.btnReq3.Click += new System.EventHandler(this.btnReq3_Click);

            // ── Onglet 4 ──────────────────────────────────────────────────
            this.tabPage4.Controls.Add(this.dgvReq4);
            this.tabPage4.Controls.Add(this.lblResultatReq4);
            this.tabPage4.Controls.Add(this.btnReq4);
            this.tabPage4.Controls.Add(this.lblReq4);
            this.tabPage4.Name = "tabPage4"; this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "4 — Dépenses max";

            StylerOnglet(tabPage4, dgvReq4, lblReq4, lblResultatReq4, btnReq4);
            this.lblReq4.Text = "Dépenses les plus élevées de chaque mission (date, motif, montant), nom de la mission et chef.";
            this.btnReq4.Location = new System.Drawing.Point(12, 68);
            this.btnReq4.Text = "💰  Afficher les résultats";
            this.btnReq4.Click += new System.EventHandler(this.btnReq4_Click);

            // ── Onglet 5 ──────────────────────────────────────────────────
            this.tabPage5.Controls.Add(this.dgvReq5);
            this.tabPage5.Controls.Add(this.lblResultatReq5);
            this.tabPage5.Controls.Add(this.btnRechercherMission);
            this.tabPage5.Controls.Add(this.cmbMission);
            this.tabPage5.Controls.Add(this.lblReq5);
            this.tabPage5.Name = "tabPage5"; this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "5 — Informateurs moins payés";

            StylerOnglet(tabPage5, dgvReq5, lblReq5, lblResultatReq5, btnRechercherMission);
            this.lblReq5.Text = "Informateurs (nom de code, espèce, somme totale) ayant perçu le moins pendant une mission donnée :";
            this.cmbMission.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.cmbMission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMission.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbMission.ForeColor = tabFg;
            this.cmbMission.Location = new System.Drawing.Point(12, 68);
            this.cmbMission.Size = new System.Drawing.Size(380, 34);
            this.btnRechercherMission.Location = new System.Drawing.Point(408, 68);
            this.btnRechercherMission.Text = "🔍  Rechercher";
            this.btnRechercherMission.Click += new System.EventHandler(this.btnRechercherMission_Click);

            // ════════════════════════════════════════════════════════════════
            // Form7 — volet 7 : données statistiques
            // ════════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.pnlSidebar);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "Form7";
            this.Text = "Stargate — Volet 7 : Statistiques";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReq5)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        // ── Sidebar ──────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarTitre;
        private System.Windows.Forms.Panel pnlSidebarSep;
        // ── En-tête ───────────────────────────────────────────────────────────
        private System.Windows.Forms.Label lblTitre;
        // ── Onglets ───────────────────────────────────────────────────────────
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblReq1;
        private System.Windows.Forms.ComboBox cmbMembre;
        private System.Windows.Forms.Button btnRechercherMembre;
        private System.Windows.Forms.DataGridView dgvReq1;
        private System.Windows.Forms.Label lblResultatReq1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblReq2;
        private System.Windows.Forms.Button btnReq2;
        private System.Windows.Forms.DataGridView dgvReq2;
        private System.Windows.Forms.Label lblResultatReq2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblReq3;
        private System.Windows.Forms.Button btnReq3;
        private System.Windows.Forms.DataGridView dgvReq3;
        private System.Windows.Forms.Label lblResultatReq3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblReq4;
        private System.Windows.Forms.Button btnReq4;
        private System.Windows.Forms.DataGridView dgvReq4;
        private System.Windows.Forms.Label lblResultatReq4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Label lblReq5;
        private System.Windows.Forms.ComboBox cmbMission;
        private System.Windows.Forms.Button btnRechercherMission;
        private System.Windows.Forms.DataGridView dgvReq5;
        private System.Windows.Forms.Label lblResultatReq5;
    }
}
