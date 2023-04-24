namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7 Escreva um programa em C# leia 20 números e que conte a quantidade de números pares e ímpares digitados por um usuário. Apresente o resultado.

            int n, i, par = 0, impar = 0;

            for (i = 0; i < 20; i++)
            {
                Console.WriteLine("Digite um número: ");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine("Foram digitados " + par + " números pares.");
            Console.WriteLine("Foram digitados " +impar+ " números ímpares."); ;
        }
    }
}