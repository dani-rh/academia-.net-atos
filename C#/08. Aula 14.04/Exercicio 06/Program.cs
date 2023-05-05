namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6) Gere e imprima uma matriz M 4x4 com valores aleatórios entre 0 - 9.
            //Após isso determine o maior número da matriz.
            //Random random = new Random();
            //int randomNumber = random.Next(0, 100);

            //Declarando a populando a matriz 4x4 com valores aleatórios entre 0 e 9
            Random random = new Random();
            int[,] matriz = new int[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = random.Next(0, 10);
                    Console.Write(matriz[i,j] + " ");
                }
                Console.WriteLine();
            }

            int maxNumber = matriz[0, 0];

            for (int i = 0;i < 4; i++)
            {
                for(int j = 0;j < 4;j++)
                {
                    if (matriz[i,j] > maxNumber)
                    {
                        maxNumber = matriz[i, j];
                    }
                }
            }

            Console.WriteLine("\nO maior número da matriz é: "+maxNumber);
        }
    }
}