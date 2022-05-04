using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformEditeurTxt
{
    public partial class FrmEditeur : Form
    {
        public FrmEditeur()
        {
            InitializeComponent();
        }

        private void RichTextBoxEditeur_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void MnuQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copierToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void MnuOuvrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog MesFichier = new OpenFileDialog();
            MesFichier.DefaultExt = "*rtf";
            MesFichier.Filter = "Fichier TXT (*.txt)|*txt|Fichier RTF (*.rtf)|*.retf";
            MesFichier.FileName = "";
            MesFichier.ShowDialog();
        }

        private void MnuEnregistrerSous_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveAs = new SaveFileDialog();
            SaveAs.DefaultExt = "*txt";
            SaveAs.Filter = "Fichier TXT (*.txt)|*txt|Fichier RTF (*.rtf)|*.retf";
            SaveAs.FileName = "";
            SaveAs.CreatePrompt = true;
            SaveAs.OverwritePrompt = true;
            SaveAs.ShowDialog();

        }

        private void MnuAnnuler_Click(object sender, EventArgs e)
        {
            rtbAffiche.Undo();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbAffiche.Clear();
        }

        private void MnuCopier_Click(object sender, EventArgs e)
        {
            rtbAffiche.Copy();
        }

        private void MnuCouper_Click(object sender, EventArgs e)
        {
            rtbAffiche.Cut();
        }

        private void MnuColler_Click(object sender, EventArgs e)
        {
            rtbAffiche.Paste();
        }

        private void copierToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            rtbAffiche.Copy();
        }

        private void couperToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbAffiche.Cut();
        }

        private void collerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbAffiche.Paste();
        }
    }
}
