namespace Exercicio_01_use
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01 - Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre dois números quaisquer.

            double a;
            double b;
            Console.WriteLine("Digite um valor para A: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para B: ");
            b = double.Parse(Console.ReadLine());
            double media = (a + b) / 2;
            Console.WriteLine("A média aritmética é: " + media);
        }
    }
}