using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class Aluno
    {
        public string nome;
        public int matricula;
        public DateOnly dataNascimento;
        public int anoMatricula;
        public Aluno(string nome, int matricula)
        {
            this.nome = nome;
            this.matricula = matricula;
            Console.WriteLine("Nome: " + nome + " e matricula: " + matricula);
        }

        public Aluno(DateOnly dataNascimento)
        {
            this.dataNascimento = dataNascimento;
            Console.WriteLine("Data de nascimento: " + dataNascimento);
        }

        public Aluno(string nome, DateOnly dataNascimento, int anoMatricula)
        {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.anoMatricula = anoMatricula;
            Console.WriteLine("Nome: " + nome + ", data de nascimento: " + dataNascimento+ " e ano que o aluno ingressou na faculdade: " +anoMatricula+".");
        }

    }
}
