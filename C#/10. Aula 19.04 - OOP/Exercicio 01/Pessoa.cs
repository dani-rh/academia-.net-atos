using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            Console.WriteLine("Nome: "+nome+" e idade: "+idade);
        }

        public Pessoa(int idade)
        {
            this.idade = idade;
            Console.WriteLine("Idade: "+idade);
        }


    }
}
