using System.Runtime.Intrinsics.X86;

namespace Exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 09 - Faça um programa em VS para Ler a quantidade de filhos de cada uma das 30 pessoas que visitaram o zoológico num determinado dia, imprimindo:
            //Quantas pessoas tem entre 1 e 3 filhos.
            //Quantas pessoas tem entre 4 e 7 filhos.
            //Quantas pessoas tem mais de 8 filhos.
            //Quantas pessoas não tem filhos.

            //variáveis para contar o número de pessoas em cada divisão de idade
            int numPessoas1a3 = 0;
            int numPessoas4a7 = 0;
            int numPessoasMaisDe8 = 0;
            int numPessoasSemFilhos = 0;

            //perguntar o número de filhos para 30 pessoas
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Digite a quantidade de filhos da pessoa " +(i+1)+ ": ");
                int quantidadeFilhos = int.Parse(Console.ReadLine());

                if (quantidadeFilhos >= 1 && quantidadeFilhos <= 3)
                {
                    numPessoas1a3++;
                }
                else if (quantidadeFilhos >= 4 && quantidadeFilhos <= 7)
                {
                    numPessoas4a7++;
                }
                else if ( quantidadeFilhos >= 8)
                {
                    numPessoasMaisDe8++;
                }
                else if (quantidadeFilhos == 0)
                {
                    numPessoasSemFilhos++;
                }
            }

            Console.WriteLine("Número de pessoas com 1 a 3 filhos: " +numPessoas1a3+ ".");
            Console.WriteLine("Número de pessoas com 4 a 7 filhos: " + numPessoas4a7 + ".");
            Console.WriteLine("Número de pessoas com mais de 8 filhos: " + numPessoasMaisDe8 + ".");
            Console.WriteLine("Número de pessoas sem filhos: " + numPessoasSemFilhos + ".");

        }
    }
}