
namespace WinformEditeurTxt
{
    partial class FrmEditeur
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtbAffiche = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbAffiche
            // 
            this.rtbAffiche.Location = new System.Drawing.Point(13, 50);
            this.rtbAffiche.Margin = new System.Windows.Forms.Padding(4);
            this.rtbAffiche.Name = "rtbAffiche";
            this.rtbAffiche.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbAffiche.Size = new System.Drawing.Size(1041, 450);
            this.rtbAffiche.TabIndex = 0;
            this.rtbAffiche.Text = "Veuillez écrire ici ...";
            this.rtbAffiche.TextChanged += new System.EventHandler(this.RichTextBoxEditeur_TextChanged);
            // 
            // FrmEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rtbAffiche);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditeur";
            this.Text = "MonPetitEditeur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAffiche;
    }
}

