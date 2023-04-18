using System.Runtime.Intrinsics.Arm;

namespace Exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 13 - Escreva um programa que leia uma matriz de ordem 5(ou seja, 5x5)
            //e verifique se a soma dos elementos da diagonal principal é igual a soma dos elementos da
            //diagonal secundária.

            //Declaração da matriz 5x5

            int[,] matriz = new int[5, 5];
            int somaDiagonalPrincipal = 0;
            int somaDiagonalSecundaria = 0;

            Random random = new Random();

            Console.WriteLine("Matriz de ordem 5: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = random.Next(0,50);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Calcula a soma dos elementos da diagonal principal e da secundária
            for (int i = 0; i < 5; i++)
            {
                somaDiagonalPrincipal += matriz[i, i];
                somaDiagonalSecundaria += matriz[i, 4 - i];
            }

            //Verifica se as somas são iguais
            if (somaDiagonalPrincipal == somaDiagonalSecundaria)
            {
                Console.WriteLine("\nA soma dos elementos da diagonal principal (" +somaDiagonalPrincipal+ ") é igual a soma dos elementos da diagonal secundária ("+somaDiagonalSecundaria+ ") .");
            }
            else
            {
                Console.WriteLine("\nA soma dos elementos da diagonal principal (" + somaDiagonalPrincipal + ") não é igual a soma dos elementos da diagonal secundária (" + somaDiagonalSecundaria + ") .");
            }

        }
    }
}