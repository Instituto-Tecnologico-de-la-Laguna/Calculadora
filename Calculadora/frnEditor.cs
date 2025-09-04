using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Calculadora
{
    public partial class frnEditor : Form
    {
        bool guardado = false;
        public frnEditor()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult abrir;
            abrir=OfdAbrir.ShowDialog();

            if (abrir==DialogResult.OK)
            {
                String texto=File.ReadAllText(OfdAbrir.FileName);
                richTextBox1.Text= texto;
            }

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult guardar;
            if (guardado==false)
            {
                if (sfdGuardar.ShowDialog()==DialogResult.OK)
                {
                    richTextBox1.SaveFile(sfdGuardar.FileName, RichTextBoxStreamType.PlainText);
                    guardado = true;
                }

            }
            else
            {
                richTextBox1.SaveFile(sfdGuardar.FileName,RichTextBoxStreamType.PlainText);
            }
                
        
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }
    }
}
