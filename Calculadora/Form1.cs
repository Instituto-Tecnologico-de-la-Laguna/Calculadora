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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
                resultado = MessageBox.Show("Tu nombre es: " + txtNombre.Text, "sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(resultado == DialogResult.OK)
            {
                MessageBox.Show("Tu nombre es correcto", "Sistemas", MessageBoxButtons.OK);
                txtNombre.Clear();
                txtNombre.Focus();
            }
            else
            {
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
