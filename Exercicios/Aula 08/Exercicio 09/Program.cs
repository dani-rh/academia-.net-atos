namespace Exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 09 - Leia uma matriz 3x3. Em seguida, solicite um número qualquer ao usuário e pesquise
            //na matriz se o número existe.  
            //Caso, seja verdade imprima a mensagem:  “O número existe no vetor”
            //caso contrário “Número inexistente”.

            //Populando a matriz 3x3 com valores aleatórios

            int[,] matriz = new int[3, 3];
            Random random = new Random();

            Console.WriteLine("Matriz : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matriz[i, j] = random.Next(0, 50);
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }

            //Solicitando um número qualquer ao usuário
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            //Checando se o número existe na matriz:
            bool existe = false;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (matriz[i,j] == numero)
                    {
                        existe = true;
                        break;
                    }
                }
            }

            //Imprimindo a mensagem solicitada
            if (existe)
            {
                Console.WriteLine("O número existe no vetor.");
            }
            else
            {
                Console.WriteLine("Número inexistente.");
            }

        }
    }
}