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
    public partial class frmEditor : Form
    {
        public frmEditor()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult abrir;
            abrir = ofdAbrir.ShowDialog();
            if (abrir == DialogResult.OK)
            {
                rbtEditor.LoadFile(ofdAbrir.FileName,RichTextBoxStreamType.PlainText);

                string texto = File.ReadAllText(ofdAbrir.FileName);
                rbtEditor.Text = Text;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbtEditor.Clear();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdGuardar.ShowDialog();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdGuardar.ShowDialog();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
