using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmEditor : Form
    {
        bool guardado = false;
        public frmEditor()
        {
            InitializeComponent();
        }


        private void fuardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sfdGuardar.ShowDialog();
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.SaveFile(sfdGuardar.FileName, RichTextBoxStreamType.PlainText);
                guardado = true;
                /*string texto= rtbEditor.Text;
                 FileWriteAllText(sfdGuardar.FileName,texto);*/
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult abrir;
            abrir = ofdAbrir.ShowDialog();
            if (abrir == DialogResult.OK)
            {
                //rtbEditor.LoadFile(ofdAbrir.FileName,RichTextBoxStreamType.PlainText);
                string texto = File.ReadAllText(ofdAbrir.FileName);
                rtbEditor.Text = texto;

            }
        }

        private void nuevoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            guardado = false;
        }

        private void guardarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DialogResult guardar;

            if (guardado == false)
            {
                if (sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    rtbEditor.SaveFile(sfdGuardar.FileName, RichTextBoxStreamType.PlainText);
                    guardado = true;
                    /*string texto= rtbEditor.Text;
                     FileWriteAllText(sfdGuardar.FileName,texto);*/
                }
            }
            else
            {
                rtbEditor.SaveFile(sfdGuardar.FileName, RichTextBoxStreamType.PlainText);
            }

        }

        private void salirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fuenteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FdFUENTE.ShowDialog();
        }

        private void colorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            CDCOLOR.ShowDialog();

        }
    }
}
