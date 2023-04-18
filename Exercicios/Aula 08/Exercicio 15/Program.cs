namespace Exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 15 - Escreva um programa em C# para ler os valores e somar duas matrizes 4 x 4. Mostrar a matriz resultante.

            //Declaração das matrizes 4x4

            Random random = new Random();
            int[,] matriz1 = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            int[,] matrizSoma = new int[4, 4];

            //Populando as matrizes 4x4 com valores aleatórios

            Console.WriteLine("Matriz 1: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz1[i, j] = random.Next(10);
                    Console.Write(matriz1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz 2: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz2[i, j] = random.Next(10);
                    Console.Write(matriz2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            // Somando as matrizes
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrizSoma[i, j] = matriz1[i, j] + matriz2[i, j];
                }
            }

            // Imprimindo a soma das matrizes
            Console.WriteLine("\nSoma das matrizes:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrizSoma[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}