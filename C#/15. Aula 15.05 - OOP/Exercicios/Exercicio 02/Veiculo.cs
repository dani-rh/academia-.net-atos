using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Veiculo
    {
        public string Marca { get; set; }

        public string Modelo { get; set;}

        public void Dirigir()
        {
            Console.Write("Dirigindo o "+Marca+" "+Modelo);
        }

    }
}
