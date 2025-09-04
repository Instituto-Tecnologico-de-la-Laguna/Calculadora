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
    public partial class frmMenus : Form
    {
        public frmMenus()
        {
            InitializeComponent();
        }

        private void temporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTimers temporizador = new frmTimers();
            temporizador.Show();   
        }

        private void helloWorlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 hello = new Form1();
            hello.Show();
        }

        private void sumaDe2NumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 suma = new Form2();
            suma.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(":D?", "Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Me alegro que estes feliz :D", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Espero que tu dia mejore :(", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void workInProgressToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmMenus_Load(object sender, EventArgs e)
        {

        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditor editor = new frmEditor();
            editor.Show();
        }

        private void agendaTelefonicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda agenda = new frmAgenda();
            agenda.Show();
        }
    }
}
