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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Tu nobre es: "+txt.Text, "Sistema", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("Tu nombre es correcto", "Sistema", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
                txt.Clear();
                txt.Focus();
            } else
            {
                this.Close();            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
