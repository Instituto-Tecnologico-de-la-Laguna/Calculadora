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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numero1, numero2, resultado;

            numero1 = Convert.ToInt32(Valor1.Text);
            numero2 = int.Parse(Valor2.Text);

            resultado = numero1 + numero2;

            MessageBox.Show("El restlado es: " + resultado.ToString(),
                "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Valor1.Clear();
            Valor2.Clear(); 
            Valor1.Focus();

        }
    }
}
