using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_11
{
    internal class Aluno
    {
        private string nome;
        private double nota1;
        private double nota2;
        private double nota3;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public double Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }

        public double CalcularMedia()
        {
            return (nota1 + nota2 + nota3) / 3;
        }

        public string VerificarAprovacao()
        {
            if (CalcularMedia() >= 6)
            {
                return "Aprovado";
            }
            else
            {
                return "Reprovado";
            }
        }
    }
}
