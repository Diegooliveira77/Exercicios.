using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07
{
    internal class Salario
    {
        public double salarioBase, totalVendas, comissao, salarioTotal;

        public double CalcularSalario()
        {
            return salarioTotal = salarioBase + (totalVendas * (comissao * salarioBase / 100));
        }


    }
}

