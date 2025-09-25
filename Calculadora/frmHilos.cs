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

namespace Calculadora
{
    public partial class frmHilos : Form
    {
        public frmHilos()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Thread p1 = new Thread(new ThreadStart(cuadro1));
            p1.Start();
            Thread p2 = new Thread(new ThreadStart(cuadro2));
            p2.Start();
        }

        public void cuadro2()
        {
            int r = 255, g = 255, b = 255;
            bool bandera = false;
            bool bandera2 = false;
            while (true)
            {
                Thread.Sleep(10);
                if (bandera2 == false)
                {
                    if (bandera == false)
                    {
                        r--;
                        if (r == 0)
                        {
                            bandera = true;
                        }
                    }
                    else
                    {
                        g--;
                        if (g == 0)
                        {
                            bandera = false;
                            bandera2 = true;
                        }
                    }
                }
                else
                {
                    if (bandera == false)
                    {
                        r++;
                        if (r == 255)
                        {
                            bandera = true;
                        }
                    }
                    else
                    {
                        g++;
                        if (g == 255)
                        {
                            bandera = false;
                            bandera2 = false;
                        }
                    }
                }
                pb2.BackColor = Color.FromArgb(r, g, b);
            }
        }

        public void cuadro1()
        {
            bool bandera = false;
            bool bandera2 = false;
            int r = 0, g = 0, b = 0;
            while (true)
            { 
                Thread.Sleep(10);
                if(bandera2 == false)
                {
                    if(bandera == false)
                    {
                        r++;
                        if(r == 255)
                        {
                            bandera = true;
                        }
                    }
                    else
                    {
                        g++;
                        if(g == 255)
                        {
                            bandera = false;
                            bandera2 = true;
                        }
                    }
                }
                else
                {
                    if(bandera == false)
                    {
                        r--;
                        if(r == 0)
                        {
                            bandera = true;
                        }
                    }
                    else
                    {
                        g--;
                        if(g == 0)
                        {
                            bandera = false;
                            bandera2 = false;
                        }
                    }
                }
                pb1.BackColor = Color.FromArgb(r, g, b);
            }
        }
    }
}
