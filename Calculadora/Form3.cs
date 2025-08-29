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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BOTONSUMAR_Click(object sender, EventArgs e) { 
        
            //crear variables
            int numero1, numero2, resukltado;
            numero1 = Convert.ToInt32(txtvalor1.Text);
            numero2 = Convert.ToInt32(txtValor2.Text);
            resukltado = numero1 + numero2;
            MessageBox.Show("el resultado es " + resukltado.ToString(), "sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtvalor1.Clear();
            txtValor2.Clear();
            txtvalor1.Focus();
        
        }
    }
}
