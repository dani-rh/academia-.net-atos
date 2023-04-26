using System.Net;
using System.Runtime.Serialization;

namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 12 - Apresentar o total da soma dos cem primeiros números inteiros.

            int soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += i;
            }
            Console.WriteLine("Soma dos cem primeiros números inteiros: " + soma);
        }
    }
}