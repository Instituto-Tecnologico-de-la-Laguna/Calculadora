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
    public partial class Editor : Form
    {
        public Editor()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult abrir;
            abrir = oofdAbrir.ShowDialog();

            if (abrir == DialogResult.OK)
            {
                //rtbEditor.LoadFile(oofAbrir.FileName,RichTextBoxStreamType.PlainText);
                string texto = File.ReadAllText(oofdAbrir.FileName);
                rtbEditor.Text = texto;
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            oofdAbrir.ShowDialog();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdGuardar.ShowDialog();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
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
