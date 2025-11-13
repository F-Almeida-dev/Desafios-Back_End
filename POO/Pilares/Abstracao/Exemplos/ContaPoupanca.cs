using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ContaPoupanca : ContaBancaria
    {
        public double Saldo;
        public override void Depositar(double valor)
        {
              if(valor <= 0)
            {
                System.Console.WriteLine($"O valor do saque deve ser maior que R$0,0");
                return;
        }

       Saldo += valor;

        }
        public override void Sacar(double valor)
        {
              if(valor >= 0 || valor <= Saldo)
            {
                System.Console.WriteLine($"O valor do saque deve positivo e ter dinheiro suficienta para o saque");
                return;
        }
    }
  }
}