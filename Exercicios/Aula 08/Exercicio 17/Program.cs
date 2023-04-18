namespace Exercicio_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //17) Fazer um algoritmo que leia uma matriz de 10 linhas por 10 colunas e escreva o elemento minimax,
            //ou seja,o menor elemento da linha onde se encontra o 
            //maior elemento da matriz. Escreva também a linha e a coluna onde foi encontrado.

            Random random = new Random();
            int[,] matriz = new int[10, 10];

            //Populando a matriz 10x10 com valores aleatórios

            Console.WriteLine("Matriz 10x10: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = random.Next(100);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Encontra o maior elemento da matriz
            int maior = matriz[0, 0];
            int linhaMaior = 0;
            int colunaMaior = 0;

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (matriz[i,j] > maior)
                    {
                        maior = matriz[i,j];
                        linhaMaior = i;
                        colunaMaior = j;
                    }
                }
            }

            //Encontra o menor elemento da linha do maior elemento
            int menor = matriz[0, 0];
            int colunaMenor = 0;
            for (int j = 0; j < 10; j++)
            {
                if (matriz[linhaMaior, j] < menor)
                {
                menor = matriz[linhaMaior, j];
                colunaMenor = j;
                }
                
            }
            Console.WriteLine("\nO elemento minimax é " +menor+ ". Encontrado na linha "+linhaMaior+ " e na coluna "+colunaMenor+ ".");

        }
    }
}