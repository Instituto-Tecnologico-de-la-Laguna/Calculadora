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
        bool guardado = false;
        public frmEditor()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult abrir;
            abrir = sfdAbrir.ShowDialog();
            if (abrir == DialogResult.OK)
            {
                String texto = File.ReadAllText(sfdAbrir.FileName);
                rbEditor.Text = texto;
            }

            //Investigar que es un archivo jason
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult guardar;
            //guardar = sfdGuardar.ShowDialog();
            if(guardado == false)
            {
                if(sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    rbEditor.SaveFile(sfdGuardar.FileName, RichTextBoxStreamType.PlainText);
                    guardado = true;
                } 
            }
            else
            {
                rbEditor.SaveFile(sfdGuardar.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbEditor.Clear();
            guardado = false;
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult guardar;

            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                rbEditor.SaveFile(sfdGuardar.FileName, RichTextBoxStreamType.PlainText);
                guardado = true;
            }
        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fdFuente.ShowDialog();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cdColor.ShowDialog();
        }
    }
}
