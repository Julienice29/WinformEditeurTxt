
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
            this.components = new System.ComponentModel.Container();
            this.rtbAffiche = new System.Windows.Forms.RichTextBox();
            this.MnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEnregistrerSous = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuEdition = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuAnnuler = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuRétablir = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuColler = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmsCopier = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmsCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.copierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MnuPrincipal.SuspendLayout();
            this.CmsCopier.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbAffiche
            // 
            this.rtbAffiche.Location = new System.Drawing.Point(13, 48);
            this.rtbAffiche.Margin = new System.Windows.Forms.Padding(4);
            this.rtbAffiche.Name = "rtbAffiche";
            this.rtbAffiche.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbAffiche.Size = new System.Drawing.Size(1041, 450);
            this.rtbAffiche.TabIndex = 0;
            this.rtbAffiche.Text = "Veuillez écrire ici ...";
            this.rtbAffiche.TextChanged += new System.EventHandler(this.RichTextBoxEditeur_TextChanged);
            // 
            // MnuPrincipal
            // 
            this.MnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.MnuEdition});
            this.MnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MnuPrincipal.Name = "MnuPrincipal";
            this.MnuPrincipal.Size = new System.Drawing.Size(1067, 30);
            this.MnuPrincipal.TabIndex = 1;
            this.MnuPrincipal.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuOuvrir,
            this.MnuEnregistrerSous,
            this.MnuQuitter});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // MnuOuvrir
            // 
            this.MnuOuvrir.Name = "MnuOuvrir";
            this.MnuOuvrir.Size = new System.Drawing.Size(198, 26);
            this.MnuOuvrir.Text = "Ouvrir";
            // 
            // MnuEnregistrerSous
            // 
            this.MnuEnregistrerSous.Name = "MnuEnregistrerSous";
            this.MnuEnregistrerSous.Size = new System.Drawing.Size(198, 26);
            this.MnuEnregistrerSous.Text = "Enregistrer Sous";
            // 
            // MnuQuitter
            // 
            this.MnuQuitter.Name = "MnuQuitter";
            this.MnuQuitter.Size = new System.Drawing.Size(198, 26);
            this.MnuQuitter.Text = "Quitter";
            this.MnuQuitter.Click += new System.EventHandler(this.MnuQuitter_Click);
            // 
            // MnuEdition
            // 
            this.MnuEdition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuAnnuler,
            this.MnuRétablir,
            this.MnuCopier,
            this.MnuCouper,
            this.MnuColler});
            this.MnuEdition.Name = "MnuEdition";
            this.MnuEdition.Size = new System.Drawing.Size(70, 24);
            this.MnuEdition.Text = "Edition";
            // 
            // MnuAnnuler
            // 
            this.MnuAnnuler.Name = "MnuAnnuler";
            this.MnuAnnuler.Size = new System.Drawing.Size(224, 26);
            this.MnuAnnuler.Text = "Annuler";
            // 
            // MnuRétablir
            // 
            this.MnuRétablir.Name = "MnuRétablir";
            this.MnuRétablir.Size = new System.Drawing.Size(224, 26);
            this.MnuRétablir.Text = "Rétablir";
            // 
            // MnuCopier
            // 
            this.MnuCopier.Name = "MnuCopier";
            this.MnuCopier.Size = new System.Drawing.Size(224, 26);
            this.MnuCopier.Text = "Copier";
            // 
            // MnuCouper
            // 
            this.MnuCouper.Name = "MnuCouper";
            this.MnuCouper.Size = new System.Drawing.Size(224, 26);
            this.MnuCouper.Text = "Couper";
            // 
            // MnuColler
            // 
            this.MnuColler.Name = "MnuColler";
            this.MnuColler.Size = new System.Drawing.Size(224, 26);
            this.MnuColler.Text = "Coller";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CmsCopier
            // 
            this.CmsCopier.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CmsCopier.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CmsCouper,
            this.copierToolStripMenuItem});
            this.CmsCopier.Name = "CmsCopier";
            this.CmsCopier.Size = new System.Drawing.Size(127, 52);
            // 
            // CmsCouper
            // 
            this.CmsCouper.Name = "CmsCouper";
            this.CmsCouper.Size = new System.Drawing.Size(126, 24);
            this.CmsCouper.Text = "Couper";
            // 
            // copierToolStripMenuItem
            // 
            this.copierToolStripMenuItem.Name = "copierToolStripMenuItem";
            this.copierToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.copierToolStripMenuItem.Text = "Copier";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.rtbAffiche);
            this.Controls.Add(this.MnuPrincipal);
            this.MainMenuStrip = this.MnuPrincipal;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEditeur";
            this.Text = "MonPetitEditeur";
            this.MnuPrincipal.ResumeLayout(false);
            this.MnuPrincipal.PerformLayout();
            this.CmsCopier.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAffiche;
        private System.Windows.Forms.MenuStrip MnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuOuvrir;
        private System.Windows.Forms.ToolStripMenuItem MnuEnregistrerSous;
        private System.Windows.Forms.ToolStripMenuItem MnuQuitter;
        private System.Windows.Forms.ToolStripMenuItem MnuEdition;
        private System.Windows.Forms.ToolStripMenuItem MnuAnnuler;
        private System.Windows.Forms.ToolStripMenuItem MnuRétablir;
        private System.Windows.Forms.ToolStripMenuItem MnuCopier;
        private System.Windows.Forms.ToolStripMenuItem MnuCouper;
        private System.Windows.Forms.ToolStripMenuItem MnuColler;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip CmsCopier;
        private System.Windows.Forms.ToolStripMenuItem CmsCouper;
        private System.Windows.Forms.ToolStripMenuItem copierToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

