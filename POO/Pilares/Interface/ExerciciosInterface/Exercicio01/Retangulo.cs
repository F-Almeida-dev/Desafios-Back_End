using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Retangulo : IForma
    {

        public double Altura;

        public double Largura;

        public void CalcularArea()
        {
           Console.WriteLine( $"A área do Retangulo é: {Largura * Altura}");
        }
    }
}