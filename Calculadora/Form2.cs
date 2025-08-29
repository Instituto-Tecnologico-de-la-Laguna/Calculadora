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
            int numero1, numero2, resultado;
            numero1 = Convert.ToInt32(textValor1.Text);   
            numero2 = int.Parse(textValor2.Text);

            resultado = numero1 + numero2;
            MessageBox.Show("El resultado de la suma es: " + resultado.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            textValor1.Clear(); 
            textValor2.Clear();
            textValor1.Focus();

        }
    }
}
