using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_08
{
    internal class Aluno
    {
        private string _nome;
        private int _matricula;

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("O nome do aluno não pode estar vazio.");
                }
                _nome = value;
            }
        }

        public int Matricula
        {
            get { return _matricula; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("A matrícula deve ser um valor positivo.");
                }
                _matricula = value;
            }
        }
    }
}
