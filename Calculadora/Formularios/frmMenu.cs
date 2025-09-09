using Calculadora.Formularios;
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
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void temporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimers temporizador= new frmTimers();
            temporizador.Show();
        }

        private void sumaDe2NumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 suma = new Form2();
            suma.Show();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 hello= new Form1();   
            hello.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor editor = new frmEditor();
            editor.Show();
        }

        private void agendaTelefonicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda agenda = new frmAgenda();
            agenda.Show();
        }

        private void variosComponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVarios varios = new frmVarios();
            varios.Show();
        }
    }
}
