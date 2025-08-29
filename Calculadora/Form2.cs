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
            int v1, v2, resultado;
            v1 = Convert.ToInt32(txtV1.Text);
            v2 = int.Parse(txtV2.Text);
            resultado = v1 + v2;
            MessageBox.Show("El resultado es: "+resultado.ToString(),"Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtV1.Clear();
            txtV2.Clear();
            txtV1.Focus();
        }
    }
}
