using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Calculadora
{
    public partial class FrmTimers : Form
    {
        string resultado;
        public FrmTimers()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TmrHora_Tick(object sender, EventArgs e)
        {
            //LblHora.Text = DateTime.Now.ToLongTimeString();
            //LblHora.Text = DateTime.Now.ToShortTimeString();
            LblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            if (LblHora.Text == resultado)
            {
                MessageBox.Show("Se ejecuta el proceso", "Alarma", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void BtnAlarma_Click(object sender, EventArgs e)
        {
            resultado = Interaction.InputBox("Ingrese la hora para la alarma (HH:mm:ss):",
                "Alarma", "00:00:00");
        }
    }
}
