using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_07
{
    internal class Autor
    {
        private string _nome;

        public string Nome 
        { 
            get { return _nome;} 
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome do autor não pode estar vazio.");
                }
                _nome = value;
            }
        }
    }
}
