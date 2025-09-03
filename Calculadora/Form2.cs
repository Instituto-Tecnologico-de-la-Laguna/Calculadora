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

        private void sumarval_Click(object sender, EventArgs e)
        {
            decimal numero1, numero2, resultado;

            try
            {
                numero1 = Convert.ToDecimal(textValor1.Text);
                numero2 = decimal.Parse(textValor2.Text);

                resultado = numero1 + numero2;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("El resultado es: " + resultado.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            textValor1.Clear(); 
            textValor2.Clear();
            textValor1.Focus();

        }
    }
}
