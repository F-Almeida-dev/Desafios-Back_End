using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            throw new NotImplementedException($"Gatinho Miau miau");
        }

        public override void Mover()
        {
            throw new NotImplementedException($"Movendo as patinhas");
        }

    }
}