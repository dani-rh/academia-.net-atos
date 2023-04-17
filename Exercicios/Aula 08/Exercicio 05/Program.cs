using System;

namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5) Leia duas matrizes 2x3 de números double. Imprima a soma destas duas matrizes.

            //Declaração da 1ª matriz 2x3

            double[,] matriz1 = new double[2, 3];
            double[,] matriz2 = new double[2, 3];

            //Populando as matrizes 2x3 com valores aleatórios

            Random random = new Random();

            Console.WriteLine("Matriz 1: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz1[i, j] = random.NextDouble();
                    Console.Write(matriz1[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\nMatriz 2: ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz2[i, j] = random.NextDouble();
                    Console.Write(matriz1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Somando as matrizes
            double[,] soma = new double[2, 3];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    soma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            // Imprimindo a soma das matrizes
            Console.WriteLine("\nSoma das matrizes:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(soma[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}