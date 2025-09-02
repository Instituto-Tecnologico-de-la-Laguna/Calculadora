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
    public partial class FRMEditor : Form
    {
        public FRMEditor()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult abrir;
           abrir = ofdAbrir.ShowDialog();
            if(abrir == DialogResult.OK)
            {
                rtbEditor.LoadFile(ofdAbrir.FileName, RichTextBoxStreamType.PlainText);
               /*string texto = File.ReadAllText(ofdAbrir.FileName);
                rtbEditor.Text = texto;*/
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdGuardar.ShowDialog();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdGuardar.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
        }
    }
}
