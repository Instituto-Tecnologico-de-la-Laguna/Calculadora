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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {

            DialogResult Resultado = MessageBox.Show("Tu nombre es: " + txtNombre.Text, "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Resultado == DialogResult.OK)
            {
                MessageBox.Show("Tu Nombre es correcto", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                txtNombre.Clear();
                txtNombre.Focus();
            }
            else
            {
                this.Close();
            }


        //  MessageBox.Show("HolaMundo", "Sistemas", MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
        
        }
    }
}
