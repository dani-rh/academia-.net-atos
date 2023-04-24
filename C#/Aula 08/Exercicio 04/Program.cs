using System.Reflection;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 04 -  Popule uma matriz 5x5 e informe:
            //- Quantos números são pares
            //- Quantos números são impares
            //- Quantos números são positivos
            //- Quantos números são negativos
            //- Quantos zeros existem!

            //Declaração da matriz 5x5

            int[,] matriz = new int[5, 5];
            int pares = 0, impares = 0, positivos = 0, negativos = 0, zeros = 0;

            //Populando a matriz 5x5 com valores aleatórios entre -50 e 50
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matriz[i, j] = rand.Next(-50, 50);
                }
            }
            
            //Contabilizando os valores
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0;j < 5; j++)
                {
                    if (matriz[i, j] % 2 == 0) //Checar se é par
                    {
                        pares++;
                    }
                    else //Senão, é impar
                    {
                        impares++;
                    }

                    if (matriz[i, j] > 0) //Verifica se é positivo
                    {
                        positivos++;
                    }
                    else if (matriz[i, j] < 0) //Verifica se é negativo
                    {
                        negativos++;
                    }
                    else
                    {
                        zeros++; //Senão, é zero
                    }
                }    
            }

            //Exibindo os resultados
            Console.WriteLine("Matriz: ");
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(matriz[i,j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Quantidade de números pares: " +pares);
            Console.WriteLine("Quantidade de números ímpares: " + impares);
            Console.WriteLine("Quantidade de números positivos: " + positivos);
            Console.WriteLine("Quantidade de números negativos: " + negativos);
            Console.WriteLine("Quantidade de zeros: " +zeros);
        }
    }
}