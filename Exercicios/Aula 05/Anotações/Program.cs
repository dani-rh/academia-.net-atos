namespace Anotações
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ///*Estruturas de repetição
            // * Executar um mesmo procedimento diversas vezes.
            // * 3 tipos:
            // *  - For
            // *  - While
            // *  - Do...While
            // *  
            //    * For loop:
            // *  Permite implementar laços de repetição, ou seja, definir trechos do código de um programa que se repetem.
            // *  Como qualquer iteração, necessita de uma variável.
            // *  A variável contadora deverá ser inicializada com um valor e ser incrementada ou decrementada a cada loop.
            // *  Deveremos ter uma condição, testando se a quantidade de vezes que o laço deveria ser executado chegou ao fim ou não.
            // *  
            // *  Exemplo:
            // *  for (valor inicial*; condição**; incremento ou decremento)
            // *  {
            // *      <bloco de instruções>;
            // *  }
            // *  Após a condição ser atendida, segue o que estiver após o for
            // *  
            // *  * i = 0
            // *  ** enquanto a condição não for atendida, continua fazendo a instrução do loop.
            // */


            //Exemplo 01:
            int i;
            for (i = 0; i < 4; i++)
            {
                Console.WriteLine("i vale " + i);
            }


            //Exemplo 02 - Escreva um algoritmo que conte até 10:
            int i;
            for (i = 0; i < 11; i++)
            {
                Console.WriteLine("i é " + i);
            }


            //Exemplo 03 - Escreva um algoritmo que mostre todos os números de 20 a 5.
            int i;
            for (i = 20; i > 4; i--)
            {
                Console.WriteLine("i é " + i);
            }


            //Exemplo 05 - Escreva um algoritmo que leia pelo teclado os dois valores inteiros chamados inicio e fim, e então mostre todos os números entre inicio e fim.

            Console.WriteLine("Digite o número de início: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de fim: ");
            int fim = int.Parse(Console.ReadLine());
            int i;
            Console.WriteLine("Números entre " + inicio + " e " + fim + ":");

            if (inicio < fim)
            {
                for (i = (inicio + 1); inicio < fim; i++)
                {
                    Console.WriteLine("i vale " + i);
                }
            }
            else if (inicio > fim)
            {
                for (i = (inicio - 1); i > fim; i--)
                {
                    Console.WriteLine("i vale " + i);
                }
            }
            else
            {
                Console.WriteLine("Início igual ao fim.");
            }


            //Exemplo 06 - Escreva um algoritmo leia pelo teclado um valor inteiro chamado x, e então mostre na tela todos os números de 0 a 100, pulando de x em x.

            Console.WriteLine("Digite um valor inteiro para x: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i <= 100; i += x)
            {
                Console.WriteLine("i vale " + i);
            }



        }
    }
}