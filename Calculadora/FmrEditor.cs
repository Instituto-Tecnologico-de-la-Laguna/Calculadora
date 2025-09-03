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
    public partial class FmrEditor : Form
    {
        public FmrEditor()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult abrir;
            abrir=opfAbrir.ShowDialog();
            if (abrir==DialogResult.OK)
            {
                
                String texto = File.ReadAllText(opfAbrir.FileName);
                rtbEditor.Text = texto;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            svdGuardar.ShowDialog();

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
