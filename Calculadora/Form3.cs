using Microsoft.VisualBasic;
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
    public partial class Form3 : Form
    {
        String resultado;
        public Form3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            if (label1.Text==resultado)
            {
                MessageBox.Show("Se ejecuta proceso", "Alarma", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
;        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultado = Interaction.InputBox("Ingrese la hora para la alarma (hh:mm:ss):", "Alarma", "00:00:00");
        }
    }
}
