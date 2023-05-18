using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_14
{
    internal class Agenda
    {
        private Pessoa[] pessoas;
        private int contador;
        public Agenda()
        {
            pessoas = new Pessoa[10];
            contador = 0;
        }

        public void ArmazenaPessoa(string nome, int idade, float altura)
        {
            if (contador < 10)
            {
                Pessoa pessoa = new Pessoa
                {
                    Nome = nome,
                    Idade = idade,
                    Altura = altura
                };

                pessoas[contador] = pessoa;
                contador++;
                Console.WriteLine("Pessoa adicionada com sucesso.");
            }
            else
            {
                Console.WriteLine("A agenda está cheia. Não é possível adicionar mais pessoas.");
            }
        }

        public void RemovePessoa(string nome)
        {
            int index = -1;

            for (int i = 0; i < contador; i++)
            {
                if (pessoas[i].Nome == nome)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                for (int i = index; i < contador - 1; i++)
                {
                    pessoas[i] = pessoas[i + 1];
                }

                pessoas[contador - 1] = null;
                contador--;

                Console.WriteLine("Pessoa removida com sucesso.");
            }
            else
            {
                Console.WriteLine("Pessoa não encontrada na agenda.");
            }
        }

        public Pessoa BuscaPessoa(string nome)
        {
            for (int i = 0; i < contador; i++)
            {
                if (pessoas[i].Nome == nome)
                {
                    return pessoas[i];
                }
            }

            return null;
        }

        public void ImprimeAgenda()
        {
            if (contador == 0)
            {
                Console.WriteLine("A agenda está vazia.");
            }
            else
            {
                Console.WriteLine("Dados das pessoas na agenda: ");
            }

            for (int i = 0; i < contador; i++)
            {
                Pessoa pessoa = pessoas[i];
                Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Altura: {pessoa.Altura}");
            }
        }


    }
}
