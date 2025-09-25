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
    public partial class frmHilos2 : Form
    {
        Thread p1;
        Thread p2;

        public frmHilos2()
        {
            InitializeComponent();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            p1 = new Thread(new ThreadStart(hilo1));
            p1.Start();
            p2 = new Thread(new ThreadStart(hilo2));
            p2.Start();
        }

        private void hilo1()
        {
            int contador = -1;
            bool bandera = false;
            while (true)
            {
                Thread.Sleep(500);
                if(bandera == false)
                {
                    contador++;
                    if(contador == 101)
                    {
                        bandera = true;
                    }
                }
                else
                {
                    contador--;
                    if(contador == -1)
                    {
                        bandera = false;
                    }
                }
                label1.Invoke((MethodInvoker) delegate
                {
                    label1.Text = contador.ToString();
                });
            }
        }

        private void hilo2() 
        {
            int contador = 101;
            bool bandera = false;
            while (true) 
            {
                Thread.Sleep(500);
                if(bandera == false)
                {
                    contador--;
                    if(contador == -1)
                    {
                        bandera = true;
                    }
                }
                else
                {
                    contador++;
                    if(contador == 101)
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

        private void frmHilos2_FormClosing(object sender, FormClosingEventArgs e)
        {
            p1.Suspend();
            p2.Suspend();
        }
    }
}
