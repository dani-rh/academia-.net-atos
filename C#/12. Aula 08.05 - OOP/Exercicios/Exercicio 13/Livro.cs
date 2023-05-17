using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_13
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public Autor Autor { get; set; }

        public void ExibirInformacoes()
        {
            Console.WriteLine("Título: " + Titulo);
            Console.WriteLine("Autor(a): " + Autor.Nome);
            Console.WriteLine("Nacionalidade do(a) autor(a): " + Autor.Nacionalidade);
        }

    }
}
