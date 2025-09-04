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
                rtbEditor.LoadFile(ofdAbrir.FileName,RichTextBoxStreamType.PlainText);

                //string texto = File.ReadAllText(ofdAbrir.FileName);
                //rbtEditor.Text = Text;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtbEditor.Clear();
            guardado = false;
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void appsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult guardar;
            if (guardado == false)
            {   
                if(sfdGuardar.ShowDialog() == DialogResult.OK)
                {
                    rtbEditor.SaveFile(sfdGuardar.FileName,RichTextBoxStreamType.PlainText);
                    guardado = true;
                }
            }
            else
            {
                rtbEditor.SaveFile(sfdGuardar.FileName, RichTextBoxStreamType.PlainText);
            }
                sfdGuardar.ShowDialog();
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sfdGuardar.ShowDialog() == DialogResult.OK)
            {
                rtbEditor.SaveFile(sfdGuardar.FileName, RichTextBoxStreamType.PlainText);
                guardado=true;
            }

            
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fuenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog font = new FontDialog();
            if (font.ShowDialog()==DialogResult.OK)
            {
                rtbEditor.Font = font.Font;
            }
            
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
                rtbEditor.ForeColor = color.Color;
           
        }
    }
}
