using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEstatias
{
    public static class CalculosMatematicos
    {
        //Operações Matemáticas simples
        // Visibilidade tipoDeRetorno Nome(parâmetros){corpo}
        public static float Somar(float a, float b)
        {
        return a + b;
        }

        //Criar as outas e operações 
        //Não se esqueça que não existe 


        public static float Subtrair(float a, float b)
        {
            return a - b;
        }

        public static float Multiplicar(float a, float b)
        {
            return a * b;
        }
        public static float Dividir(float a, float b)
        {
            if (b !=  0)
            {
              return a / b;  
            }
            else
            {
                Console.WriteLine($"Divisão Inválida");
                return 0;
            }
        }

    }
}