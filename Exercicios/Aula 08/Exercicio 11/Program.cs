namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 11 - Leia uma matriz A de tipo double de dimensão 3x3,
            // crie uma nova matriz resultante da divisão dos elementos da matriz A pela soma dos seus indices.

            //Declaração da matriz A 3x3 e populando com valores aleatórios

            double[,] matrizA = new double[3, 3];

            Random random = new Random();

            Console.WriteLine("Matriz A: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizA[i, j] = random.NextDouble();
                    Console.Write(matrizA[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Calculando a nova matriz

            double[,] resultado = new double[3, 3];
                
            for (int i = 0;i < 3;i++)
            {
                for (int j = 0;j < 3;j++)
                {
                    double somaIndices = i + j + 2; //soma dos índices da matriz A começando em 2
                    resultado[i,j] = matrizA[i,j] / somaIndices;
                }
            }

            //Exibindo a nova matriz
            Console.WriteLine("\nNova matriz resultante da divisão dos elementos da matriz A pela soma de seus índices: ");
            for (int i = 0;i < 3; i++)
            {
                for (int j = 0;j < 3;j++)
                {
                    Console.Write(resultado[i,j]+"\t");
                }
                Console.WriteLine();
            }

        }
    }
}