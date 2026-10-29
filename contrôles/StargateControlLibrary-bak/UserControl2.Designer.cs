namespace StargateControlLibrary
{
    partial class TrombiPerso
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
            this.picTrombiPerso = new System.Windows.Forms.PictureBox();
            this.lblTrombiPersoNom = new System.Windows.Forms.Label();
            this.lblTrombiPersoPrenom = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picTrombiPerso)).BeginInit();
            this.SuspendLayout();
            // 
            // picTrombiPerso
            // 
            this.picTrombiPerso.Location = new System.Drawing.Point(19, 12);
            this.picTrombiPerso.Name = "picTrombiPerso";
            this.picTrombiPerso.Size = new System.Drawing.Size(118, 81);
            this.picTrombiPerso.TabIndex = 0;
            this.picTrombiPerso.TabStop = false;
            // 
            // lblTrombiPersoNom
            // 
            this.lblTrombiPersoNom.AutoSize = true;
            this.lblTrombiPersoNom.Location = new System.Drawing.Point(61, 117);
            this.lblTrombiPersoNom.Name = "lblTrombiPersoNom";
            this.lblTrombiPersoNom.Size = new System.Drawing.Size(0, 13);
            this.lblTrombiPersoNom.TabIndex = 1;
            // 
            // lblTrombiPersoPrenom
            // 
            this.lblTrombiPersoPrenom.AutoSize = true;
            this.lblTrombiPersoPrenom.Location = new System.Drawing.Point(61, 151);
            this.lblTrombiPersoPrenom.Name = "lblTrombiPersoPrenom";
            this.lblTrombiPersoPrenom.Size = new System.Drawing.Size(0, 13);
            this.lblTrombiPersoPrenom.TabIndex = 2;
            // 
            // TrombiPerso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTrombiPersoPrenom);
            this.Controls.Add(this.lblTrombiPersoNom);
            this.Controls.Add(this.picTrombiPerso);
            this.Name = "TrombiPerso";
            this.Size = new System.Drawing.Size(157, 190);
            ((System.ComponentModel.ISupportInitialize)(this.picTrombiPerso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picTrombiPerso;
        private System.Windows.Forms.Label lblTrombiPersoNom;
        private System.Windows.Forms.Label lblTrombiPersoPrenom;
    }
}
