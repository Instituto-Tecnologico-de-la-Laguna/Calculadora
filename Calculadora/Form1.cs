using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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



        private void button1_Click(object sender, EventArgs e) { 
        
            DialogResult resultado = MessageBox.Show("TU NOMBRE ES:" + txtNombre.Text, "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult) {
                MessageBox.Show("tu nombre es correcto", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
               txtNombre.Clear();
                txtNombre.Focus();

             } else
            {
                this.Close();

    } }
    }
}
