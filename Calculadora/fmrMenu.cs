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
    public partial class fmrMenu : Form
    {

        public fmrMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void temporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrTimers temporizador = new fmrTimers();
            temporizador.Show();
        }

        private void sumaDeDosNumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrSuma suma = new fmrSuma();
            suma.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void enviarMensajeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmrEnviar helloWord = new fmrEnviar();
            helloWord.Show();
                
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FmrEditor edit=new FmrEditor();
            edit.Show();
        }
    }
}
