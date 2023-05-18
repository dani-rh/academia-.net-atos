using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    internal class ContaPoupanca:Conta
    {
        public double LimiteDeCredito { get; set; }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Limite de crédito da conta poupança: "+LimiteDeCredito);
        }
    }
}
