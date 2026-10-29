namespace StargateControlLibrary
{
    partial class MissionCard
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picCardMiss = new System.Windows.Forms.PictureBox();
            this.lblCardMissName = new System.Windows.Forms.Label();
            this.grpCardMissInfo = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblCardMissDateDep = new System.Windows.Forms.Label();
            this.lblCardMissDateRet = new System.Windows.Forms.Label();
            this.lblCardMissBudget = new System.Windows.Forms.Label();
            this.lblCardMissBudgetDep = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtCardMissFeuilleObj = new System.Windows.Forms.TextBox();
            this.lblMissCardOBject = new System.Windows.Forms.Label();
            this.flpMissCardMembre = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMissCardListeMemb = new System.Windows.Forms.Label();
            this.lblMissCardAvObjCap = new System.Windows.Forms.Label();
            this.ltbMissCardCapObj = new System.Windows.Forms.ListBox();
            this.btnMissCardJournaux = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picCardMiss)).BeginInit();
            this.grpCardMissInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCardMiss
            // 
            this.picCardMiss.Location = new System.Drawing.Point(19, 17);
            this.picCardMiss.Name = "picCardMiss";
            this.picCardMiss.Size = new System.Drawing.Size(108, 97);
            this.picCardMiss.TabIndex = 0;
            this.picCardMiss.TabStop = false;
            // 
            // lblCardMissName
            // 
            this.lblCardMissName.AutoSize = true;
            this.lblCardMissName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCardMissName.Location = new System.Drawing.Point(175, 56);
            this.lblCardMissName.Name = "lblCardMissName";
            this.lblCardMissName.Size = new System.Drawing.Size(0, 20);
            this.lblCardMissName.TabIndex = 1;
            // 
            // grpCardMissInfo
            // 
            this.grpCardMissInfo.Controls.Add(this.btnMissCardJournaux);
            this.grpCardMissInfo.Controls.Add(this.ltbMissCardCapObj);
            this.grpCardMissInfo.Controls.Add(this.lblMissCardAvObjCap);
            this.grpCardMissInfo.Controls.Add(this.lblMissCardListeMemb);
            this.grpCardMissInfo.Controls.Add(this.flpMissCardMembre);
            this.grpCardMissInfo.Controls.Add(this.lblMissCardOBject);
            this.grpCardMissInfo.Controls.Add(this.txtCardMissFeuilleObj);
            this.grpCardMissInfo.Controls.Add(this.lblCardMissBudgetDep);
            this.grpCardMissInfo.Controls.Add(this.lblCardMissBudget);
            this.grpCardMissInfo.Controls.Add(this.lblCardMissDateRet);
            this.grpCardMissInfo.Controls.Add(this.lblCardMissDateDep);
            this.grpCardMissInfo.Location = new System.Drawing.Point(19, 144);
            this.grpCardMissInfo.Name = "grpCardMissInfo";
            this.grpCardMissInfo.Size = new System.Drawing.Size(383, 441);
            this.grpCardMissInfo.TabIndex = 2;
            this.grpCardMissInfo.TabStop = false;
            this.grpCardMissInfo.Text = "Information de la mission :";
            // 
            // lblCardMissDateDep
            // 
            this.lblCardMissDateDep.AutoSize = true;
            this.lblCardMissDateDep.Location = new System.Drawing.Point(7, 38);
            this.lblCardMissDateDep.Name = "lblCardMissDateDep";
            this.lblCardMissDateDep.Size = new System.Drawing.Size(0, 13);
            this.lblCardMissDateDep.TabIndex = 0;
            // 
            // lblCardMissDateRet
            // 
            this.lblCardMissDateRet.AutoSize = true;
            this.lblCardMissDateRet.Location = new System.Drawing.Point(7, 70);
            this.lblCardMissDateRet.Name = "lblCardMissDateRet";
            this.lblCardMissDateRet.Size = new System.Drawing.Size(0, 13);
            this.lblCardMissDateRet.TabIndex = 1;
            // 
            // lblCardMissBudget
            // 
            this.lblCardMissBudget.AutoSize = true;
            this.lblCardMissBudget.Location = new System.Drawing.Point(209, 37);
            this.lblCardMissBudget.Name = "lblCardMissBudget";
            this.lblCardMissBudget.Size = new System.Drawing.Size(0, 13);
            this.lblCardMissBudget.TabIndex = 2;
            // 
            // lblCardMissBudgetDep
            // 
            this.lblCardMissBudgetDep.AutoSize = true;
            this.lblCardMissBudgetDep.Location = new System.Drawing.Point(209, 70);
            this.lblCardMissBudgetDep.Name = "lblCardMissBudgetDep";
            this.lblCardMissBudgetDep.Size = new System.Drawing.Size(0, 13);
            this.lblCardMissBudgetDep.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtCardMissFeuilleObj
            // 
            this.txtCardMissFeuilleObj.Location = new System.Drawing.Point(6, 115);
            this.txtCardMissFeuilleObj.Multiline = true;
            this.txtCardMissFeuilleObj.Name = "txtCardMissFeuilleObj";
            this.txtCardMissFeuilleObj.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCardMissFeuilleObj.Size = new System.Drawing.Size(371, 88);
            this.txtCardMissFeuilleObj.TabIndex = 4;
            // 
            // lblMissCardOBject
            // 
            this.lblMissCardOBject.AutoSize = true;
            this.lblMissCardOBject.Location = new System.Drawing.Point(10, 96);
            this.lblMissCardOBject.Name = "lblMissCardOBject";
            this.lblMissCardOBject.Size = new System.Drawing.Size(138, 13);
            this.lblMissCardOBject.TabIndex = 5;
            this.lblMissCardOBject.Text = "Objectifs et feuille de route :";
            // 
            // flpMissCardMembre
            // 
            this.flpMissCardMembre.AutoScroll = true;
            this.flpMissCardMembre.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMissCardMembre.Location = new System.Drawing.Point(6, 247);
            this.flpMissCardMembre.Name = "flpMissCardMembre";
            this.flpMissCardMembre.Size = new System.Drawing.Size(371, 88);
            this.flpMissCardMembre.TabIndex = 6;
            // 
            // lblMissCardListeMemb
            // 
            this.lblMissCardListeMemb.AutoSize = true;
            this.lblMissCardListeMemb.Location = new System.Drawing.Point(6, 228);
            this.lblMissCardListeMemb.Name = "lblMissCardListeMemb";
            this.lblMissCardListeMemb.Size = new System.Drawing.Size(100, 13);
            this.lblMissCardListeMemb.TabIndex = 7;
            this.lblMissCardListeMemb.Text = "Liste des membres :";
            // 
            // lblMissCardAvObjCap
            // 
            this.lblMissCardAvObjCap.AutoSize = true;
            this.lblMissCardAvObjCap.Location = new System.Drawing.Point(3, 355);
            this.lblMissCardAvObjCap.Name = "lblMissCardAvObjCap";
            this.lblMissCardAvObjCap.Size = new System.Drawing.Size(182, 13);
            this.lblMissCardAvObjCap.TabIndex = 8;
            this.lblMissCardAvObjCap.Text = "Avancees des objectifs de captures :";
            // 
            // ltbMissCardCapObj
            // 
            this.ltbMissCardCapObj.FormattingEnabled = true;
            this.ltbMissCardCapObj.Location = new System.Drawing.Point(6, 372);
            this.ltbMissCardCapObj.Name = "ltbMissCardCapObj";
            this.ltbMissCardCapObj.Size = new System.Drawing.Size(281, 56);
            this.ltbMissCardCapObj.TabIndex = 9;
            // 
            // btnMissCardJournaux
            // 
            this.btnMissCardJournaux.Location = new System.Drawing.Point(293, 383);
            this.btnMissCardJournaux.Name = "btnMissCardJournaux";
            this.btnMissCardJournaux.Size = new System.Drawing.Size(84, 34);
            this.btnMissCardJournaux.TabIndex = 10;
            this.btnMissCardJournaux.Text = "Afficher les journaux";
            this.btnMissCardJournaux.UseVisualStyleBackColor = true;
            // 
            // MissionCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpCardMissInfo);
            this.Controls.Add(this.lblCardMissName);
            this.Controls.Add(this.picCardMiss);
            this.Name = "MissionCard";
            this.Size = new System.Drawing.Size(422, 604);
            ((System.ComponentModel.ISupportInitialize)(this.picCardMiss)).EndInit();
            this.grpCardMissInfo.ResumeLayout(false);
            this.grpCardMissInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCardMiss;
        private System.Windows.Forms.Label lblCardMissName;
        private System.Windows.Forms.GroupBox grpCardMissInfo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblCardMissBudgetDep;
        private System.Windows.Forms.Label lblCardMissBudget;
        private System.Windows.Forms.Label lblCardMissDateRet;
        private System.Windows.Forms.Label lblCardMissDateDep;
        private System.Windows.Forms.Label lblMissCardOBject;
        private System.Windows.Forms.TextBox txtCardMissFeuilleObj;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblMissCardListeMemb;
        private System.Windows.Forms.FlowLayoutPanel flpMissCardMembre;
        private System.Windows.Forms.Button btnMissCardJournaux;
        private System.Windows.Forms.ListBox ltbMissCardCapObj;
        private System.Windows.Forms.Label lblMissCardAvObjCap;
    }
}
