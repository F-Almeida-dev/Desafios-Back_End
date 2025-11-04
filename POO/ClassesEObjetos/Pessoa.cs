using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassesEObjetos
{
    public class Pessoa
    {
        public string Nome = "";

        public int idade = 0;

        public void Falar()
        {
            System.Console.WriteLine($"Olá, meu nome é {Nome}");
        }
       
        public int Envelhecer(int _anos)
        {
            if (_anos <= 0)
            {
                System.Console.WriteLine($"Idade tem que ser posiiva!");
                return -1; 
            }

            idade += _anos;

            return idade;
        }


    }
}