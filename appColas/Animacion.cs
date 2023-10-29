using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appColas
{
    class Animacion
    {
        Generador generador = new Generador();
        int c = 0;
        Random r = new Random();

        public Queue<Carro> Cola1 { get; set; }
        public Queue<Carro> Cola2 { get; set; }
        public Semaforo Semaforo { get; set; }



        public Animacion()
        {
            this.Cola1 = new Queue<Carro>();
            this.Cola2 = new Queue<Carro>();

            this.Semaforo = new Semaforo() { X = 200, Y = 10, Ancho = 122, Alto = 55 };
        }

        public void Actualizar(bool t, int s, int y)
        {
            if (s == 100)
            {
                c++;
                if (r.Next(1, 3) == 1)
                {
                    this.Cola1.Enqueue(generador.GCarro(c.ToString(), 10, 10));
                }
                else
                {
                    this.Cola2.Enqueue(generador.GCarro(c.ToString(), 400, y));
                }
            }
            
            foreach (Carro carro in this.Cola1)
            {
                if (this.Semaforo.Estado.ToString() == "Parar")
                {
                    if (carro.Y < (y-95))
                    {
                        carro.Y += 1;
                    }
                }
                else
                {
                    carro.Y += 1;
                }
            }

            foreach (Carro carro in this.Cola2)
            {
                if (this.Semaforo.Estado.ToString() == "Parar")
                {
                    if (carro.Y > 115)
                    {
                        carro.Y -= 1;
                    }
                    else if (carro.Y <= 75)
                    {
                        carro.Y -= 1;
                    }
                }
                else
                {
                    carro.Y -= 1;
                }
            }

            this.Semaforo.Actualizar(t);
        }

        public Bitmap Dibujar(int ancho, int alto)
        {
            Bitmap miImagen = new Bitmap(ancho, alto);
            Graphics graphics = Graphics.FromImage(miImagen);

            graphics.DrawImage(Bitmap.FromFile("C:\\Users\\Gena_\\Downloads\\a\\cruce.jpg"), 0, 75, ancho, 40);
            graphics.DrawImage(Bitmap.FromFile("C:\\Users\\Gena_\\Downloads\\a\\cruce.jpg"), 0, alto-40, ancho, 40);

            foreach (Carro carro in this.Cola1)
            {
                carro.Dibujar(graphics);
            }

            foreach (Carro carro in this.Cola2)
            {
                carro.Dibujar(graphics);
            }

            this.Semaforo.Dibujar(graphics);

            return miImagen;
        }
    }
}
