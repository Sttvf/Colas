using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appColas
{
    public partial class Form1 : Form
    {
        Animacion animacion = new Animacion();
        int s = 0;
        bool t = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (timer1.Enabled == true)
            {
                if (s == 200)
                {
                    if (t == true)
                    {
                        t = false;
                    }
                    else
                    {
                        t = true;
                    }
                    
                    s = 0;
                }
                else
                {
                    s++;
                }

                this.animacion.Actualizar(t, s, pbCanvas.Height);
                pbCanvas.BackColor = Color.Black;
                pbCanvas.Image = this.animacion.Dibujar(pbCanvas.Width, pbCanvas.Height);
                
            }
            //this.animacion.Actualizar(timer1.Interval);
            //pbCanvas.Image = this.animacion.Dibujar(pbCanvas.Width, pbCanvas.Height);
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
