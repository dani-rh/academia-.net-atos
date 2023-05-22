using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    internal class Livro : Produto
    {
        public string Autor { get; set; }

        public void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Autor: " + Autor);
        }
    }
}

