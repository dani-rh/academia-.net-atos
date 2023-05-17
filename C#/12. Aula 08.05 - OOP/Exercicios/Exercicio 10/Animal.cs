using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_10
{
    internal class Animal
    {
        private string _nome;
        private string _especie;
        private int _idade;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }
        public string Especie
        {
            get { return _especie; }
            set { _especie = value; }
        }
        public int Idade
        {
            get { return _idade; }
            set { _idade = value; }
        }

        public void EmitirSom()
        {
            Console.WriteLine("Som do animal");
        }
    }
}
