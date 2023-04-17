using System;

namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 03 - Popular uma matriz 4x4 e mostre os elementos da Diagonal Principal

            //Declaração da matriz 4x4

            int[,] matriz = new int[4, 4];

            Console.WriteLine("Preencha a matriz 4x4: ");

            for (int linha = 0; linha < matriz.GetLength(0); linha++)
            {
                for (int coluna = 0; coluna < matriz.GetLength(1); coluna++)
                {
                    Console.Write("Posição [" + linha + "," + coluna + "]: ");
                    matriz[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            //Diagonal é quando os indices da matriz são o mesmo na coluna e na linha
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(matriz[i,i]);
            }
        }
    }
}