using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    internal class CD : Produto
    {
        public string Artista { get; set; }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Artista: " + Artista);
        }
    }
}

