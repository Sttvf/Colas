using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appColas
{
    internal class Generador 
    {
        
        public Queue<Carro> Cola1 { get; set; }
        public Queue<Carro> Cola2 { get; set; }

        public Carro GCarro(string a, int x , int y)
        {
            Carro carro = new Carro() { ID = a, X = x, Y = y, Ancho = 122, Alto = 55, Color = Color.Red };
            return carro;
        }
    }
}
