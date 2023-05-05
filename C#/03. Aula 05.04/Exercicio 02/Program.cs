using System;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 02 - Faça um algoritmo para ler um número e verificar se ele é par ou ímpar. 

            int num;
            Console.WriteLine("Digite um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("O número " + num + " é par.");
            }
            else
            {
                Console.WriteLine("O número " + num + " é ímpar.");
            }

        }
    }
}