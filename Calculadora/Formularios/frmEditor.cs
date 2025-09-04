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
        bool isSaved = false;
        string direccionArchivo = "";
        //\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\
        public frmEditor()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)//Abrir
        {
            DialogResult abrir;
            abrir = ofdOpen.ShowDialog();

            if (abrir == DialogResult.OK)
            {
                //rtbEditor.LoadFile(ofdOpen.FileName, RichTextBoxStreamType.PlainText); /\/\/\/\/\/\/\/\/\ Opcion de copilot
                string texto = File.ReadAllText(ofdOpen.FileName);
                rtbEditor.Text = texto;
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)//Guardar
        {
            if (isSaved == false)
            {
                DialogResult guardar = sfdSave.ShowDialog();
                if (guardar == DialogResult.OK)
                {
                    rtbEditor.SaveFile(sfdSave.FileName, RichTextBoxStreamType.PlainText);
                    isSaved = true;
                    direccionArchivo = sfdSave.FileName;
                }   
            }
            else rtbEditor.SaveFile(direccionArchivo, RichTextBoxStreamType.PlainText);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)//Guardar Como
        {
            DialogResult guardar = sfdSave.ShowDialog();
            if (guardar == DialogResult.OK)
            {
                rtbEditor.SaveFile(sfdSave.FileName, RichTextBoxStreamType.PlainText);
                isSaved = true;
                direccionArchivo = sfdSave.FileName;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)//Salir
        {
            this.Close();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)//Nuevo
        {
            rtbEditor.Clear();
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)//Imprimir
        {
            //wip (work in progress)
        }
        //Editar/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/
        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)//Fuente
        {
            fdFuente.ShowDialog();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)//Color
        {
            cdColor.ShowDialog();
        }
    }
}
