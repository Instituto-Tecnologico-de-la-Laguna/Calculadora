using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class fmrSuma : Form
    {
        public fmrSuma()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void ButtCalcular_Click(object sender, EventArgs e)
        {
            decimal numero1, numero2, resultado;
            try
            {


                numero1 = Convert.ToDecimal(textNum1.Text);
                numero2 = decimal.Parse(textNum2.Text);
                resultado = numero1 + numero2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message,
                    "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("El resultado es: " + resultado.ToString(),
                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textNum1.Clear();
            textNum2.Clear();
            textNum1.Focus();
        }
    }
}
