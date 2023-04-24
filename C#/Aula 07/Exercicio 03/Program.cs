using System.Net;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que leia os valores para um vetor de 20 elementos
            //e então mostre na tela o índice da posição dos valores correspondentes a números primos.

            int[] vetor = new int[20];

            for (int i = 0; i < vetor.Length; i++)
            {
                Console.WriteLine("Informe um valor para a posição " + (i+1) + ":");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            //Console.WriteLine("\nOs números primos estão nas posições: ");
            //for (int i = 0; i < vetor.Length; i++)
            //{
            //    bool isPrime = true;
            //    if (vetor[i] < 2)
            //    {
            //        isPrime = false;
            //    }
            //    for (int j = 2;j <= Math.Sqrt(vetor[i]); j++)
            //    {
            //        if (vetor[i] % j == 0)
            //        {
            //            isPrime |= false;
            //            break;
            //        }
            //    }
            //    if (isPrime)
            //    {
            //        Console.WriteLine($"{i} ");
            //    }                
            //}


        }
    }
}