using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anotações
{
    internal class Pessoa
    {
        private string nome; //atributos por padrão inicial por _nome
        private int idade;
        private double salario;

        //public Pessoa(string nome, int idade)
        //{
        //    this.nome = nome;
        //    this.idade = idade;
        //    Console.WriteLine("Nome: "+nome+" - Idade: "+idade);
        //}

        //public Pessoa(int idade
        //{
        //    this.idade = idade;
        //    Console.WriteLine("Idade " + idade);
        //}

        public Pessoa()
        {
            //this.nome = "Daniela";
        }
        public string Nome //C# trabalha com propriedade e por padrão começcam com maiusculo
        {
            get { return nome; }
            set { nome = value; }
        }



    }
}
