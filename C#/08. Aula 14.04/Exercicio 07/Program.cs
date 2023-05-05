namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7) Leia duas matrizes A e B com 3x3 elementos.
            //Construir uma matriz C, onde cada elemento de C é a subtração do elemento
            //correspondente de A com B.

            //Declaração das duas matrizes 3x3

            int[,] matriz1 = new int[3, 3];
            int[,] matriz2 = new int[3, 3];
            int[,] matriz3 = new int[3, 3];

            //Populando as matrizes 3x3 com valores aleatórios

            Random random = new Random();

            Console.WriteLine("Matrizes A e B: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz1[i, j] = random.Next(0, 50);
                    matriz2[i, j] = random.Next(0, 50);   
                }
            }

            // Subtraindo as matrizes
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz3[i, j] = matriz1[i, j] - matriz2[i, j];
                }
            }

            //Imprimindo as matrizes

            Console.WriteLine("\nMatriz A: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz B: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz C: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matriz3[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}