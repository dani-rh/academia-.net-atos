using System.Runtime.Serialization;

namespace Exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 13 - Elaborar um programa que apresente o somatório dos valores pares existentes entre 1 e 500.

            int soma = 0;
            
            for (int i = 1; i < 500; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                    
                    soma += i;
                }
            }
            Console.WriteLine("Somatório dos valores pares existentes entre 1 e 500: " + soma);
        }
    }
}