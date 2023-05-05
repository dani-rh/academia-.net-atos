namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos,
            //em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média.

            //Declaração das duas matrizes 4x4

            int[,] matriz1 = new int[4, 4];
            int[,] matriz2 = new int[4, 4];
            int[,] matriz3 = new int[4, 4];

            //Populando as matrizes A e B com valores aleatórios

            Random random = new Random();

            Console.WriteLine("Matrizes A e B: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz1[i, j] = random.Next(0, 50);
                    matriz2[i, j] = random.Next(0, 50);
                }
            }

            //Imprimindo as matrizes

            Console.WriteLine("\nMatriz A: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz1[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nMatriz B: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz2[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Calculando a média dos elementos
            int soma = 0;
            int elementos = matriz1.Length + matriz2.Length;

            for (int i = 0; i < matriz1.GetLength(0); i++)
            {
                for (int j = 0; j < matriz1.GetLength(1); j++)
                {
                    soma += matriz1[i, j];
                }
            }

            for (int i = 0; i < matriz2.GetLength(0); i++)
            {
                for (int j = 0; j < matriz2.GetLength(1); j++)
                {
                    soma += matriz2[i, j];
                }
            }

            double media = (double)soma / elementos;

            Console.WriteLine("\nA média dos elementos da duas matrizes é: " +media);
        }
    }
}