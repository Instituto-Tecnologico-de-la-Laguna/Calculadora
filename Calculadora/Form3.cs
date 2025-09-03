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
    public partial class Temporizador : Form
    {
        string resultado;
        public Temporizador()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string resultado = Interaction.InputBox("Ingrese la hora para la alarma (hh:mm:ss)", "Alarma", "00:00:00");
        }


        private void label1_Click(object sender, EventArgs e)
        {
            //lblhora.Text = DateTime.Now.ToShortTimeString();

            lblhora.Text = DateTime.Now.ToString("hh:mm:ss");
            if(lblhora.Text == resultado)
            {
               MessageBox.Show("Se ejecuta proceso", "Alarma", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
