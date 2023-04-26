namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 02 - Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre quatro números quaisquer.
            double a;
            double b;
            double c;
            double d;
            Console.WriteLine("Digite um valor para A: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para B: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para C: ");
            c = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para D: ");
            d = double.Parse(Console.ReadLine());
            double mediaq = (a + b + c + d) / 4;
            Console.WriteLine("A média aritmética entre esses quatro números é: " + mediaq);
        }
    }
}