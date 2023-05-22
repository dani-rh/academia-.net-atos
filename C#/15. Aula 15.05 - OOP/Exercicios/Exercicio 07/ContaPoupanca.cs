using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_07
{
    internal class ContaPoupanca : ContaBancaria
    {
        public override string Titular { get; set; }
        public override decimal Saldo { get; set; }
        public override decimal TaxaDeJuros { get; set; }
    }
}
