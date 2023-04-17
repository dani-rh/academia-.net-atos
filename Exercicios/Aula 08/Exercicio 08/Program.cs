namespace Exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 08 - Ler uma matriz com 4x4 de inteiros e mostrar os números na ordem direta e
            //inversa a que foram lidos.

            //Populando a matriz 4x4 com valores aleatórios

            int[,] matriz = new int[4,4];
            Random random = new Random();

            Console.WriteLine("Matriz direta : ");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(0, 50);
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            //Mostrar números na ordem inversa:
            Console.WriteLine("\nNúmeros na ordem inversa: ");
            for (int i = 3; i >= 0; i--)
            {
                for (int j = 3; j >= 0; j--)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}