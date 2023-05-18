using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Moto : Veiculo
    {
        public int Cilindrada { get; set; }

        public new void Dirigir()
        {
            base.Dirigir();
            Console.Write(" com "+Cilindrada+" cilindradas.");
        }
    }
}
