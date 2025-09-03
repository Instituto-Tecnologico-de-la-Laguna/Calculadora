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
    public partial class RFM_EDITORcs : Form
    {

        public RFM_EDITORcs()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult abrir;
            openFileDialog1.ShowDialog();
            abrir = openFileDialog1.ShowDialog();
            if (abrir == DialogResult.OK)
            {

                string texto = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void guardarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult guardar;
            saveFileDialog1.ShowDialog();
            if(guardar == DialogResult.OK && guardado == false) {
                rtbEditor.SaveFile(sfGuardar.FileName,
                    RichTextBoxStreamType.PlainText);
        }
    }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(guardado == false) {
                if(sfGuardar.showDialog)
        }
    }
