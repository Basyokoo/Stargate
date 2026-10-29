namespace Stargate
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            // ── Sidebar ──────────────────────────────────────────────────────────
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarTitre = new System.Windows.Forms.Label();
            this.pnlSidebarSep = new System.Windows.Forms.Panel();
            // ── Contenu principal ────────────────────────────────────────────────
            this.pnlContenu = new System.Windows.Forms.Panel();
            this.lblTitreVolet = new System.Windows.Forms.Label();
            this.lblChoixPlanete = new System.Windows.Forms.Label();
            this.cboChoixPlanete = new System.Windows.Forms.ComboBox();
            this.btnChoixPlanete = new System.Windows.Forms.Button();
            this.lblNomMission = new System.Windows.Forms.Label();
            // ── Étape 2 : paramètres ─────────────────────────────────────────────
            this.grpInfosMission = new System.Windows.Forms.GroupBox();
            this.lblParametreMission = new System.Windows.Forms.Label();
            this.lblDateDepart = new System.Windows.Forms.Label();
            this.dateTimePickerDateDepart = new System.Windows.Forms.DateTimePicker();
            this.lblDateRetourPrevu = new System.Windows.Forms.Label();
            this.dateTimePickerDateRetourPrevu = new System.Windows.Forms.DateTimePicker();
            this.lblFeuilleRoute = new System.Windows.Forms.Label();
            this.txtFeuilleRoute = new System.Windows.Forms.TextBox();
            this.lblObjData = new System.Windows.Forms.Label();
            this.txtObjData = new System.Windows.Forms.TextBox();
            this.lblTonnes = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.lblEuro = new System.Windows.Forms.Label();
            this.btnValiderInfos = new System.Windows.Forms.Button();
            // ── Étape 3 : chef & membres ─────────────────────────────────────────
            this.grpChoixChef = new System.Windows.Forms.GroupBox();
            this.lblChoixChef = new System.Windows.Forms.Label();
            this.lblChef = new System.Windows.Forms.Label();
            this.cboChoixChef = new System.Windows.Forms.ComboBox();
            this.lblNbMembres = new System.Windows.Forms.Label();
            this.txtNbMembres = new System.Windows.Forms.TextBox();
            this.lblPersonnes = new System.Windows.Forms.Label();
            this.btnValiderChef = new System.Windows.Forms.Button();
            // ── Étape 4 : affectation membres ────────────────────────────────────
            this.grpChoixMembres = new System.Windows.Forms.GroupBox();
            this.lblAffectationMembre = new System.Windows.Forms.Label();
            this.cboAffecterMembre = new System.Windows.Forms.ComboBox();
            this.btnValiderMembre = new System.Windows.Forms.Button();
            this.lboListeMembre = new System.Windows.Forms.ListBox();
            this.btnSupprimerMembre = new System.Windows.Forms.Button();
            this.btnValiderMembreMission = new System.Windows.Forms.Button();
            // ── Étape 5 : objectifs captures ─────────────────────────────────────
            this.grpObjCaptures = new System.Windows.Forms.GroupBox();
            this.lblObj = new System.Windows.Forms.Label();
            this.cboObj = new System.Windows.Forms.ComboBox();
            this.txtQuantiteObj = new System.Windows.Forms.TextBox();
            this.btnValiderObj = new System.Windows.Forms.Button();
            this.lboListeObj = new System.Windows.Forms.ListBox();
            this.btnSupprimerObj = new System.Windows.Forms.Button();
            this.btnValiderObjMission = new System.Windows.Forms.Button();
            // ── Validation finale ─────────────────────────────────────────────────
            this.grpBoutonFinal = new System.Windows.Forms.GroupBox();
            this.btnValiderMission = new System.Windows.Forms.Button();

            this.pnlSidebar.SuspendLayout();
            this.pnlContenu.SuspendLayout();
            this.grpInfosMission.SuspendLayout();
            this.grpChoixChef.SuspendLayout();
            this.grpChoixMembres.SuspendLayout();
            this.grpObjCaptures.SuspendLayout();
            this.grpBoutonFinal.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════════
            // pnlSidebar — barre de navigation latérale gauche
            // ════════════════════════════════════════════════════════════════════
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

            // ════════════════════════════════════════════════════════════════════
            // pnlContenu — zone de saisie de la nouvelle mission
            // ════════════════════════════════════════════════════════════════════
            this.pnlContenu.AutoScroll = true;
            this.pnlContenu.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.pnlContenu.Controls.Add(this.grpBoutonFinal);
            this.pnlContenu.Controls.Add(this.grpObjCaptures);
            this.pnlContenu.Controls.Add(this.grpChoixMembres);
            this.pnlContenu.Controls.Add(this.grpInfosMission);
            this.pnlContenu.Controls.Add(this.grpChoixChef);
            this.pnlContenu.Controls.Add(this.lblNomMission);
            this.pnlContenu.Controls.Add(this.btnChoixPlanete);
            this.pnlContenu.Controls.Add(this.cboChoixPlanete);
            this.pnlContenu.Controls.Add(this.lblChoixPlanete);
            this.pnlContenu.Controls.Add(this.lblTitreVolet);
            this.pnlContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenu.Padding = new System.Windows.Forms.Padding(20);
            this.pnlContenu.Name = "pnlContenu";

            // ── Titre du volet ────────────────────────────────────────────────
            this.lblTitreVolet.AutoSize = false;
            this.lblTitreVolet.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitreVolet.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblTitreVolet.Location = new System.Drawing.Point(20, 15);
            this.lblTitreVolet.Size = new System.Drawing.Size(800, 44);
            this.lblTitreVolet.Text = "🚀  Volet 2 — Création d'une mission";

            // ── Étape 1 : planète ─────────────────────────────────────────────
            this.lblChoixPlanete.AutoSize = false;
            this.lblChoixPlanete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblChoixPlanete.ForeColor = System.Drawing.Color.FromArgb(50, 130, 255);
            this.lblChoixPlanete.Location = new System.Drawing.Point(20, 70);
            this.lblChoixPlanete.Size = new System.Drawing.Size(280, 28);
            this.lblChoixPlanete.Text = "1 — Choix de la planète";

            this.cboChoixPlanete.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.cboChoixPlanete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboChoixPlanete.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboChoixPlanete.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.cboChoixPlanete.FormattingEnabled = true;
            this.cboChoixPlanete.Location = new System.Drawing.Point(310, 66);
            this.cboChoixPlanete.Name = "cboChoixPlanete";
            this.cboChoixPlanete.Size = new System.Drawing.Size(300, 34);

            this.btnChoixPlanete.BackColor = System.Drawing.Color.FromArgb(25, 65, 140);
            this.btnChoixPlanete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoixPlanete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoixPlanete.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnChoixPlanete.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnChoixPlanete.Location = new System.Drawing.Point(626, 62);
            this.btnChoixPlanete.Name = "btnChoixPlanete";
            this.btnChoixPlanete.Size = new System.Drawing.Size(160, 38);
            this.btnChoixPlanete.Text = "✔ Valider";
            this.btnChoixPlanete.UseVisualStyleBackColor = false;
            this.btnChoixPlanete.Click += new System.EventHandler(this.btnChoixPlanete_Click_1);

            this.lblNomMission.AutoSize = false;
            this.lblNomMission.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblNomMission.ForeColor = System.Drawing.Color.FromArgb(255, 200, 50);
            this.lblNomMission.Location = new System.Drawing.Point(20, 110);
            this.lblNomMission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomMission.Name = "lblNomMission";
            this.lblNomMission.Size = new System.Drawing.Size(700, 36);
            this.lblNomMission.Text = "Nom de la mission :";

            // ════════════════════════════════════════════════════════════════════
            // grpInfosMission — étape 2 : paramètres
            // ════════════════════════════════════════════════════════════════════
            this.grpInfosMission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInfosMission.BackColor = System.Drawing.Color.FromArgb(15, 20, 40);
            this.grpInfosMission.Controls.Add(this.lblParametreMission);
            this.grpInfosMission.Controls.Add(this.dateTimePickerDateDepart);
            this.grpInfosMission.Controls.Add(this.dateTimePickerDateRetourPrevu);
            this.grpInfosMission.Controls.Add(this.lblDateDepart);
            this.grpInfosMission.Controls.Add(this.btnValiderInfos);
            this.grpInfosMission.Controls.Add(this.lblDateRetourPrevu);
            this.grpInfosMission.Controls.Add(this.lblFeuilleRoute);
            this.grpInfosMission.Controls.Add(this.txtFeuilleRoute);
            this.grpInfosMission.Controls.Add(this.lblEuro);
            this.grpInfosMission.Controls.Add(this.txtBudget);
            this.grpInfosMission.Controls.Add(this.lblBudget);
            this.grpInfosMission.Controls.Add(this.lblTonnes);
            this.grpInfosMission.Controls.Add(this.txtObjData);
            this.grpInfosMission.Controls.Add(this.lblObjData);
            this.grpInfosMission.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.grpInfosMission.ForeColor = System.Drawing.Color.FromArgb(50, 130, 255);
            this.grpInfosMission.Location = new System.Drawing.Point(20, 156);
            this.grpInfosMission.Margin = new System.Windows.Forms.Padding(2);
            this.grpInfosMission.Name = "grpInfosMission";
            this.grpInfosMission.Padding = new System.Windows.Forms.Padding(10);
            this.grpInfosMission.Size = new System.Drawing.Size(1460, 290);
            this.grpInfosMission.TabStop = false;
            this.grpInfosMission.Text = "2 — Paramètres de la mission";
            this.grpInfosMission.Visible = false;

            this.lblParametreMission.AutoSize = false;
            this.lblParametreMission.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblParametreMission.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblParametreMission.Location = new System.Drawing.Point(12, 30);
            this.lblParametreMission.Size = new System.Drawing.Size(400, 28);
            this.lblParametreMission.Text = "Remplissez les informations :";
            this.lblParametreMission.Click += new System.EventHandler(this.lblParametreMission_Click);

            this.lblDateDepart.AutoSize = false;
            this.lblDateDepart.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDateDepart.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblDateDepart.Location = new System.Drawing.Point(22, 70);
            this.lblDateDepart.Size = new System.Drawing.Size(160, 28);
            this.lblDateDepart.Text = "Date de départ";
            this.lblDateDepart.Click += new System.EventHandler(this.lblDateDepart_Click);

            this.dateTimePickerDateDepart.CalendarMonthBackground = System.Drawing.Color.FromArgb(22, 32, 55);
            this.dateTimePickerDateDepart.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dateTimePickerDateDepart.Location = new System.Drawing.Point(200, 65);
            this.dateTimePickerDateDepart.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDateDepart.Name = "dateTimePickerDateDepart";
            this.dateTimePickerDateDepart.Size = new System.Drawing.Size(220, 34);
            this.dateTimePickerDateDepart.ValueChanged += new System.EventHandler(this.dateTimePickerDateDepart_ValueChanged);

            this.lblDateRetourPrevu.AutoSize = false;
            this.lblDateRetourPrevu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblDateRetourPrevu.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblDateRetourPrevu.Location = new System.Drawing.Point(22, 106);
            this.lblDateRetourPrevu.Size = new System.Drawing.Size(170, 28);
            this.lblDateRetourPrevu.Text = "Retour prévu";
            this.lblDateRetourPrevu.Click += new System.EventHandler(this.lblDateRetourPrevu_Click);

            this.dateTimePickerDateRetourPrevu.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.dateTimePickerDateRetourPrevu.Location = new System.Drawing.Point(200, 101);
            this.dateTimePickerDateRetourPrevu.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerDateRetourPrevu.Name = "dateTimePickerDateRetourPrevu";
            this.dateTimePickerDateRetourPrevu.Size = new System.Drawing.Size(220, 34);
            this.dateTimePickerDateRetourPrevu.ValueChanged += new System.EventHandler(this.dateTimePickerDateRetourPrevu_ValueChanged);

            this.lblFeuilleRoute.AutoSize = false;
            this.lblFeuilleRoute.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblFeuilleRoute.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblFeuilleRoute.Location = new System.Drawing.Point(22, 143);
            this.lblFeuilleRoute.Size = new System.Drawing.Size(160, 28);
            this.lblFeuilleRoute.Text = "Feuille de route";
            this.lblFeuilleRoute.Click += new System.EventHandler(this.lblFeuilleRoute_Click);

            this.txtFeuilleRoute.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.txtFeuilleRoute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFeuilleRoute.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtFeuilleRoute.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtFeuilleRoute.Location = new System.Drawing.Point(200, 140);
            this.txtFeuilleRoute.Margin = new System.Windows.Forms.Padding(2);
            this.txtFeuilleRoute.Multiline = true;
            this.txtFeuilleRoute.Name = "txtFeuilleRoute";
            this.txtFeuilleRoute.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFeuilleRoute.Size = new System.Drawing.Size(500, 90);
            this.txtFeuilleRoute.TextChanged += new System.EventHandler(this.txtFeuilleRoute_TextChanged);

            this.lblObjData.AutoSize = false;
            this.lblObjData.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblObjData.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblObjData.Location = new System.Drawing.Point(19, 241);
            this.lblObjData.Size = new System.Drawing.Size(170, 28);
            this.lblObjData.Text = "Objectif Databaz";
            this.lblObjData.Click += new System.EventHandler(this.lblObjData_Click);

            this.txtObjData.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.txtObjData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObjData.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtObjData.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtObjData.Location = new System.Drawing.Point(200, 237);
            this.txtObjData.Margin = new System.Windows.Forms.Padding(2);
            this.txtObjData.Name = "txtObjData";
            this.txtObjData.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtObjData.Size = new System.Drawing.Size(80, 34);
            this.txtObjData.TextChanged += new System.EventHandler(this.txtObjData_TextChanged);
            this.txtObjData.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtObjData_KeyPress);

            this.lblTonnes.AutoSize = false;
            this.lblTonnes.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblTonnes.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblTonnes.Location = new System.Drawing.Point(288, 241);
            this.lblTonnes.Size = new System.Drawing.Size(80, 28);
            this.lblTonnes.Text = "tonnes";
            this.lblTonnes.Click += new System.EventHandler(this.lblTonnes_Click);

            this.lblBudget.AutoSize = false;
            this.lblBudget.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblBudget.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblBudget.Location = new System.Drawing.Point(400, 241);
            this.lblBudget.Size = new System.Drawing.Size(90, 28);
            this.lblBudget.Text = "Budget";
            this.lblBudget.Click += new System.EventHandler(this.lblBudget_Click);

            this.txtBudget.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.txtBudget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBudget.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtBudget.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtBudget.Location = new System.Drawing.Point(500, 237);
            this.txtBudget.Margin = new System.Windows.Forms.Padding(2);
            this.txtBudget.Name = "txtBudget";
            this.txtBudget.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBudget.Size = new System.Drawing.Size(120, 34);
            this.txtBudget.TextChanged += new System.EventHandler(this.txtBudget_TextChanged);
            this.txtBudget.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBudget_KeyPress);

            this.lblEuro.AutoSize = false;
            this.lblEuro.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblEuro.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblEuro.Location = new System.Drawing.Point(626, 241);
            this.lblEuro.Size = new System.Drawing.Size(30, 28);
            this.lblEuro.Text = "€";
            this.lblEuro.Click += new System.EventHandler(this.lblEuro_Click);

            this.btnValiderInfos.BackColor = System.Drawing.Color.FromArgb(30, 80, 50);
            this.btnValiderInfos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderInfos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderInfos.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnValiderInfos.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnValiderInfos.Location = new System.Drawing.Point(700, 225);
            this.btnValiderInfos.Margin = new System.Windows.Forms.Padding(2);
            this.btnValiderInfos.Name = "btnValiderInfos";
            this.btnValiderInfos.Size = new System.Drawing.Size(220, 56);
            this.btnValiderInfos.Text = "✔ Valider les infos";
            this.btnValiderInfos.UseVisualStyleBackColor = false;
            this.btnValiderInfos.Click += new System.EventHandler(this.btnValiderInfos_Click);

            // ════════════════════════════════════════════════════════════════════
            // grpChoixChef — étape 3 : chef et nombre de membres
            // ════════════════════════════════════════════════════════════════════
            this.grpChoixChef.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChoixChef.BackColor = System.Drawing.Color.FromArgb(15, 20, 40);
            this.grpChoixChef.Controls.Add(this.lblChef);
            this.grpChoixChef.Controls.Add(this.btnValiderChef);
            this.grpChoixChef.Controls.Add(this.cboChoixChef);
            this.grpChoixChef.Controls.Add(this.lblChoixChef);
            this.grpChoixChef.Controls.Add(this.lblNbMembres);
            this.grpChoixChef.Controls.Add(this.txtNbMembres);
            this.grpChoixChef.Controls.Add(this.lblPersonnes);
            this.grpChoixChef.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.grpChoixChef.ForeColor = System.Drawing.Color.FromArgb(50, 130, 255);
            this.grpChoixChef.Location = new System.Drawing.Point(20, 456);
            this.grpChoixChef.Margin = new System.Windows.Forms.Padding(2);
            this.grpChoixChef.Name = "grpChoixChef";
            this.grpChoixChef.Padding = new System.Windows.Forms.Padding(10);
            this.grpChoixChef.Size = new System.Drawing.Size(1460, 120);
            this.grpChoixChef.TabStop = false;
            this.grpChoixChef.Text = "3 — Chef et membres";
            this.grpChoixChef.Visible = false;

            this.lblChoixChef.AutoSize = false;
            this.lblChoixChef.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblChoixChef.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblChoixChef.Location = new System.Drawing.Point(10, 30);
            this.lblChoixChef.Size = new System.Drawing.Size(400, 28);
            this.lblChoixChef.Text = "Choix du chef de mission";
            this.lblChoixChef.Click += new System.EventHandler(this.lblChoixChef_Click);

            this.lblChef.AutoSize = false;
            this.lblChef.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblChef.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblChef.Location = new System.Drawing.Point(20, 68);
            this.lblChef.Size = new System.Drawing.Size(60, 28);
            this.lblChef.Text = "Chef";

            this.cboChoixChef.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.cboChoixChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboChoixChef.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboChoixChef.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.cboChoixChef.FormattingEnabled = true;
            this.cboChoixChef.Location = new System.Drawing.Point(90, 64);
            this.cboChoixChef.Margin = new System.Windows.Forms.Padding(2);
            this.cboChoixChef.Name = "cboChoixChef";
            this.cboChoixChef.Size = new System.Drawing.Size(280, 34);
            this.cboChoixChef.SelectedIndexChanged += new System.EventHandler(this.cboChoixChef_SelectedIndexChanged_1);

            this.lblNbMembres.AutoSize = false;
            this.lblNbMembres.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblNbMembres.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblNbMembres.Location = new System.Drawing.Point(400, 68);
            this.lblNbMembres.Size = new System.Drawing.Size(200, 28);
            this.lblNbMembres.Text = "Nombre de membres";
            this.lblNbMembres.Click += new System.EventHandler(this.lblNbMembres_Click);

            this.txtNbMembres.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.txtNbMembres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNbMembres.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtNbMembres.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtNbMembres.Location = new System.Drawing.Point(610, 64);
            this.txtNbMembres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNbMembres.Name = "txtNbMembres";
            this.txtNbMembres.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtNbMembres.Size = new System.Drawing.Size(70, 34);
            this.txtNbMembres.TextChanged += new System.EventHandler(this.txtNbMembres_TextChanged);
            this.txtNbMembres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNbMembres_KeyPress);

            this.lblPersonnes.AutoSize = false;
            this.lblPersonnes.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblPersonnes.ForeColor = System.Drawing.Color.FromArgb(140, 155, 180);
            this.lblPersonnes.Location = new System.Drawing.Point(688, 68);
            this.lblPersonnes.Size = new System.Drawing.Size(100, 28);
            this.lblPersonnes.Text = "personnes";
            this.lblPersonnes.Click += new System.EventHandler(this.lblPersonnes_Click);

            this.btnValiderChef.BackColor = System.Drawing.Color.FromArgb(30, 80, 50);
            this.btnValiderChef.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderChef.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderChef.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnValiderChef.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnValiderChef.Location = new System.Drawing.Point(820, 54);
            this.btnValiderChef.Margin = new System.Windows.Forms.Padding(2);
            this.btnValiderChef.Name = "btnValiderChef";
            this.btnValiderChef.Size = new System.Drawing.Size(160, 44);
            this.btnValiderChef.Text = "✔ Valider";
            this.btnValiderChef.UseVisualStyleBackColor = false;
            this.btnValiderChef.Click += new System.EventHandler(this.btnValiderChef_Click);

            // ════════════════════════════════════════════════════════════════════
            // grpChoixMembres — étape 4 : affectation des membres
            // ════════════════════════════════════════════════════════════════════
            this.grpChoixMembres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpChoixMembres.BackColor = System.Drawing.Color.FromArgb(15, 20, 40);
            this.grpChoixMembres.Controls.Add(this.lblAffectationMembre);
            this.grpChoixMembres.Controls.Add(this.cboAffecterMembre);
            this.grpChoixMembres.Controls.Add(this.btnValiderMembre);
            this.grpChoixMembres.Controls.Add(this.lboListeMembre);
            this.grpChoixMembres.Controls.Add(this.btnSupprimerMembre);
            this.grpChoixMembres.Controls.Add(this.btnValiderMembreMission);
            this.grpChoixMembres.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.grpChoixMembres.ForeColor = System.Drawing.Color.FromArgb(50, 130, 255);
            this.grpChoixMembres.Location = new System.Drawing.Point(20, 586);
            this.grpChoixMembres.Margin = new System.Windows.Forms.Padding(2);
            this.grpChoixMembres.Name = "grpChoixMembres";
            this.grpChoixMembres.Padding = new System.Windows.Forms.Padding(10);
            this.grpChoixMembres.Size = new System.Drawing.Size(1460, 230);
            this.grpChoixMembres.TabStop = false;
            this.grpChoixMembres.Text = "4 — Affectation des membres";
            this.grpChoixMembres.Visible = false;

            this.lblAffectationMembre.AutoSize = false;
            this.lblAffectationMembre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblAffectationMembre.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblAffectationMembre.Location = new System.Drawing.Point(10, 30);
            this.lblAffectationMembre.Size = new System.Drawing.Size(600, 28);
            this.lblAffectationMembre.Text = "Membres à affecter — reste à affecter :";
            this.lblAffectationMembre.Click += new System.EventHandler(this.lblAffectationMembre_Click);

            this.cboAffecterMembre.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.cboAffecterMembre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboAffecterMembre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboAffecterMembre.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.cboAffecterMembre.FormattingEnabled = true;
            this.cboAffecterMembre.Location = new System.Drawing.Point(20, 66);
            this.cboAffecterMembre.Margin = new System.Windows.Forms.Padding(2);
            this.cboAffecterMembre.Name = "cboAffecterMembre";
            this.cboAffecterMembre.Size = new System.Drawing.Size(420, 34);
            this.cboAffecterMembre.SelectedIndexChanged += new System.EventHandler(this.cboAffecterMembre_SelectedIndexChanged);

            this.btnValiderMembre.BackColor = System.Drawing.Color.FromArgb(25, 65, 140);
            this.btnValiderMembre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderMembre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderMembre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnValiderMembre.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnValiderMembre.Location = new System.Drawing.Point(458, 60);
            this.btnValiderMembre.Margin = new System.Windows.Forms.Padding(2);
            this.btnValiderMembre.Name = "btnValiderMembre";
            this.btnValiderMembre.Size = new System.Drawing.Size(120, 42);
            this.btnValiderMembre.Text = "Ajouter";
            this.btnValiderMembre.UseVisualStyleBackColor = false;
            this.btnValiderMembre.Click += new System.EventHandler(this.btnValiderMembre_Click);

            this.lboListeMembre.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.lboListeMembre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboListeMembre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lboListeMembre.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lboListeMembre.FormattingEnabled = true;
            this.lboListeMembre.Location = new System.Drawing.Point(20, 112);
            this.lboListeMembre.Margin = new System.Windows.Forms.Padding(2);
            this.lboListeMembre.Name = "lboListeMembre";
            this.lboListeMembre.Size = new System.Drawing.Size(560, 95);
            this.lboListeMembre.SelectedIndexChanged += new System.EventHandler(this.lboListeMembre_SelectedIndexChanged);

            this.btnSupprimerMembre.BackColor = System.Drawing.Color.FromArgb(80, 30, 30);
            this.btnSupprimerMembre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerMembre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerMembre.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSupprimerMembre.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnSupprimerMembre.Location = new System.Drawing.Point(20, 186);
            this.btnSupprimerMembre.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimerMembre.Name = "btnSupprimerMembre";
            this.btnSupprimerMembre.Size = new System.Drawing.Size(160, 38);
            this.btnSupprimerMembre.Text = "✖ Supprimer";
            this.btnSupprimerMembre.UseVisualStyleBackColor = false;
            this.btnSupprimerMembre.Click += new System.EventHandler(this.btnSupprimerMembre_Click);

            this.btnValiderMembreMission.BackColor = System.Drawing.Color.FromArgb(30, 80, 50);
            this.btnValiderMembreMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderMembreMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderMembreMission.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnValiderMembreMission.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnValiderMembreMission.Location = new System.Drawing.Point(380, 186);
            this.btnValiderMembreMission.Margin = new System.Windows.Forms.Padding(2);
            this.btnValiderMembreMission.Name = "btnValiderMembreMission";
            this.btnValiderMembreMission.Size = new System.Drawing.Size(200, 38);
            this.btnValiderMembreMission.Text = "✔ Valider membres";
            this.btnValiderMembreMission.UseVisualStyleBackColor = false;
            this.btnValiderMembreMission.Click += new System.EventHandler(this.btnValiderMembreMission_Click);

            // ════════════════════════════════════════════════════════════════════
            // grpObjCaptures — étape 5 : objectifs de capture
            // ════════════════════════════════════════════════════════════════════
            this.grpObjCaptures.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpObjCaptures.BackColor = System.Drawing.Color.FromArgb(15, 20, 40);
            this.grpObjCaptures.Controls.Add(this.btnSupprimerObj);
            this.grpObjCaptures.Controls.Add(this.lboListeObj);
            this.grpObjCaptures.Controls.Add(this.btnValiderObjMission);
            this.grpObjCaptures.Controls.Add(this.btnValiderObj);
            this.grpObjCaptures.Controls.Add(this.txtQuantiteObj);
            this.grpObjCaptures.Controls.Add(this.lblObj);
            this.grpObjCaptures.Controls.Add(this.cboObj);
            this.grpObjCaptures.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.grpObjCaptures.ForeColor = System.Drawing.Color.FromArgb(50, 130, 255);
            this.grpObjCaptures.Location = new System.Drawing.Point(20, 826);
            this.grpObjCaptures.Margin = new System.Windows.Forms.Padding(2);
            this.grpObjCaptures.Name = "grpObjCaptures";
            this.grpObjCaptures.Padding = new System.Windows.Forms.Padding(10);
            this.grpObjCaptures.Size = new System.Drawing.Size(1460, 230);
            this.grpObjCaptures.TabStop = false;
            this.grpObjCaptures.Text = "5 — Objectifs de capture";
            this.grpObjCaptures.Visible = false;

            this.lblObj.AutoSize = false;
            this.lblObj.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblObj.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lblObj.Location = new System.Drawing.Point(10, 30);
            this.lblObj.Size = new System.Drawing.Size(300, 28);
            this.lblObj.Text = "Espèce à capturer";
            this.lblObj.Click += new System.EventHandler(this.lblObj_Click);

            this.cboObj.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.cboObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboObj.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboObj.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.cboObj.FormattingEnabled = true;
            this.cboObj.Location = new System.Drawing.Point(20, 64);
            this.cboObj.Margin = new System.Windows.Forms.Padding(2);
            this.cboObj.Name = "cboObj";
            this.cboObj.Size = new System.Drawing.Size(300, 34);
            this.cboObj.SelectedIndexChanged += new System.EventHandler(this.cboObj_SelectedIndexChanged);

            this.txtQuantiteObj.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.txtQuantiteObj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantiteObj.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtQuantiteObj.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.txtQuantiteObj.Location = new System.Drawing.Point(330, 64);
            this.txtQuantiteObj.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuantiteObj.Name = "txtQuantiteObj";
            this.txtQuantiteObj.Size = new System.Drawing.Size(60, 34);

            this.btnValiderObj.BackColor = System.Drawing.Color.FromArgb(25, 65, 140);
            this.btnValiderObj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderObj.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnValiderObj.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnValiderObj.Location = new System.Drawing.Point(406, 58);
            this.btnValiderObj.Margin = new System.Windows.Forms.Padding(2);
            this.btnValiderObj.Name = "btnValiderObj";
            this.btnValiderObj.Size = new System.Drawing.Size(120, 42);
            this.btnValiderObj.Text = "Ajouter";
            this.btnValiderObj.UseVisualStyleBackColor = false;
            this.btnValiderObj.Click += new System.EventHandler(this.btnValiderObj_Click);

            this.lboListeObj.BackColor = System.Drawing.Color.FromArgb(22, 32, 55);
            this.lboListeObj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lboListeObj.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lboListeObj.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.lboListeObj.FormattingEnabled = true;
            this.lboListeObj.Location = new System.Drawing.Point(20, 110);
            this.lboListeObj.Margin = new System.Windows.Forms.Padding(2);
            this.lboListeObj.Name = "lboListeObj";
            this.lboListeObj.Size = new System.Drawing.Size(560, 95);
            this.lboListeObj.SelectedIndexChanged += new System.EventHandler(this.lboListeObj_SelectedIndexChanged);

            this.btnSupprimerObj.BackColor = System.Drawing.Color.FromArgb(80, 30, 30);
            this.btnSupprimerObj.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSupprimerObj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSupprimerObj.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnSupprimerObj.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnSupprimerObj.Location = new System.Drawing.Point(20, 184);
            this.btnSupprimerObj.Margin = new System.Windows.Forms.Padding(2);
            this.btnSupprimerObj.Name = "btnSupprimerObj";
            this.btnSupprimerObj.Size = new System.Drawing.Size(160, 38);
            this.btnSupprimerObj.Text = "✖ Supprimer";
            this.btnSupprimerObj.UseVisualStyleBackColor = false;
            this.btnSupprimerObj.Click += new System.EventHandler(this.btnSupprimerObj_Click);

            this.btnValiderObjMission.BackColor = System.Drawing.Color.FromArgb(30, 80, 50);
            this.btnValiderObjMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderObjMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderObjMission.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnValiderObjMission.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnValiderObjMission.Location = new System.Drawing.Point(380, 184);
            this.btnValiderObjMission.Margin = new System.Windows.Forms.Padding(2);
            this.btnValiderObjMission.Name = "btnValiderObjMission";
            this.btnValiderObjMission.Size = new System.Drawing.Size(200, 38);
            this.btnValiderObjMission.Text = "✔ Valider objectifs";
            this.btnValiderObjMission.UseVisualStyleBackColor = false;
            this.btnValiderObjMission.Click += new System.EventHandler(this.btnValiderObjMission_Click);

            // ════════════════════════════════════════════════════════════════════
            // grpBoutonFinal — validation finale de la mission
            // ════════════════════════════════════════════════════════════════════
            this.grpBoutonFinal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoutonFinal.BackColor = System.Drawing.Color.FromArgb(15, 20, 40);
            this.grpBoutonFinal.Controls.Add(this.btnValiderMission);
            this.grpBoutonFinal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.grpBoutonFinal.ForeColor = System.Drawing.Color.FromArgb(80, 180, 120);
            this.grpBoutonFinal.Location = new System.Drawing.Point(20, 1066);
            this.grpBoutonFinal.Margin = new System.Windows.Forms.Padding(2);
            this.grpBoutonFinal.Name = "grpBoutonFinal";
            this.grpBoutonFinal.Size = new System.Drawing.Size(1460, 80);
            this.grpBoutonFinal.TabStop = false;
            this.grpBoutonFinal.Text = "Enregistrement";
            this.grpBoutonFinal.Visible = false;

            this.btnValiderMission.BackColor = System.Drawing.Color.FromArgb(30, 80, 50);
            this.btnValiderMission.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnValiderMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValiderMission.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnValiderMission.ForeColor = System.Drawing.Color.FromArgb(230, 235, 255);
            this.btnValiderMission.Location = new System.Drawing.Point(600, 20);
            this.btnValiderMission.Margin = new System.Windows.Forms.Padding(2);
            this.btnValiderMission.Name = "btnValiderMission";
            this.btnValiderMission.Size = new System.Drawing.Size(280, 50);
            this.btnValiderMission.Text = "🚀  Créer la mission";
            this.btnValiderMission.UseVisualStyleBackColor = false;
            this.btnValiderMission.Click += new System.EventHandler(this.btnValiderMission_Click);

            // ════════════════════════════════════════════════════════════════════
            // Form2 — volet 2 : nouvelle mission
            // ════════════════════════════════════════════════════════════════════
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 15, 30);
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlContenu);
            this.Controls.Add(this.pnlSidebar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "Form2";
            this.Text = "Stargate — Volet 2 : Nouvelle mission";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContenu.ResumeLayout(false);
            this.grpInfosMission.ResumeLayout(false);
            this.grpChoixChef.ResumeLayout(false);
            this.grpChoixMembres.ResumeLayout(false);
            this.grpObjCaptures.ResumeLayout(false);
            this.grpBoutonFinal.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        // ── Sidebar ──────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarTitre;
        private System.Windows.Forms.Panel pnlSidebarSep;
        // ── Contenu ──────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlContenu;
        private System.Windows.Forms.Label lblTitreVolet;
        private System.Windows.Forms.Label lblChoixPlanete;
        private System.Windows.Forms.ComboBox cboChoixPlanete;
        private System.Windows.Forms.Button btnChoixPlanete;
        private System.Windows.Forms.Label lblNomMission;
        // ── Étape 2 ──────────────────────────────────────────────────────────
        private System.Windows.Forms.GroupBox grpInfosMission;
        private System.Windows.Forms.Label lblParametreMission;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateDepart;
        private System.Windows.Forms.Label lblDateRetourPrevu;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateRetourPrevu;
        private System.Windows.Forms.Label lblFeuilleRoute;
        private System.Windows.Forms.TextBox txtFeuilleRoute;
        private System.Windows.Forms.Label lblObjData;
        private System.Windows.Forms.TextBox txtObjData;
        private System.Windows.Forms.Label lblTonnes;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Button btnValiderInfos;
        // ── Étape 3 ──────────────────────────────────────────────────────────
        private System.Windows.Forms.GroupBox grpChoixChef;
        private System.Windows.Forms.Label lblChoixChef;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.ComboBox cboChoixChef;
        private System.Windows.Forms.Label lblNbMembres;
        private System.Windows.Forms.TextBox txtNbMembres;
        private System.Windows.Forms.Label lblPersonnes;
        private System.Windows.Forms.Button btnValiderChef;
        // ── Étape 4 ──────────────────────────────────────────────────────────
        private System.Windows.Forms.GroupBox grpChoixMembres;
        private System.Windows.Forms.Label lblAffectationMembre;
        private System.Windows.Forms.ComboBox cboAffecterMembre;
        private System.Windows.Forms.Button btnValiderMembre;
        private System.Windows.Forms.ListBox lboListeMembre;
        private System.Windows.Forms.Button btnSupprimerMembre;
        private System.Windows.Forms.Button btnValiderMembreMission;
        // ── Étape 5 ──────────────────────────────────────────────────────────
        private System.Windows.Forms.GroupBox grpObjCaptures;
        private System.Windows.Forms.Label lblObj;
        private System.Windows.Forms.ComboBox cboObj;
        private System.Windows.Forms.TextBox txtQuantiteObj;
        private System.Windows.Forms.Button btnValiderObj;
        private System.Windows.Forms.ListBox lboListeObj;
        private System.Windows.Forms.Button btnSupprimerObj;
        private System.Windows.Forms.Button btnValiderObjMission;
        // ── Validation finale ─────────────────────────────────────────────────
        private System.Windows.Forms.GroupBox grpBoutonFinal;
        private System.Windows.Forms.Button btnValiderMission;
    }
}
