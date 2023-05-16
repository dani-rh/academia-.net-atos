using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anotações
{
    internal class Cavalo :Animal
    {
        public string Raça { get;set }
        public Cavalo (string nome, int idade, string raca) : base(nome, idade)
        {
            raca = raca;
        }

        public override void emitirSom()
        {
            Console.WriteLine("O " +this.Nome+" está relinchando!");
        }
    }
}
