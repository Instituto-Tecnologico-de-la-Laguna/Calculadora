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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v1, v2, res;
            v1 = int.Parse(txtValor1.Text);
            v2 = int.Parse(txtValor2.Text);

            res = v1 + v2;

            MessageBox.Show("El Resultado es: " + res, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtValor1.Clear();
            txtValor2.Clear();
            txtValor1.Focus();

        }
    }
}
