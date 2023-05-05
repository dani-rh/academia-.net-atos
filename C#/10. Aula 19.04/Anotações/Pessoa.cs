using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anotações
{
    internal class Pessoa
    {
        public string nome;
        public int idade;

        public Pessoa()
        {

        }

        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
            //para receber aquilo que já defini como parametro - Snow, 6 anos
        }

        public void exibeDados()
        {
            Console.WriteLine("Nome: "+this.nome);
            Console.WriteLine("Idade: "+this.idade);
        }
    }
}
