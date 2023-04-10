namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 02 - Faça um algoritmo que leia 10 números pelo teclado, e que no final mostre o maior deles. Não usar vetor.
            
            int maior = 0; //variável para armazenar o maior número digitado
            int num; //variável para armazenar cada número digitado pelo usuário

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Digite o número " +i);
                num = int.Parse(Console.ReadLine());

                if (num > maior)
                {
                    maior = num; //Atualiza o valor de 'maior' se o número digitado for maior
                }
            }
            Console.WriteLine("O maior número digitado foi: " + maior);
            




        }
    }
}