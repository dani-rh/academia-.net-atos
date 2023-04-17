namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 02 - Solicite ao usuário, preencher uma Matriz 3x3
            //Informe ao usuário:
            //A soma dos elementos de cada linha e a soma dos elementos de cada coluna.

            // Declaração de GetLenght (0) - linha

            int[,] matriz = new int[3, 3];
            int[] somaLinha = new int [3];
            int[] somaCol = new int[3];

            int i, j;

            for (i = 0; i < matriz.GetLength(0); i++) //for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite o elemento " +i+" ," +j+ " da matriz: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            i = 0;
            while (i < 3)
            {
                for (j = 0; j< 3; j++)
                {
                    somaLinha[i] = matriz[i, j] + somaLinha[i];
                    somaCol[i] = matriz[j, i] + somaCol[i]; 
                }
                i++;
            }

            for (i = 0; i < 3; i++)
            {
                for ( j = 0; j < 3; j++)
                {
                    Console.Write(matriz[i, j]+ " ");
                }
                Console.Write("\n");//Console.Writeline();
            }

            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Somatório linha " +i+ " = " + somaLinha[i]);
            }
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("Somatório coluna " + i + " = " + somaCol[i]);
            }
        }
    }
}