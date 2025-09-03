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
    public partial class fmrEnviar : Form
    {
        public fmrEnviar()
        {
            InitializeComponent();
        }

        private void bttEnviar_Click(object sender, EventArgs e)
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
