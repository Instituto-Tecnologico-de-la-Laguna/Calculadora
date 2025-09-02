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

namespace Aplicacion2
{
    public partial class Form3 : Form
    {
        String resultado;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAlarma_Click(object sender, EventArgs e)
        {
            resultado = Interaction.InputBox("Ingrese la hora para la alarma(hh.mm.ss)","Alarma", "00:00:00");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labHora.Text = DateTime.Now.ToString("hh:mm:ss");
            if (labHora.Text == resultado)
            {
                MessageBox.Show("Se ejecuta proceso", "Alarma", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
