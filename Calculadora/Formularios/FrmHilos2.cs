using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class FrmHilos2 : Form
    {
        public FrmHilos2()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Thread p1 = new Thread(new ThreadStart(Hilo1));
            Thread p2 = new Thread(new ThreadStart(Hilo2));

            p1.Start();
            p2.Start();
        }

        private void Hilo1()
        {
            bool bandera = false;
            int contador = 101;
            while (true)
            {
                Thread.Sleep(500);
                if (bandera = false)
                {
                    contador++;
                    if (contador == 101)
                    {
                        bandera = true;
                    }
                }
                else
                {
                    contador--;
                    if (contador == -1)
                    {
                        bandera = false;
                    }
                }
                label2.Invoke((MethodInvoker)delegate
                {
                    label2.Text = contador.ToString();
                });
            }
        }

        private void Hilo2() 
        { 
            bool bandera=false;
            int contador = 101;
            while (true)
            {
                Thread.Sleep(500);
                if (bandera = false)
                {
                    contador--;
                    if (contador == -1)
                    {
                        bandera = true;
                    }
                }
                else {
                    contador++;
                    if (contador==101)
                    {
                        bandera = false;
                    }
                }
                label1.Invoke((MethodInvoker)delegate
                {
                    label1.Text = contador.ToString();
                });
            }
        }
    }
}
