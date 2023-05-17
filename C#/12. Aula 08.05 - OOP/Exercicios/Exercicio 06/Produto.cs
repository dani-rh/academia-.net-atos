using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_06
{
    internal class Produto
    {
        private string _nome;
        private decimal _preco;
        private Fabricante _fabricante;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O nome não pode estar vazio.");
                }
                _nome = value;
            }
        }

        public decimal Preco
        {
            get { return _preco; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("O preço deve ser positivo.");
                }
                _preco = value;
            }
        }

        public Fabricante Fabricante
        {
            get { return _fabricante; }
            set { _fabricante = value; }
        }
    }
}
