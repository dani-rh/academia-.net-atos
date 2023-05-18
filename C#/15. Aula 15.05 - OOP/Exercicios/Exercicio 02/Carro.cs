using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Carro :Veiculo
    {
        public int QuantidadeDePortas { get; set; }

        public void Dirigir ()
        {
            base.Dirigir();
            Console.Write(" com "+QuantidadeDePortas+" portas");
        }
    }
}
