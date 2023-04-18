namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12) Escreva um programa que leia os valores de uma matriz 4x3,
            //e em seguida mostre na tela apenas os valores cuja soma dos índices (i+j) seja um número par.

            //Populando a matriz 4x3 com valores aleatórios

            int[,] matriz = new int[4, 3];
            Random random = new Random();

            Console.WriteLine("Matriz 4x3 : ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = random.Next(0, 50);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
            //Exibindo os valores que estão na posição onde a soma dos índices é par
            Console.WriteLine("\nValores com soma de índices par: ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                }
            }    

        }
    }
}