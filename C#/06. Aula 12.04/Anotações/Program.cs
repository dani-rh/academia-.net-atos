using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace Anotações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //For - controle do laço
            //O comando break faz com que todo lado de repetição seja finalizado, antes mesmo da condição do for se tornar falsa.
            //O comando continue faz com que a interação atual do laço de repetição seja finalizada, e então seguir para a próxima interação.

            //Exemplo 01
            int i, op;
            for (i = 0; i < 10; i++)
            {
                if (i == 3)
                {
                    continue; //ele desconsidera abaixo e sobe pro incremento
                    if (i == 7)
                    {
                        break; //finaliza o laço de repetição
                        Console.WriteLine("i vale " + i);
                    }
                }
            }

            //Exemplo 02 - Escreva um algoritmo que leia pelo teclado o valor de uma variável inteira chamado opção, porém,
            //o programa só pode seguir sua execução caso o valor de opção seja entre 1 e 4.
            //Se o valor digitado não for entre 1 e 4, a variável opção deverá ser lida novamente pelo teclado.

            int i, op = 0;
            while (true)//for(; ;)
            {
                Console.WriteLine("Digite 0 ou 1 ou 2 ou 3 ou 4");
                op = int.Parse(Console.ReadLine());
                if (op > 4 || op < 1)
                {
                    Console.WriteLine("Digite um valor válido entre 1 e 4");
                    continue;
                }
                else
                {
                    Console.WriteLine("Opção " + op + " escolhida!");
                    break;
                }
            }
            switch (op)
            {
                case 1:
                    Console.WriteLine("Primeira opção!");
                    break;
                case 2:
                    Console.WriteLine("Segunda opção!");
                    break;
                case 3:
                    Console.WriteLine("Terceira opção!");
                    break;
                case 4:
                    Console.WriteLine("Quarta opção!");
                    break;
            }

            ////Exemplo 03 - for dentro de um for, dentro de um for, dentro de um for

            int i, j, k;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("i " + i);
                for (j = 0; j < 5; j++)
                {
                    Console.WriteLine("j " + j);
                    for (k = 0; k < 3; k++)
                    {
                        Console.WriteLine("k " + k);
                    }
                }
            }




        }
    }
}