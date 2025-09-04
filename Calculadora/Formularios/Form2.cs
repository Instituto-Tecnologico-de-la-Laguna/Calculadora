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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                decimal num1, num2, resultado;

                num1 = Convert.ToDecimal(txtValor1.Text);
                num2 = decimal.Parse(txtValor2.Text);
                resultado = num1 + num2;
                MessageBox.Show("El resultado es: " + resultado.ToString(),
                    "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtValor1.Clear();
                txtValor2.Clear();
                txtValor1.Focus();
            }
            catch (Exception ex) {
                MessageBox.Show("Error: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
        }
    }
}
