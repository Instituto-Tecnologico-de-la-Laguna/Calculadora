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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
            num1 = Convert.ToInt32(Valor1.Text);
            num2 = int.Parse(Valor2.Text);
            resultado = num1 + num2;

            MessageBox.Show("El resultado es = " + resultado.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Valor1.Clear();
            Valor2.Clear();
            Valor1.Focus();
        }
    }
}
