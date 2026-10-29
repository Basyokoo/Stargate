using System.Drawing;
using System.Windows.Forms;

namespace Stargate
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dgvStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dgvStyle6 = new System.Windows.Forms.DataGridViewCellStyle();

            // ── Sidebar ──────────────────────────────────────────────────────
            this.pnlSidebar       = new System.Windows.Forms.Panel();
            this.lblSidebarTitre  = new System.Windows.Forms.Label();
            this.pnlSidebarSep    = new System.Windows.Forms.Panel();
            // ── Zone principale ───────────────────────────────────────────────
            this.pnlMain          = new System.Windows.Forms.Panel();
            this.pnlHeader        = new System.Windows.Forms.Panel();
            this.lblTitreMission  = new System.Windows.Forms.Label();
            this.lblDateDepart    = new System.Windows.Forms.Label();
            this.lblDateRetour    = new System.Windows.Forms.Label();
            this.lblChef          = new System.Windows.Forms.Label();
            this.lblObjectifDatabaz = new System.Windows.Forms.Label();
            this.lblBudgetInitial = new System.Windows.Forms.Label();
            this.lblSolde         = new System.Windows.Forms.Label();
            this.lblTitreFeuille  = new System.Windows.Forms.Label();
            this.txtFeuilleRoute  = new System.Windows.Forms.RichTextBox();
            this.pnlFeuille       = new System.Windows.Forms.Panel();
            this.pnlMembres       = new System.Windows.Forms.Panel();
            this.lblTitreMembres  = new System.Windows.Forms.Label();
            this.flpMembres       = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCaptures      = new System.Windows.Forms.Panel();
            this.lblTitreCaptures = new System.Windows.Forms.Label();
            this.btnMajCaptures   = new System.Windows.Forms.Button();
            this.dgvCaptures      = new System.Windows.Forms.DataGridView();
            this.colEspece        = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObjectif      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCaptures      = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTaux          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlJournalContainer = new System.Windows.Forms.Panel();
            this.lblTitreJournal  = new System.Windows.Forms.Label();
            this.pnlJournal       = new System.Windows.Forms.Panel();
            this.pnlNavJournal    = new System.Windows.Forms.Panel();
            this.btnPremier       = new System.Windows.Forms.Button();
            this.btnPrecedent     = new System.Windows.Forms.Button();
            this.lblPositionJournal = new System.Windows.Forms.Label();
            this.btnSuivant       = new System.Windows.Forms.Button();
            this.btnDernier       = new System.Windows.Forms.Button();
            this.pnlDepenses      = new System.Windows.Forms.Panel();
            this.lblTitreDepenses = new System.Windows.Forms.Label();
            this.dgvDepenses      = new System.Windows.Forms.DataGridView();
            this.colDate          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMotif         = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMontant       = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType          = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalDepenses = new System.Windows.Forms.Label();
            this.pnlContacts      = new System.Windows.Forms.Panel();
            this.lblTitreContacts = new System.Windows.Forms.Label();
            this.dgvContacts      = new System.Windows.Forms.DataGridView();
            this.colContactDate   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactCode   = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactEspece = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactSomme  = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactApprec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalContacts = new System.Windows.Forms.Label();
            this.pnlBoutonsAjout  = new System.Windows.Forms.Panel();
            this.btnGenererPDF    = new System.Windows.Forms.Button();
            this.btnAjoutJournal  = new System.Windows.Forms.Button();
            this.btnAjoutDepense  = new System.Windows.Forms.Button();
            this.btnAjoutNegociation = new System.Windows.Forms.Button();
            this.btnMajCaptures2  = new System.Windows.Forms.Button();

            this.pnlSidebar.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlMembres.SuspendLayout();
            this.pnlCaptures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaptures)).BeginInit();
            this.pnlJournalContainer.SuspendLayout();
            this.pnlNavJournal.SuspendLayout();
            this.pnlDepenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).BeginInit();
            this.pnlContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            this.pnlBoutonsAjout.SuspendLayout();
            this.SuspendLayout();

            // ════════════════════════════════════════════════════════════════
            // pnlSidebar — barre de navigation latérale gauche
            // ════════════════════════════════════════════════════════════════
            this.pnlSidebar.BackColor = Color.FromArgb(10, 15, 30);
            this.pnlSidebar.Controls.Add(this.lblSidebarTitre);
            this.pnlSidebar.Controls.Add(this.pnlSidebarSep);
            this.pnlSidebar.Dock = DockStyle.Left;
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Width = 395;

            this.lblSidebarTitre.AutoSize = false;
            this.lblSidebarTitre.Font = new Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitre.ForeColor = Color.FromArgb(255, 200, 50);
            this.lblSidebarTitre.Location = new System.Drawing.Point(8, 12);
            this.lblSidebarTitre.Size = new System.Drawing.Size(379, 82);
            this.lblSidebarTitre.Text = "✦ STARGATE ✦";
            this.lblSidebarTitre.TextAlign = ContentAlignment.MiddleCenter;

            this.pnlSidebarSep.BackColor = Color.FromArgb(40, 80, 160);
            this.pnlSidebarSep.Location = new System.Drawing.Point(12, 102);
            this.pnlSidebarSep.Size = new System.Drawing.Size(371, 2);

            // ════════════════════════════════════════════════════════════════
            // pnlMain — zone de contenu scrollable (remplit l'espace après sidebar)
            // ════════════════════════════════════════════════════════════════
            this.pnlMain.AutoScroll = true;
            this.pnlMain.BackColor = Color.FromArgb(10, 15, 30);
            this.pnlMain.Controls.Add(this.pnlHeader);
            this.pnlMain.Controls.Add(this.pnlMembres);
            this.pnlMain.Controls.Add(this.pnlCaptures);
            this.pnlMain.Controls.Add(this.pnlJournalContainer);
            this.pnlMain.Controls.Add(this.pnlDepenses);
            this.pnlMain.Controls.Add(this.pnlContacts);
            this.pnlMain.Controls.Add(this.pnlBoutonsAjout);
            this.pnlMain.Dock = DockStyle.Fill;
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new Padding(12);

            // ════════════════════════════════════════════════════════════════
            // pnlHeader — informations générales de la mission
            // ════════════════════════════════════════════════════════════════
            this.pnlHeader.BackColor = Color.FromArgb(22, 32, 55);
            this.pnlHeader.Controls.Add(this.lblTitreMission);
            this.pnlHeader.Controls.Add(this.lblDateDepart);
            this.pnlHeader.Controls.Add(this.lblDateRetour);
            this.pnlHeader.Controls.Add(this.lblChef);
            this.pnlHeader.Controls.Add(this.lblObjectifDatabaz);
            this.pnlHeader.Controls.Add(this.lblBudgetInitial);
            this.pnlHeader.Controls.Add(this.lblSolde);
            this.pnlHeader.Controls.Add(this.lblTitreFeuille);
            this.pnlHeader.Controls.Add(this.txtFeuilleRoute);
            this.pnlHeader.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right)));
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new Padding(12);
            this.pnlHeader.Size = new System.Drawing.Size(1470, 162);

            this.lblTitreMission.Font = new Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitreMission.ForeColor = Color.FromArgb(255, 200, 50);
            this.lblTitreMission.Location = new System.Drawing.Point(12, 8);
            this.lblTitreMission.Name = "lblTitreMission";
            this.lblTitreMission.Size = new System.Drawing.Size(700, 40);
            this.lblTitreMission.Text = "Mission";

            this.lblDateDepart.Font = new Font("Segoe UI", 14F);
            this.lblDateDepart.ForeColor = Color.FromArgb(140, 155, 180);
            this.lblDateDepart.Location = new System.Drawing.Point(12, 55);
            this.lblDateDepart.Name = "lblDateDepart";
            this.lblDateDepart.Size = new System.Drawing.Size(360, 26);
            this.lblDateDepart.Text = "Départ :";

            this.lblDateRetour.Font = new Font("Segoe UI", 14F);
            this.lblDateRetour.ForeColor = Color.FromArgb(140, 155, 180);
            this.lblDateRetour.Location = new System.Drawing.Point(12, 83);
            this.lblDateRetour.Name = "lblDateRetour";
            this.lblDateRetour.Size = new System.Drawing.Size(360, 26);
            this.lblDateRetour.Text = "Retour prévu :";

            this.lblChef.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblChef.ForeColor = Color.FromArgb(100, 200, 255);
            this.lblChef.Location = new System.Drawing.Point(390, 55);
            this.lblChef.Name = "lblChef";
            this.lblChef.Size = new System.Drawing.Size(440, 26);
            this.lblChef.Text = "Chef :";

            this.lblObjectifDatabaz.Font = new Font("Segoe UI", 14F);
            this.lblObjectifDatabaz.ForeColor = Color.FromArgb(140, 155, 180);
            this.lblObjectifDatabaz.Location = new System.Drawing.Point(390, 83);
            this.lblObjectifDatabaz.Name = "lblObjectifDatabaz";
            this.lblObjectifDatabaz.Size = new System.Drawing.Size(380, 26);
            this.lblObjectifDatabaz.Text = "Objectif DataBaz :";

            this.lblBudgetInitial.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblBudgetInitial.ForeColor = Color.FromArgb(230, 235, 255);
            this.lblBudgetInitial.Location = new System.Drawing.Point(850, 55);
            this.lblBudgetInitial.Name = "lblBudgetInitial";
            this.lblBudgetInitial.Size = new System.Drawing.Size(500, 26);
            this.lblBudgetInitial.Text = "Budget initial :";

            this.lblSolde.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblSolde.ForeColor = Color.FromArgb(80, 220, 120);
            this.lblSolde.Location = new System.Drawing.Point(850, 83);
            this.lblSolde.Name = "lblSolde";
            this.lblSolde.Size = new System.Drawing.Size(500, 26);
            this.lblSolde.Text = "Solde :";

            this.lblTitreFeuille.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitreFeuille.ForeColor = Color.FromArgb(255, 200, 50);
            this.lblTitreFeuille.Location = new System.Drawing.Point(12, 122);
            this.lblTitreFeuille.Name = "lblTitreFeuille";
            this.lblTitreFeuille.Size = new System.Drawing.Size(170, 26);
            this.lblTitreFeuille.Text = "Feuille de route :";

            this.txtFeuilleRoute.BackColor = Color.FromArgb(22, 32, 55);
            this.txtFeuilleRoute.BorderStyle = BorderStyle.None;
            this.txtFeuilleRoute.Font = new Font("Segoe UI", 13F, System.Drawing.FontStyle.Italic);
            this.txtFeuilleRoute.ForeColor = Color.FromArgb(140, 155, 180);
            this.txtFeuilleRoute.Location = new System.Drawing.Point(188, 122);
            this.txtFeuilleRoute.Multiline = false;
            this.txtFeuilleRoute.Name = "txtFeuilleRoute";
            this.txtFeuilleRoute.ReadOnly = true;
            this.txtFeuilleRoute.ScrollBars = RichTextBoxScrollBars.None;
            this.txtFeuilleRoute.Size = new System.Drawing.Size(1270, 28);

            // ════════════════════════════════════════════════════════════════
            // pnlMembres — liste des membres de l'équipage
            // ════════════════════════════════════════════════════════════════
            this.pnlMembres.BackColor = Color.FromArgb(22, 32, 55);
            this.pnlMembres.Controls.Add(this.lblTitreMembres);
            this.pnlMembres.Controls.Add(this.flpMembres);
            this.pnlMembres.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right)));
            this.pnlMembres.Location = new System.Drawing.Point(12, 186);
            this.pnlMembres.Name = "pnlMembres";
            this.pnlMembres.Padding = new Padding(10);
            this.pnlMembres.Size = new System.Drawing.Size(1470, 210);

            this.lblTitreMembres.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitreMembres.ForeColor = Color.FromArgb(50, 130, 255);
            this.lblTitreMembres.Location = new System.Drawing.Point(10, 8);
            this.lblTitreMembres.Size = new System.Drawing.Size(400, 28);
            this.lblTitreMembres.Text = "👥 Membres de l'équipage";

            this.flpMembres.AutoScroll = true;
            this.flpMembres.BackColor = Color.FromArgb(22, 32, 55);
            this.flpMembres.Location = new System.Drawing.Point(10, 40);
            this.flpMembres.Name = "flpMembres";
            this.flpMembres.Size = new System.Drawing.Size(1448, 162);
            this.flpMembres.WrapContents = false;

            // ════════════════════════════════════════════════════════════════
            // pnlCaptures — objectifs et taux de capture des espèces
            // ════════════════════════════════════════════════════════════════
            this.pnlCaptures.BackColor = Color.FromArgb(22, 32, 55);
            this.pnlCaptures.Controls.Add(this.lblTitreCaptures);
            this.pnlCaptures.Controls.Add(this.btnMajCaptures);
            this.pnlCaptures.Controls.Add(this.dgvCaptures);
            this.pnlCaptures.Location = new System.Drawing.Point(12, 408);
            this.pnlCaptures.Name = "pnlCaptures";
            this.pnlCaptures.Padding = new Padding(10);
            this.pnlCaptures.Size = new System.Drawing.Size(730, 260);

            this.lblTitreCaptures.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitreCaptures.ForeColor = Color.FromArgb(50, 130, 255);
            this.lblTitreCaptures.Location = new System.Drawing.Point(10, 8);
            this.lblTitreCaptures.Size = new System.Drawing.Size(350, 28);
            this.lblTitreCaptures.Text = "🎯 Objectifs de capture";

            this.btnMajCaptures.BackColor = Color.FromArgb(20, 60, 40);
            this.btnMajCaptures.Cursor = Cursors.Hand;
            this.btnMajCaptures.FlatAppearance.BorderColor = Color.FromArgb(50, 160, 90);
            this.btnMajCaptures.FlatStyle = FlatStyle.Flat;
            this.btnMajCaptures.Font = new Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnMajCaptures.ForeColor = Color.FromArgb(230, 235, 255);
            this.btnMajCaptures.Location = new System.Drawing.Point(440, 5);
            this.btnMajCaptures.Name = "btnMajCaptures";
            this.btnMajCaptures.Size = new System.Drawing.Size(270, 34);
            this.btnMajCaptures.Text = "🔄  Mettre à jour les captures";
            this.btnMajCaptures.Click += new System.EventHandler(this.btnMajCaptures_Click);

            // DataGridView captures — style sombre
            dgvStyle1.BackColor = Color.FromArgb(30, 45, 80);
            dgvStyle1.Font = new Font("Segoe UI", 13F);
            dgvStyle1.ForeColor = Color.FromArgb(255, 200, 50);
            dgvStyle1.SelectionBackColor = SystemColors.Highlight;
            dgvStyle1.WrapMode = DataGridViewTriState.True;
            dgvStyle2.BackColor = Color.FromArgb(18, 25, 45);
            dgvStyle2.Font = new Font("Segoe UI", 13F);
            dgvStyle2.ForeColor = Color.FromArgb(230, 235, 255);
            dgvStyle2.SelectionBackColor = Color.FromArgb(50, 70, 120);
            dgvStyle2.SelectionForeColor = Color.FromArgb(230, 235, 255);

            this.dgvCaptures.AllowUserToAddRows = false;
            this.dgvCaptures.BackgroundColor = Color.FromArgb(18, 25, 45);
            this.dgvCaptures.BorderStyle = BorderStyle.None;
            this.dgvCaptures.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvCaptures.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvCaptures.ColumnHeadersDefaultCellStyle = dgvStyle1;
            this.dgvCaptures.Columns.AddRange(this.colEspece, this.colObjectif, this.colCaptures, this.colTaux);
            this.dgvCaptures.DefaultCellStyle = dgvStyle2;
            this.dgvCaptures.GridColor = Color.FromArgb(35, 50, 80);
            this.dgvCaptures.Location = new System.Drawing.Point(10, 44);
            this.dgvCaptures.Name = "dgvCaptures";
            this.dgvCaptures.ReadOnly = true;
            this.dgvCaptures.RowHeadersVisible = false;
            this.dgvCaptures.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvCaptures.Size = new System.Drawing.Size(707, 208);

            this.colEspece.HeaderText  = "Espèce";   this.colEspece.Width  = 170;
            this.colObjectif.HeaderText = "Objectif"; this.colObjectif.Width = 70;
            this.colCaptures.HeaderText = "Capturés"; this.colCaptures.Width = 70;
            this.colTaux.HeaderText    = "Taux";     this.colTaux.Width    = 70;
            foreach (var c in new DataGridViewColumn[]{colEspece,colObjectif,colCaptures,colTaux}) c.ReadOnly=true;

            // ════════════════════════════════════════════════════════════════
            // pnlJournalContainer — journal de bord avec navigation
            // ════════════════════════════════════════════════════════════════
            this.pnlJournalContainer.BackColor = Color.FromArgb(22, 32, 55);
            this.pnlJournalContainer.Controls.Add(this.lblTitreJournal);
            this.pnlJournalContainer.Controls.Add(this.pnlJournal);
            this.pnlJournalContainer.Controls.Add(this.pnlNavJournal);
            this.pnlJournalContainer.Location = new System.Drawing.Point(754, 408);
            this.pnlJournalContainer.Name = "pnlJournalContainer";
            this.pnlJournalContainer.Padding = new Padding(10);
            this.pnlJournalContainer.Size = new System.Drawing.Size(728, 260);

            this.lblTitreJournal.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitreJournal.ForeColor = Color.FromArgb(50, 130, 255);
            this.lblTitreJournal.Location = new System.Drawing.Point(10, 8);
            this.lblTitreJournal.Size = new System.Drawing.Size(300, 28);
            this.lblTitreJournal.Text = "📋 Journal de bord";

            this.pnlJournal.BackColor = Color.FromArgb(18, 25, 45);
            this.pnlJournal.Location = new System.Drawing.Point(10, 42);
            this.pnlJournal.Name = "pnlJournal";
            this.pnlJournal.Size = new System.Drawing.Size(706, 166);

            this.pnlNavJournal.BackColor = Color.FromArgb(22, 32, 55);
            this.pnlNavJournal.Controls.Add(this.btnPremier);
            this.pnlNavJournal.Controls.Add(this.btnPrecedent);
            this.pnlNavJournal.Controls.Add(this.lblPositionJournal);
            this.pnlNavJournal.Controls.Add(this.btnSuivant);
            this.pnlNavJournal.Controls.Add(this.btnDernier);
            this.pnlNavJournal.Location = new System.Drawing.Point(10, 214);
            this.pnlNavJournal.Size = new System.Drawing.Size(706, 35);

            Color btnNavBg     = Color.FromArgb(30, 50, 90);
            Color btnNavBorder = Color.FromArgb(50, 130, 255);
            Color btnNavFg     = Color.FromArgb(230, 235, 255);
            Font  btnNavFont   = new Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);

            this.btnPremier.BackColor    = btnNavBg; this.btnPremier.FlatStyle    = FlatStyle.Flat;
            this.btnPremier.FlatAppearance.BorderColor = btnNavBorder;
            this.btnPremier.ForeColor    = btnNavFg; this.btnPremier.Font         = btnNavFont;
            this.btnPremier.Location     = new System.Drawing.Point(0, 5);
            this.btnPremier.Size         = new System.Drawing.Size(44, 26); this.btnPremier.Text = "<<";
            this.btnPremier.Click += new System.EventHandler(this.btnPremier_Click);

            this.btnPrecedent.BackColor  = btnNavBg; this.btnPrecedent.FlatStyle  = FlatStyle.Flat;
            this.btnPrecedent.FlatAppearance.BorderColor = btnNavBorder;
            this.btnPrecedent.ForeColor  = btnNavFg; this.btnPrecedent.Font       = btnNavFont;
            this.btnPrecedent.Location   = new System.Drawing.Point(49, 5);
            this.btnPrecedent.Size       = new System.Drawing.Size(44, 26); this.btnPrecedent.Text = "<";
            this.btnPrecedent.Click += new System.EventHandler(this.btnPrecedent_Click);

            this.lblPositionJournal.Font      = new Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblPositionJournal.ForeColor = Color.FromArgb(140, 155, 180);
            this.lblPositionJournal.Location  = new System.Drawing.Point(302, 8);
            this.lblPositionJournal.Size      = new System.Drawing.Size(100, 22);
            this.lblPositionJournal.Text      = "- / -";
            this.lblPositionJournal.TextAlign = ContentAlignment.MiddleCenter;

            this.btnSuivant.BackColor    = btnNavBg; this.btnSuivant.FlatStyle    = FlatStyle.Flat;
            this.btnSuivant.FlatAppearance.BorderColor = btnNavBorder;
            this.btnSuivant.ForeColor    = btnNavFg; this.btnSuivant.Font         = btnNavFont;
            this.btnSuivant.Location     = new System.Drawing.Point(613, 5);
            this.btnSuivant.Size         = new System.Drawing.Size(44, 26); this.btnSuivant.Text = ">";
            this.btnSuivant.Click += new System.EventHandler(this.btnSuivant_Click);

            this.btnDernier.BackColor    = btnNavBg; this.btnDernier.FlatStyle    = FlatStyle.Flat;
            this.btnDernier.FlatAppearance.BorderColor = btnNavBorder;
            this.btnDernier.ForeColor    = btnNavFg; this.btnDernier.Font         = btnNavFont;
            this.btnDernier.Location     = new System.Drawing.Point(661, 5);
            this.btnDernier.Size         = new System.Drawing.Size(44, 26); this.btnDernier.Text = ">>";
            this.btnDernier.Click += new System.EventHandler(this.btnDernier_Click);

            // ════════════════════════════════════════════════════════════════
            // pnlDepenses — liste des dépenses effectuées
            // ════════════════════════════════════════════════════════════════
            this.pnlDepenses.BackColor = Color.FromArgb(22, 32, 55);
            this.pnlDepenses.Controls.Add(this.lblTitreDepenses);
            this.pnlDepenses.Controls.Add(this.dgvDepenses);
            this.pnlDepenses.Controls.Add(this.lblTotalDepenses);
            this.pnlDepenses.Location = new System.Drawing.Point(12, 680);
            this.pnlDepenses.Name = "pnlDepenses";
            this.pnlDepenses.Padding = new Padding(10);
            this.pnlDepenses.Size = new System.Drawing.Size(730, 270);

            this.lblTitreDepenses.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitreDepenses.ForeColor = Color.FromArgb(50, 130, 255);
            this.lblTitreDepenses.Location = new System.Drawing.Point(10, 8);
            this.lblTitreDepenses.Size = new System.Drawing.Size(300, 28);
            this.lblTitreDepenses.Text = "💰 Dépenses effectuées";

            dgvStyle3.BackColor = Color.FromArgb(30, 45, 80); dgvStyle3.Font = new Font("Segoe UI",13F);
            dgvStyle3.ForeColor = Color.FromArgb(255,200,50); dgvStyle3.WrapMode = DataGridViewTriState.True;
            dgvStyle4.BackColor = Color.FromArgb(18,25,45);   dgvStyle4.Font = new Font("Segoe UI",13F);
            dgvStyle4.ForeColor = Color.FromArgb(230,235,255); dgvStyle4.SelectionBackColor = Color.FromArgb(50,70,120);
            dgvStyle4.SelectionForeColor = Color.FromArgb(230,235,255);

            this.dgvDepenses.AllowUserToAddRows = false;
            this.dgvDepenses.BackgroundColor = Color.FromArgb(18,25,45);
            this.dgvDepenses.BorderStyle = BorderStyle.None;
            this.dgvDepenses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDepenses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvDepenses.ColumnHeadersDefaultCellStyle = dgvStyle3;
            this.dgvDepenses.Columns.AddRange(this.colDate,this.colMotif,this.colMontant,this.colType);
            this.dgvDepenses.DefaultCellStyle = dgvStyle4;
            this.dgvDepenses.GridColor = Color.FromArgb(35,50,80);
            this.dgvDepenses.Location = new System.Drawing.Point(10,40);
            this.dgvDepenses.Name = "dgvDepenses"; this.dgvDepenses.ReadOnly = true;
            this.dgvDepenses.RowHeadersVisible = false;
            this.dgvDepenses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepenses.Size = new System.Drawing.Size(707,200);

            this.colDate.HeaderText = "Date";  this.colDate.Width  = 85;  this.colDate.ReadOnly  = true;
            this.colMotif.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.colMotif.HeaderText = "Motif"; this.colMotif.ReadOnly = true;
            this.colMontant.HeaderText = "Montant"; this.colMontant.Width = 80; this.colMontant.ReadOnly = true;
            this.colType.HeaderText = "Type"; this.colType.Width = 90; this.colType.ReadOnly = true;

            this.lblTotalDepenses.Font = new Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalDepenses.ForeColor = Color.FromArgb(255,150,80);
            this.lblTotalDepenses.Location = new System.Drawing.Point(200,244);
            this.lblTotalDepenses.Size = new System.Drawing.Size(518,22);
            this.lblTotalDepenses.Text = "Total : -";
            this.lblTotalDepenses.TextAlign = ContentAlignment.MiddleRight;

            // ════════════════════════════════════════════════════════════════
            // pnlContacts — contacts informateurs
            // ════════════════════════════════════════════════════════════════
            this.pnlContacts.BackColor = Color.FromArgb(22, 32, 55);
            this.pnlContacts.Controls.Add(this.lblTitreContacts);
            this.pnlContacts.Controls.Add(this.dgvContacts);
            this.pnlContacts.Controls.Add(this.lblTotalContacts);
            this.pnlContacts.Location = new System.Drawing.Point(754, 680);
            this.pnlContacts.Name = "pnlContacts";
            this.pnlContacts.Padding = new Padding(10);
            this.pnlContacts.Size = new System.Drawing.Size(728, 270);

            this.lblTitreContacts.Font = new Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitreContacts.ForeColor = Color.FromArgb(50, 130, 255);
            this.lblTitreContacts.Location = new System.Drawing.Point(10, 8);
            this.lblTitreContacts.Size = new System.Drawing.Size(400, 28);
            this.lblTitreContacts.Text = "🕵️ Contacts informateurs";

            dgvStyle5.BackColor = Color.FromArgb(30,45,80);   dgvStyle5.Font = new Font("Segoe UI",13F);
            dgvStyle5.ForeColor = Color.FromArgb(255,200,50); dgvStyle5.WrapMode = DataGridViewTriState.True;
            dgvStyle6.BackColor = Color.FromArgb(18,25,45);   dgvStyle6.Font = new Font("Segoe UI",13F);
            dgvStyle6.ForeColor = Color.FromArgb(230,235,255); dgvStyle6.SelectionBackColor = Color.FromArgb(50,70,120);
            dgvStyle6.SelectionForeColor = Color.FromArgb(230,235,255);

            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.BackgroundColor = Color.FromArgb(18,25,45);
            this.dgvContacts.BorderStyle = BorderStyle.None;
            this.dgvContacts.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvContacts.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            this.dgvContacts.ColumnHeadersDefaultCellStyle = dgvStyle5;
            this.dgvContacts.Columns.AddRange(this.colContactDate,this.colContactCode,this.colContactEspece,this.colContactSomme,this.colContactApprec);
            this.dgvContacts.DefaultCellStyle = dgvStyle6;
            this.dgvContacts.GridColor = Color.FromArgb(35,50,80);
            this.dgvContacts.Location = new System.Drawing.Point(10,40);
            this.dgvContacts.Name = "dgvContacts"; this.dgvContacts.ReadOnly = true;
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(706,200);

            this.colContactDate.HeaderText = "Date";       this.colContactDate.Width = 80;  this.colContactDate.ReadOnly = true;
            this.colContactCode.HeaderText = "Code";       this.colContactCode.Width = 55;  this.colContactCode.ReadOnly = true;
            this.colContactEspece.HeaderText = "Espèce";   this.colContactEspece.Width = 90; this.colContactEspece.ReadOnly = true;
            this.colContactSomme.HeaderText = "Somme";     this.colContactSomme.Width = 70; this.colContactSomme.ReadOnly = true;
            this.colContactApprec.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.colContactApprec.HeaderText = "Appréciation"; this.colContactApprec.ReadOnly = true;

            this.lblTotalContacts.Font = new Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblTotalContacts.ForeColor = Color.FromArgb(255,150,80);
            this.lblTotalContacts.Location = new System.Drawing.Point(180,244);
            this.lblTotalContacts.Size = new System.Drawing.Size(536,22);
            this.lblTotalContacts.Text = "Total : -";
            this.lblTotalContacts.TextAlign = ContentAlignment.MiddleRight;

            // ════════════════════════════════════════════════════════════════
            // pnlBoutonsAjout — boutons d'action en bas de page
            // ════════════════════════════════════════════════════════════════
            this.pnlBoutonsAjout.BackColor = Color.FromArgb(15, 22, 40);
            this.pnlBoutonsAjout.Controls.Add(this.btnAjoutJournal);
            this.pnlBoutonsAjout.Controls.Add(this.btnAjoutDepense);
            this.pnlBoutonsAjout.Controls.Add(this.btnAjoutNegociation);
            this.pnlBoutonsAjout.Controls.Add(this.btnMajCaptures2);
            this.pnlBoutonsAjout.Controls.Add(this.btnGenererPDF);
            this.pnlBoutonsAjout.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right)));
            this.pnlBoutonsAjout.Location = new System.Drawing.Point(12, 962);
            this.pnlBoutonsAjout.Name = "pnlBoutonsAjout";
            this.pnlBoutonsAjout.Padding = new Padding(5);
            this.pnlBoutonsAjout.Size = new System.Drawing.Size(1470, 62);

            Font btnFont = new Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);

            this.btnAjoutJournal.BackColor = Color.FromArgb(30,60,110);
            this.btnAjoutJournal.FlatAppearance.BorderColor = Color.FromArgb(50,130,255);
            this.btnAjoutJournal.FlatStyle = FlatStyle.Flat;
            this.btnAjoutJournal.Font = btnFont; this.btnAjoutJournal.Cursor = Cursors.Hand;
            this.btnAjoutJournal.ForeColor = Color.FromArgb(230,235,255);
            this.btnAjoutJournal.Location = new System.Drawing.Point(8, 8);
            this.btnAjoutJournal.Name = "btnAjoutJournal";
            this.btnAjoutJournal.Size = new System.Drawing.Size(255, 44);
            this.btnAjoutJournal.Text = "📋  Ajouter au journal";
            this.btnAjoutJournal.Click += new System.EventHandler(this.btnAjoutJournal_Click);

            this.btnAjoutDepense.BackColor = Color.FromArgb(60,40,10);
            this.btnAjoutDepense.FlatAppearance.BorderColor = Color.FromArgb(255,200,50);
            this.btnAjoutDepense.FlatStyle = FlatStyle.Flat;
            this.btnAjoutDepense.Font = btnFont; this.btnAjoutDepense.Cursor = Cursors.Hand;
            this.btnAjoutDepense.ForeColor = Color.FromArgb(230,235,255);
            this.btnAjoutDepense.Location = new System.Drawing.Point(273, 8);
            this.btnAjoutDepense.Name = "btnAjoutDepense";
            this.btnAjoutDepense.Size = new System.Drawing.Size(265, 44);
            this.btnAjoutDepense.Text = "💰  Ajouter une dépense";
            this.btnAjoutDepense.Click += new System.EventHandler(this.btnAjoutDepense_Click);

            this.btnAjoutNegociation.BackColor = Color.FromArgb(40,20,60);
            this.btnAjoutNegociation.FlatAppearance.BorderColor = Color.FromArgb(160,80,220);
            this.btnAjoutNegociation.FlatStyle = FlatStyle.Flat;
            this.btnAjoutNegociation.Font = btnFont; this.btnAjoutNegociation.Cursor = Cursors.Hand;
            this.btnAjoutNegociation.ForeColor = Color.FromArgb(230,235,255);
            this.btnAjoutNegociation.Location = new System.Drawing.Point(548, 8);
            this.btnAjoutNegociation.Name = "btnAjoutNegociation";
            this.btnAjoutNegociation.Size = new System.Drawing.Size(290, 44);
            this.btnAjoutNegociation.Text = "🕵️  Ajouter une négociation";
            this.btnAjoutNegociation.Click += new System.EventHandler(this.btnAjoutNegociation_Click);

            this.btnMajCaptures2.BackColor = Color.FromArgb(20,60,40);
            this.btnMajCaptures2.FlatAppearance.BorderColor = Color.FromArgb(50,160,90);
            this.btnMajCaptures2.FlatStyle = FlatStyle.Flat;
            this.btnMajCaptures2.Font = btnFont; this.btnMajCaptures2.Cursor = Cursors.Hand;
            this.btnMajCaptures2.ForeColor = Color.FromArgb(230,235,255);
            this.btnMajCaptures2.Location = new System.Drawing.Point(848, 8);
            this.btnMajCaptures2.Name = "btnMajCaptures2";
            this.btnMajCaptures2.Size = new System.Drawing.Size(295, 44);
            this.btnMajCaptures2.Text = "🔄  Mettre à jour les captures";
            this.btnMajCaptures2.Click += new System.EventHandler(this.btnMajCaptures_Click);

            this.btnGenererPDF.BackColor = Color.FromArgb(0,60,0);
            this.btnGenererPDF.FlatAppearance.BorderColor = Color.FromArgb(0,140,0);
            this.btnGenererPDF.FlatStyle = FlatStyle.Flat;
            this.btnGenererPDF.Font = btnFont; this.btnGenererPDF.Cursor = Cursors.Hand;
            this.btnGenererPDF.ForeColor = Color.FromArgb(230,235,255);
            this.btnGenererPDF.Location = new System.Drawing.Point(1153, 8);
            this.btnGenererPDF.Name = "btnGenererPDF";
            this.btnGenererPDF.Size = new System.Drawing.Size(305, 44);
            this.btnGenererPDF.Text = "📄  Générer le résumé PDF";
            this.btnGenererPDF.Click += new System.EventHandler(this.btnGenererPDF_Click);

            // Placeholder panel inutilisé (hérité)
            this.pnlFeuille.Location = new System.Drawing.Point(0,0);
            this.pnlFeuille.Size = new System.Drawing.Size(100,50);

            // ════════════════════════════════════════════════════════════════
            // Form3 — récapitulatif complet d'une mission
            // ════════════════════════════════════════════════════════════════
            this.BackColor = Color.FromArgb(10, 15, 30);
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlSidebar);
            this.Font = new Font("Segoe UI", 9F);
            this.ForeColor = Color.FromArgb(230, 235, 255);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "Form3";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Récapitulatif de mission";
            this.Load += new System.EventHandler(this.Form4_Load);

            this.pnlSidebar.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlMembres.ResumeLayout(false);
            this.pnlCaptures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCaptures)).EndInit();
            this.pnlJournalContainer.ResumeLayout(false);
            this.pnlNavJournal.ResumeLayout(false);
            this.pnlDepenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepenses)).EndInit();
            this.pnlContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            this.pnlBoutonsAjout.ResumeLayout(false);
            this.pnlMain.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        // ── Sidebar ──────────────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarTitre;
        private System.Windows.Forms.Panel pnlSidebarSep;
        // ── Zone principale ───────────────────────────────────────────────────
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitreMission;
        private System.Windows.Forms.Label lblDateDepart;
        private System.Windows.Forms.Label lblDateRetour;
        private System.Windows.Forms.Label lblChef;
        private System.Windows.Forms.Label lblObjectifDatabaz;
        private System.Windows.Forms.Label lblBudgetInitial;
        private System.Windows.Forms.Label lblSolde;
        private System.Windows.Forms.Label lblTitreFeuille;
        private System.Windows.Forms.RichTextBox txtFeuilleRoute;
        private System.Windows.Forms.Panel pnlFeuille;
        private System.Windows.Forms.Panel pnlMembres;
        private System.Windows.Forms.Label lblTitreMembres;
        private System.Windows.Forms.FlowLayoutPanel flpMembres;
        private System.Windows.Forms.Panel pnlCaptures;
        private System.Windows.Forms.Label lblTitreCaptures;
        private System.Windows.Forms.DataGridView dgvCaptures;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEspece;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObjectif;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCaptures;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTaux;
        private System.Windows.Forms.Panel pnlJournalContainer;
        private System.Windows.Forms.Label lblTitreJournal;
        private System.Windows.Forms.Panel pnlJournal;
        private System.Windows.Forms.Panel pnlNavJournal;
        private System.Windows.Forms.Button btnPremier;
        private System.Windows.Forms.Button btnPrecedent;
        private System.Windows.Forms.Button btnSuivant;
        private System.Windows.Forms.Button btnDernier;
        private System.Windows.Forms.Label lblPositionJournal;
        private System.Windows.Forms.Panel pnlDepenses;
        private System.Windows.Forms.Label lblTitreDepenses;
        private System.Windows.Forms.DataGridView dgvDepenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMotif;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMontant;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.Label lblTotalDepenses;
        private System.Windows.Forms.Panel pnlContacts;
        private System.Windows.Forms.Label lblTitreContacts;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactEspece;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactSomme;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactApprec;
        private System.Windows.Forms.Label lblTotalContacts;
        private System.Windows.Forms.Panel pnlBoutonsAjout;
        private System.Windows.Forms.Button btnAjoutJournal;
        private System.Windows.Forms.Button btnAjoutDepense;
        private System.Windows.Forms.Button btnAjoutNegociation;
        private System.Windows.Forms.Button btnMajCaptures;
        private System.Windows.Forms.Button btnMajCaptures2;
        private System.Windows.Forms.Button btnGenererPDF;
    }
}
