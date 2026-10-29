namespace Stargate
{
    partial class volet5
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
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.lblSidebarTitre = new System.Windows.Forms.Label();
            this.pnlSidebarSep = new System.Windows.Forms.Panel();
            this.pnlContenu = new System.Windows.Forms.Panel();
            this.lblTitreVolet = new System.Windows.Forms.Label();
            this.pnlFiltres = new System.Windows.Forms.Panel();
            this.chkEnemis = new System.Windows.Forms.CheckBox();
            this.chkAlliés = new System.Windows.Forms.CheckBox();
            this.cboArme = new System.Windows.Forms.ComboBox();
            this.cboInstrument = new System.Windows.Forms.ComboBox();
            this.lblCouleur = new System.Windows.Forms.Label();
            this.cboCouleur = new System.Windows.Forms.ComboBox();
            this.lblBien = new System.Windows.Forms.Label();
            this.cboDegresBienveillance = new System.Windows.Forms.ComboBox();
            this.lblAgro = new System.Windows.Forms.Label();
            this.cboDegresAgressivité = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTriePlanete = new System.Windows.Forms.ComboBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtFiltreNom = new System.Windows.Forms.TextBox();
            this.btnResetFiltre = new System.Windows.Forms.Button();
            this.flpAlien = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSidebar.SuspendLayout();
            this.pnlContenu.SuspendLayout();
            this.pnlFiltres.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.pnlSidebar.Controls.Add(this.lblSidebarTitre);
            this.pnlSidebar.Controls.Add(this.pnlSidebarSep);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(395, 1041);
            this.pnlSidebar.TabIndex = 1;
            // 
            // lblSidebarTitre
            // 
            this.lblSidebarTitre.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblSidebarTitre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.lblSidebarTitre.Location = new System.Drawing.Point(8, 12);
            this.lblSidebarTitre.Name = "lblSidebarTitre";
            this.lblSidebarTitre.Size = new System.Drawing.Size(379, 82);
            this.lblSidebarTitre.TabIndex = 0;
            this.lblSidebarTitre.Text = "✦ STARGATE ✦";
            this.lblSidebarTitre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlSidebarSep
            // 
            this.pnlSidebarSep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(80)))), ((int)(((byte)(160)))));
            this.pnlSidebarSep.Location = new System.Drawing.Point(12, 102);
            this.pnlSidebarSep.Name = "pnlSidebarSep";
            this.pnlSidebarSep.Size = new System.Drawing.Size(371, 2);
            this.pnlSidebarSep.TabIndex = 1;
            // 
            // pnlContenu
            // 
            this.pnlContenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.pnlContenu.Controls.Add(this.lblTitreVolet);
            this.pnlContenu.Controls.Add(this.pnlFiltres);
            this.pnlContenu.Controls.Add(this.flpAlien);
            this.pnlContenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenu.Location = new System.Drawing.Point(395, 0);
            this.pnlContenu.Name = "pnlContenu";
            this.pnlContenu.Size = new System.Drawing.Size(1509, 1041);
            this.pnlContenu.TabIndex = 0;
            // 
            // lblTitreVolet
            // 
            this.lblTitreVolet.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitreVolet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(50)))));
            this.lblTitreVolet.Location = new System.Drawing.Point(10, 10);
            this.lblTitreVolet.Name = "lblTitreVolet";
            this.lblTitreVolet.Size = new System.Drawing.Size(900, 46);
            this.lblTitreVolet.TabIndex = 0;
            this.lblTitreVolet.Text = "👽  Volet 5 — Découverte des espèces";
            // 
            // pnlFiltres
            // 
            this.pnlFiltres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFiltres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(25)))), ((int)(((byte)(45)))));
            this.pnlFiltres.Controls.Add(this.chkEnemis);
            this.pnlFiltres.Controls.Add(this.chkAlliés);
            this.pnlFiltres.Controls.Add(this.cboArme);
            this.pnlFiltres.Controls.Add(this.cboInstrument);
            this.pnlFiltres.Controls.Add(this.lblCouleur);
            this.pnlFiltres.Controls.Add(this.cboCouleur);
            this.pnlFiltres.Controls.Add(this.lblBien);
            this.pnlFiltres.Controls.Add(this.cboDegresBienveillance);
            this.pnlFiltres.Controls.Add(this.lblAgro);
            this.pnlFiltres.Controls.Add(this.cboDegresAgressivité);
            this.pnlFiltres.Controls.Add(this.label1);
            this.pnlFiltres.Controls.Add(this.cboTriePlanete);
            this.pnlFiltres.Controls.Add(this.lblNom);
            this.pnlFiltres.Controls.Add(this.txtFiltreNom);
            this.pnlFiltres.Controls.Add(this.btnResetFiltre);
            this.pnlFiltres.Location = new System.Drawing.Point(10, 62);
            this.pnlFiltres.Name = "pnlFiltres";
            this.pnlFiltres.Size = new System.Drawing.Size(2789, 96);
            this.pnlFiltres.TabIndex = 1;
            // 
            // chkEnemis
            // 
            this.chkEnemis.AutoSize = true;
            this.chkEnemis.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.chkEnemis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.chkEnemis.Location = new System.Drawing.Point(8, 8);
            this.chkEnemis.Name = "chkEnemis";
            this.chkEnemis.Size = new System.Drawing.Size(105, 29);
            this.chkEnemis.TabIndex = 0;
            this.chkEnemis.Text = "Ennemis";
            this.chkEnemis.CheckedChanged += new System.EventHandler(this.chkEnemis_CheckedChanged);
            // 
            // chkAlliés
            // 
            this.chkAlliés.AutoSize = true;
            this.chkAlliés.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.chkAlliés.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.chkAlliés.Location = new System.Drawing.Point(8, 50);
            this.chkAlliés.Name = "chkAlliés";
            this.chkAlliés.Size = new System.Drawing.Size(77, 29);
            this.chkAlliés.TabIndex = 1;
            this.chkAlliés.Text = "Alliés";
            this.chkAlliés.CheckedChanged += new System.EventHandler(this.chkAlliés_CheckedChanged);
            // 
            // cboArme
            // 
            this.cboArme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.cboArme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboArme.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboArme.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cboArme.FormattingEnabled = true;
            this.cboArme.Location = new System.Drawing.Point(110, 8);
            this.cboArme.Name = "cboArme";
            this.cboArme.Size = new System.Drawing.Size(180, 33);
            this.cboArme.TabIndex = 2;
            this.cboArme.Visible = false;
            this.cboArme.SelectedIndexChanged += new System.EventHandler(this.cboArme_SelectedIndexChanged);
            // 
            // cboInstrument
            // 
            this.cboInstrument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.cboInstrument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboInstrument.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboInstrument.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cboInstrument.FormattingEnabled = true;
            this.cboInstrument.Location = new System.Drawing.Point(110, 50);
            this.cboInstrument.Name = "cboInstrument";
            this.cboInstrument.Size = new System.Drawing.Size(180, 33);
            this.cboInstrument.TabIndex = 3;
            this.cboInstrument.Visible = false;
            this.cboInstrument.SelectedIndexChanged += new System.EventHandler(this.cboInstrument_SelectedIndexChanged);
            // 
            // lblCouleur
            // 
            this.lblCouleur.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblCouleur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.lblCouleur.Location = new System.Drawing.Point(306, 10);
            this.lblCouleur.Name = "lblCouleur";
            this.lblCouleur.Size = new System.Drawing.Size(165, 28);
            this.lblCouleur.TabIndex = 4;
            this.lblCouleur.Text = "Couleur :";
            // 
            // cboCouleur
            // 
            this.cboCouleur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.cboCouleur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCouleur.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboCouleur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cboCouleur.FormattingEnabled = true;
            this.cboCouleur.Location = new System.Drawing.Point(478, 6);
            this.cboCouleur.Name = "cboCouleur";
            this.cboCouleur.Size = new System.Drawing.Size(180, 33);
            this.cboCouleur.TabIndex = 5;
            this.cboCouleur.SelectedIndexChanged += new System.EventHandler(this.cboCouleur_SelectedIndexChanged);
            // 
            // lblBien
            // 
            this.lblBien.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblBien.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.lblBien.Location = new System.Drawing.Point(676, 10);
            this.lblBien.Name = "lblBien";
            this.lblBien.Size = new System.Drawing.Size(200, 28);
            this.lblBien.TabIndex = 6;
            this.lblBien.Text = "Bienveillance :";
            this.lblBien.Visible = false;
            // 
            // cboDegresBienveillance
            // 
            this.cboDegresBienveillance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.cboDegresBienveillance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDegresBienveillance.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboDegresBienveillance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cboDegresBienveillance.FormattingEnabled = true;
            this.cboDegresBienveillance.Location = new System.Drawing.Point(880, 6);
            this.cboDegresBienveillance.Name = "cboDegresBienveillance";
            this.cboDegresBienveillance.Size = new System.Drawing.Size(150, 33);
            this.cboDegresBienveillance.TabIndex = 7;
            this.cboDegresBienveillance.Visible = false;
            this.cboDegresBienveillance.SelectedIndexChanged += new System.EventHandler(this.cboDegresBienveillance_SelectedIndexChanged);
            // 
            // lblAgro
            // 
            this.lblAgro.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblAgro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.lblAgro.Location = new System.Drawing.Point(676, 52);
            this.lblAgro.Name = "lblAgro";
            this.lblAgro.Size = new System.Drawing.Size(200, 28);
            this.lblAgro.TabIndex = 8;
            this.lblAgro.Text = "Agressivité :";
            this.lblAgro.Visible = false;
            // 
            // cboDegresAgressivité
            // 
            this.cboDegresAgressivité.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.cboDegresAgressivité.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboDegresAgressivité.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboDegresAgressivité.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cboDegresAgressivité.FormattingEnabled = true;
            this.cboDegresAgressivité.Location = new System.Drawing.Point(880, 48);
            this.cboDegresAgressivité.Name = "cboDegresAgressivité";
            this.cboDegresAgressivité.Size = new System.Drawing.Size(150, 33);
            this.cboDegresAgressivité.TabIndex = 9;
            this.cboDegresAgressivité.Visible = false;
            this.cboDegresAgressivité.SelectedIndexChanged += new System.EventHandler(this.cboDegresAgressivité_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(306, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "Planète :";
            // 
            // cboTriePlanete
            // 
            this.cboTriePlanete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.cboTriePlanete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboTriePlanete.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cboTriePlanete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.cboTriePlanete.FormattingEnabled = true;
            this.cboTriePlanete.Location = new System.Drawing.Point(478, 48);
            this.cboTriePlanete.Name = "cboTriePlanete";
            this.cboTriePlanete.Size = new System.Drawing.Size(180, 33);
            this.cboTriePlanete.TabIndex = 11;
            this.cboTriePlanete.SelectedIndexChanged += new System.EventHandler(this.cboTriePlanete_SelectedIndexChanged);
            // 
            // lblNom
            // 
            this.lblNom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.lblNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.lblNom.Location = new System.Drawing.Point(1048, 10);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(160, 28);
            this.lblNom.TabIndex = 12;
            this.lblNom.Text = "Filtrer par nom :";
            // 
            // txtFiltreNom
            // 
            this.txtFiltreNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(32)))), ((int)(((byte)(55)))));
            this.txtFiltreNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFiltreNom.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtFiltreNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.txtFiltreNom.Location = new System.Drawing.Point(1218, 6);
            this.txtFiltreNom.Name = "txtFiltreNom";
            this.txtFiltreNom.Size = new System.Drawing.Size(240, 32);
            this.txtFiltreNom.TabIndex = 13;
            this.txtFiltreNom.TextChanged += new System.EventHandler(this.txtFiltreNom_TextChanged);
            // 
            // btnResetFiltre
            // 
            this.btnResetFiltre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnResetFiltre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetFiltre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetFiltre.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnResetFiltre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.btnResetFiltre.Location = new System.Drawing.Point(1218, 48);
            this.btnResetFiltre.Name = "btnResetFiltre";
            this.btnResetFiltre.Size = new System.Drawing.Size(240, 38);
            this.btnResetFiltre.TabIndex = 14;
            this.btnResetFiltre.Text = "✖  Réinitialiser filtres";
            this.btnResetFiltre.UseVisualStyleBackColor = false;
            this.btnResetFiltre.Click += new System.EventHandler(this.btnResetFiltre_Click);
            // 
            // flpAlien
            // 
            this.flpAlien.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpAlien.AutoScroll = true;
            this.flpAlien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.flpAlien.Location = new System.Drawing.Point(10, 164);
            this.flpAlien.Name = "flpAlien";
            this.flpAlien.Size = new System.Drawing.Size(1487, 865);
            this.flpAlien.TabIndex = 2;
            // 
            // volet5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.pnlContenu);
            this.Controls.Add(this.pnlSidebar);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1918, 1030);
            this.Name = "volet5";
            this.Text = "Stargate — Volet 5 : Races extraterrestres";
            this.Load += new System.EventHandler(this.volet6_Load);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlContenu.ResumeLayout(false);
            this.pnlFiltres.ResumeLayout(false);
            this.pnlFiltres.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label lblSidebarTitre;
        private System.Windows.Forms.Panel pnlSidebarSep;
        private System.Windows.Forms.Panel pnlContenu;
        private System.Windows.Forms.Label lblTitreVolet;
        private System.Windows.Forms.Panel pnlFiltres;
        private System.Windows.Forms.CheckBox chkEnemis;
        private System.Windows.Forms.CheckBox chkAlliés;
        private System.Windows.Forms.FlowLayoutPanel flpAlien;
        private System.Windows.Forms.ComboBox cboInstrument;
        private System.Windows.Forms.ComboBox cboArme;
        private System.Windows.Forms.ComboBox cboCouleur;
        private System.Windows.Forms.ComboBox cboDegresBienveillance;
        private System.Windows.Forms.Label lblCouleur;
        private System.Windows.Forms.Label lblBien;
        private System.Windows.Forms.Label lblAgro;
        private System.Windows.Forms.ComboBox cboDegresAgressivité;
        private System.Windows.Forms.Button btnResetFiltre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTriePlanete;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtFiltreNom;
    }
}
