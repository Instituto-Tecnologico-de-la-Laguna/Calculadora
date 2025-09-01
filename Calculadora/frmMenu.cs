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
            Form3 temporizador=new Form3();
            temporizador.Show();
        }

        private void sumaDe2NumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 sumaDe2Numeros=new Form2();
            sumaDe2Numeros.Show();
        }

        private void helloWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 helloWord=new Form1();
            helloWord.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
