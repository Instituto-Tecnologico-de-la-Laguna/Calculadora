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

        private void butMensaje_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tu Nombre es " + txtNombre.Text, "Sistemas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Tu Nombre es correcto", "Sistemas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtNombre.Focus();
            }
            else
            {
                this.Close();

            }
        }
    }
}
