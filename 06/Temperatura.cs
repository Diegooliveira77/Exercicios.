using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
    internal class Temperatura
    {
        public double fahrenheit, celsius;
        public double Convert(double fahrenheit, double celsius)
        {
           return fahrenheit = (celsius * 9 / 5) + 32;
        }
    }
}
