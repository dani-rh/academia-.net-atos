namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 01 - Faça um programa em VS que solicite um número inteiro positivo ao usuário, validando a entrada de dados
            //(informando se ele estiver errado e repetindo a solicitação até que esteja correto). 
            //Após o programa em VS deve informar todos os números pares existentes entre 1 e o número fornecido pelo usuário.

            int numero = 0;
            for (;numero <= 0 ;)
            {
                Console.WriteLine("Digite um número inteiro positivo: ");
                if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                {
                    Console.WriteLine("Valor incorreto!");
                }
            }
            Console.WriteLine("Número digitado: "+numero);
            Console.Write("Números inteiros pares entre 1 e " + numero+ ": ");
            for (int i = 1; i < numero; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(i+ ", ");
                }
            }
        }
    }
}