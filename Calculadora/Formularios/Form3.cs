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
    public partial class frmTimers : Form
    {
        string resultados;
        public frmTimers()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //lblHora.Text = DateTime.Now.ToShortTimeString();
            //lblHora.Text = DateTime.Now.ToLongTimeString();
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            if (resultados == lblHora.Text)
            {
                MessageBox.Show("Alarma!!!", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmTimers_Load(object sender, EventArgs e)
        {

        }

        private void btnAlarma_Click(object sender, EventArgs e)
        {
            resultados = Interaction.InputBox("Ingrese la hora para la alarma (hh:mm:ss)", "Alarma", "00:00:00");
            
        }
    }
}
    