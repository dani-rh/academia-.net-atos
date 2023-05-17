using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_07
{
    internal class Livro
    {
        private string _titulo;
        private Autor _autor;
        public string Titulo
        {
            get { return _titulo; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("O título do livro não pode estar vazio.");
                }
                _titulo = value;
            }
        }

        public Autor Autor
        {
            get { return _autor; }
            set { _autor = value; }
        }
    }
}
