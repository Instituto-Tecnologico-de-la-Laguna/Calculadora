using Calculadora;
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

namespace Aplicacion2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent(); 
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calcuadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 suma = new Form2();
            suma.Show();
        }

        private void holaMundoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 hola = new Form1();
            hola.Show();
        }

        private void temporizadorToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Form3 temporizador = new Form3();
            temporizador.Show();
        }

        private void editorDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditor editor = new FrmEditor();
            editor.Show();  
        }

        private void agendaTeléfonoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgenda agenda = new frmAgenda(); 
            agenda.Show();  
        }

        private void variosComponentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVarios varios = new FrmVarios();
            varios.Show();  
        }

        private void hilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHilos formHilos = new FrmHilos();    
            formHilos.Show();   
        }

        private void hilos2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHilos2 formHilos2= new FrmHilos2();
            formHilos2.Show();
        }
    }
}
