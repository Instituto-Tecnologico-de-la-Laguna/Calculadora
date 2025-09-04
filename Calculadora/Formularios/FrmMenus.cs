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
    public partial class FrmMenus : Form
    {
        public FrmMenus()
        {
            InitializeComponent();
        }

        private void temporizadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTimers temporizador = new FrmTimers();
            temporizador.Show();
        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 suma = new Form2();
            suma.Show();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 helloWorld = new Form1();
            helloWorld.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FRMEditor editor = new FRMEditor();
            editor.Show();
        }

        private void agendaTelefonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgenda agenda = new FrmAgenda();
            agenda.Show();
        }
    }
}
