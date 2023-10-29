using System.Drawing;

namespace appColas
{
    public class Semaforo
    {
        public SemaforoEstado Estado { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public int Ancho { get; set; }
        public int Alto { get; set; }
        public double Tiempo { get; set; }

        public Semaforo()
        {
            this.Estado = SemaforoEstado.Parar;
        }

        public void Actualizar(bool t)
        {
            if (t == false)
            {
                this.Estado = SemaforoEstado.Parar;
            }
            else
            {
                this.Estado = SemaforoEstado.Avanzar;
            }
        }

        public void Dibujar(Graphics graphics)
        {
            // Contorno
            graphics.FillRectangle(new SolidBrush(Color.White), new Rectangle((int)this.X, (int)this.Y, this.Ancho, this.Alto));

            if (this.Estado == SemaforoEstado.Parar)
            {
                graphics.FillEllipse(Brushes.Red,
                    new Rectangle((int)this.X, (int)this.Y, this.Ancho / 2, this.Alto));
            }
            else
            {
                graphics.FillEllipse(Brushes.Green,
                    new Rectangle((int)this.X + this.Ancho / 2, (int)this.Y, this.Ancho / 2, this.Alto));
            }
        }
    }

    public enum SemaforoEstado
    {
        Avanzar,
        Parar
    }
}