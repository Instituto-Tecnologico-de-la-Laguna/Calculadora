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

        private void btCalcular_Click(object sender, EventArgs e)
        {
            int numero1, numero2, resultado;
            numero1 = Convert.ToInt32(tbValor1.Text);
            numero2 = int.Parse(tbValor2.Text);

            resultado = numero1 + numero2;

            MessageBox.Show("El resultado es: " + resultado.ToString(), "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            tbValor1.Clear();
            tbValor2.Clear();
            tbValor1.Focus();
        }
    }
}
