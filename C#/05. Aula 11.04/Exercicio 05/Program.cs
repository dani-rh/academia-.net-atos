namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 05 - Escreva um algoritmo para calcular o fatorial de um número.

            Console.WriteLine("Digite um número inteiro positivo: ");
            int numero = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= numero; i++)
            {
                fatorial *= i; 
            }

            Console.WriteLine("O fatorial de " + numero + " é igual a " + fatorial + ".");

        }
    }
}