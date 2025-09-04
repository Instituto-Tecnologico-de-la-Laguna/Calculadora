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
    public partial class frmTimers : Form
    {
        string resultado;
        public frmTimers()
        {
            InitializeComponent();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            //lblHora.Text=DateTime.Now.ToShortTimeString();
            //lblHora.Text = DateTime.Now.ToLongTimeString();
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            if(lblHora.Text==resultado)
            {
                MessageBox.Show("Se ejecuta proceso","Alarma", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
            }
        }

        private void btnAlarma_Click(object sender, EventArgs e)
        {
             resultado= Interaction.InputBox("Ingrese la hora para la alarma (hh:mm:ss):",
                "Alarma", "00:00:00");
        }
    }
}
