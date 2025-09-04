using System;
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
            DialogResult resultado = MessageBox.Show("Tu nombre es: " + txtNombre.Text, "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Tu nombre es correcto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
