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
    public partial class rfmMenu : Form
    {
        public rfmMenu()
        {
            InitializeComponent();
        }

        private void temporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 f3=new Form3();
            f3.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sumaDe2NumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2=new Form2();
            f2.Show();
        }

        private void helloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1=new Form1();
            f1.Show();
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frnEditor editor=new frnEditor();
            editor.Show();
        }

        private void agendaTelefonicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frnAgenda agenda=new frnAgenda();
            agenda.Show();
        }
    }
}
