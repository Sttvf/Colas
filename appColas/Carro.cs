using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appColas
{
    class Carro
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public string ID { get; set; }
        public Color Color { get; set; }

        public void Dibujar(Graphics graphics)
        {
            Pen pen = new Pen(this.Color);
            graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle((int)this.X, (int)this.Y, this.Ancho, this.Alto));
            graphics.DrawString(this.ID, new Font("Arial", 12), new SolidBrush(Color.Black), new RectangleF(this.X+(this.Ancho/2)-7, this.Y+(this.Alto/2)-7, Ancho, Alto));
        }
    }
}
