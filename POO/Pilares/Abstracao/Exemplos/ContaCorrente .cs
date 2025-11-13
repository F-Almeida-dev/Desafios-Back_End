using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class ContaCorrente : ContaBancaria
    {
        public double Saldo;
        public override void Depositar(double valor)
        {
           if(valor <= 0)
            {
                System.Console.WriteLine($"O valor do saque deve ser maior que R$0,0");
                return;
            }
        }

        public override void Sacar(double valor)
        {
            throw new NotImplementedException();
        }
    }
}