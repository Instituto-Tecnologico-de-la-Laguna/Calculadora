using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class FrmVarios : Form
    {
        public FrmVarios()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int numero = 0;
            if (chBBit1.Checked)
            {
                numero = numero + 1;
            }
            if (chBBit2.Checked)
            {
                numero = numero + 2;
            }
            if (chBBit3.Checked)
            {
                numero = numero + 4;
            }
            if (chBBit4.Checked)
            {
                numero = numero + 8;
            }

            MessageBox.Show("El número es: "+numero.ToString(), "Sistema", MessageBoxButtons.OK,MessageBoxIcon.Information);

            String x;
            if (rdBHombre.Checked) x = "Hombre"; else x = "Mujer";

            
        }
    }
}
