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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tu nombre es:" + Nombre.Text, "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {

                MessageBox.Show("Tu nombre es correcto", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                Nombre.Clear();
                Nombre.Focus();
            }
            else

            {
                this.Close();

            }
        }
    }
}