using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosMetodoConstrutor
{
    public class MediaAluno
    {
        public string Nome;
        public double N1, N2, N3;

        //Construtor com parametros
        public MediaAluno(double param1, double param2, double param3)
        {
            //N1 = 0; //fixo
            N1 = param1; //parametro param1 representa o valor do N1 - valor dinamico
            N2 = param2;
            N3 = param3;
        }

        public MediaAluno()
        {
            N1 = N2 = N3 = 0; //Atribuindo valor fixo para as 3 propriedades de uma vez
        }

        public void Media()
        {
            double Media = (N1 + N2 + N3) / 3;

            System.Console.WriteLine($"A média do(a) {Nome} foi: {Media} 👀");
        }
    }
}