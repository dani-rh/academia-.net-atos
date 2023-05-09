using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_04
{
    internal class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace (value))
                {
                    throw new ArgumentException ("O nome não pode estar vazio.");
                }
                _nome = value;
            }
        }

        public int Idade
        {
            get { return _idade; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("A idade deve ser maior que zero.");
                }
                _idade = value;
            }
        }

    }
}
    