using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    internal class Combustivel
    {
        public double inicio, final, consumo;
        public double CalcularCombustivel()
        {
            return inicio * final / consumo;
        }

    }
}
