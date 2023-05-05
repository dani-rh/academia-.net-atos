using System.Security.Cryptography;

namespace Exercicio_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 16 - Escreva um algoritmo para transpor uma matriz 3x4 para outra 4x3.
            //Transpor uma matriz significa transformar suas linhas em colunas e vice - versa.

            Random random = new Random();
            int[,] matrizOriginal = new int[3, 4];
            
            //Populando a matriz 3x4 com valores aleatórios

            Console.WriteLine("Matriz Original 3x4: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrizOriginal[i, j] = random.Next(50);
                    Console.Write(matrizOriginal[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Transpondo a matriz
            int[,] matrizTransposta = new int[4,3];

            for (int i = 0; i < matrizOriginal.GetLength(0); i++)
            {
                for (int j = 0; j < matrizOriginal.GetLength(1); j++)
                {
                    matrizTransposta[j, i] = matrizOriginal[i,j];
                }
            }

            //Imprimindo a matriz transposta
            Console.WriteLine("Matriz Transposta 4x3: ");
            for (int i = 0; i < matrizTransposta.GetLength(0); i++)
            {
                for (int j = 0; j < matrizTransposta.GetLength (1); j++)
                {
                    Console.Write(matrizTransposta[i,j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}