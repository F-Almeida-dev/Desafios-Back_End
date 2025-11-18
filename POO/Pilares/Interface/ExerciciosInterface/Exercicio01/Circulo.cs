using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Circulo : IForma
    {

        public double Raio;

       private double PI = 3.14f;
        public void CalcularArea()
        {
            System.Console.WriteLine($"A área do Círculo é {PI*Raio*Raio}");
        }
    }
}