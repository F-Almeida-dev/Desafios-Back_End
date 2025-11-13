using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplos
{
    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            throw new NotImplementedException($"AU Au");
        }

        public override void Mover()
        {
            throw new NotImplementedException($"Ploc Ploc Ploc");
        }

    }
}