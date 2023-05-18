using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class Animal
    {
        public string Nome { get; set; }
        public int Idade { get; set;}

        public void Mostrar()
        {
            Console.WriteLine("Nome: " +Nome);
            Console.WriteLine("Idade: " + Idade);
        }
    }
}
