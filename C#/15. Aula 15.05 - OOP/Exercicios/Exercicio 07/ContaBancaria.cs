using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_07
{
    public abstract class ContaBancaria
    {
        public abstract string Titular {get;set; }
        
        public abstract decimal Saldo { get;set;}
        public abstract decimal TaxaDeJuros { get;set;}



    }
}
