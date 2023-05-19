using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_06
{
    internal class Produto
    {
        public int Codigo { get; set; }

        public string Descricao { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Código: " + Codigo);
            Console.WriteLine("Descrição: " + Descricao);
        }

    }
}
