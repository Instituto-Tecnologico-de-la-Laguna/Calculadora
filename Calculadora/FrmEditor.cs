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
        bool guardado = false;
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
                rTBEditor.LoadFile(oFDAbrir.FileName,
                    RichTextBoxStreamType.PlainText);
            }
            /*if (oFDAbrir.ShowDialog() == DialogResult.OK)
            {

                String rutaArch = oFDAbrir.FileName;

                try
                {
                    String texto = File.ReadAllText(rutaArch);

                    rTBEditor.Text = texto;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }
            }*/
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult guardar;
            if (guardado == false)
            {
                if (sFDGuardar.ShowDialog() == DialogResult.OK)
                {
                    rTBEditor.SaveFile(sFDGuardar.FileName, RichTextBoxStreamType.PlainText);
                    guardado = true;
                }

            }
            else
            {
                rTBEditor.SaveFile(sFDGuardar.FileName, RichTextBoxStreamType.PlainText);
            }


        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTBEditor.Clear();
            guardado = false;
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fDFuente.ShowDialog();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cDColor.ShowDialog();  
        }
    }
}
