using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    internal class ContaCorrente :Conta
    {
        public double TaxadeJuros { get; set; }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Taxa de juros da conta corrente: "+TaxadeJuros);
        }
    }
}
