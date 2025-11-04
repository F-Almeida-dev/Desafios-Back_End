using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetodoConstrutor
{
    public class Pessoa
    {
        public string Nome;

        public int Idade;

       // Metodo construtor de Pessoa, possindo parametros
       /* Parametro representam valores para suas respectivas props 
        ou seja, estamos inicializadndovalore para as props 
        nome e idade*/
        
     
        public Pessoa(String n, int i)
        {
            Nome = n;//inicializa com o valor de n
            Idade = i;//inicializa com o valor de i
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}