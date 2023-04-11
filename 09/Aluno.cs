using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09
{
    public class Aluno
    {
        public int nota1 { get; set; }
        public int nota2 { get; set; }
        public int peso1 { get; set; }
        public int peso2 { get; set; }


        public double CalcularMediaHarmonica()
        {
            double x = 1.0 / nota1;
            double y = 1.0 / nota2;
            return 2.0 / (x + y);
        }

        public double CalcularMediaPonderada()
        {
            return (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
        }

    }
}