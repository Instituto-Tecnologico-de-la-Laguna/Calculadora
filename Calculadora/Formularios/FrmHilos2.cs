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
using System.Windows.Forms.VisualStyles;

namespace Calculadora
{
    public partial class FrmHilos2 : Form
    {
        public FrmHilos2()
        {
            InitializeComponent();
        }

        Thread p1;
        Thread p2;  


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            p1 = new Thread(new ThreadStart(Hilo1));
            p1.Start(); 

            p2 = new Thread(new ThreadStart(Hilo2));
            p2.Start(); 
        }

        private void Hilo1()
        {
            int contador = -1;
            bool bandera = false;
            while (true)
            {
                Thread.Sleep(500);
                if (bandera == false)
                {
                    contador++;
                    if (contador == 101)
                    {
                        bandera = true;
                    }
                    label1.Invoke((MethodInvoker)delegate {
                        label1.Text = contador.ToString();
                    });
                } else
                {
                    contador--;
                    if (contador == -1)
                    {
                        bandera = false;
                    }
                    //Manejo de delegado
                    label1.Invoke((MethodInvoker)delegate{
                        label1.Text = contador.ToString();
                    });
                }
            }

        }

        private void Hilo2()
        {
            int contador = 101;
            bool bandera = false;
            while (true)
            {
                Thread.Sleep(500);
                if (bandera == false)
                {
                    contador--;
                    if (contador == -1)
                    {
                        bandera = true;
                    }
                    label2.Invoke((MethodInvoker)delegate {
                        label2.Text = contador.ToString();
                    });
                }
                else
                {
                    contador++;
                    if (contador == 101)
                    {
                        bandera = false;
                    }
                    label2.Invoke((MethodInvoker)delegate {
                        label2.Text = contador.ToString();
                    });
                }
            }
            
        }

        private void FrmHilos2_FormClosing(object sender, FormClosingEventArgs e)
        {
            p1.Suspend();
            p2.Suspend();
        }
    }
}
