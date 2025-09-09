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
    public partial class frmVarios : Form
    {
        public frmVarios()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int numero = 0;
            if (chBit1.Checked)
                numero = numero + 1;
            if (chBit2.Checked)
                numero = numero + 2;
            if (chBit3.Checked)
                numero = numero + 4;
            if (chBit4.Checked)
                numero = numero + 8;
            MessageBox.Show("El numero es: " + numero.ToString(), "Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            String x;
            if (rbdHombre.Checked) x = "Hombre"; else x = "Mujer";
            MessageBox.Show("Selecciono: " + x);
            
        }

        private void cmbColores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
