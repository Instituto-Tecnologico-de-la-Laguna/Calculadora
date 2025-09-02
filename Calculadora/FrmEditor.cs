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
    public partial class FrmEditor : Form
    {
        public FrmEditor()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult abrir;
            abrir = oFDAbrir.ShowDialog();
            if (abrir == DialogResult.OK)
            {
                String texto = File.ReadAllText(oFDAbrir.FileName);
                rTBEditor.Text = texto;
            }

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sFDGuardar.ShowDialog();  
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBEditor.Clear();
        }
    }
}
