using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class Cilindro
    {
        public double raio, altura, volume;
        public double CacularCilindro()
        {
           return raio * altura * volume;
        }
    }
}
