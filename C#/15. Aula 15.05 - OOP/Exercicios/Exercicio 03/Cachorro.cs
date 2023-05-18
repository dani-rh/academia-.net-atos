using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class Cachorro:Animal
    {
        public string Raca { get; set; }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Raça: " + Raca);
        }
    }
}
