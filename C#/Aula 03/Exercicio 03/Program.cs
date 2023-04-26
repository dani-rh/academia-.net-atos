namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 03 - Escrever um algoritmo para ler quatro valores inteiros, calcular a sua média, e escrever na tela os que são superiores à média.
            double n1, n2, n3, n4, m;
            Console.WriteLine("Digite n1: ");
            n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite n2: ");
            n2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite n3: ");
            n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite n4: ");
            n4 = double.Parse(Console.ReadLine());
            m = (n1 + n2 + n3 + n4) / 4;
            if (n1 > m)
            {
                Console.WriteLine("N1 maior que a média.");
            }
            if (n2 > m)
            {
                Console.WriteLine("N2 maior que a média.");
            }
            if (n3 > m)
            {
                Console.WriteLine("N3 maior que a média.");
            }
            if (n4 > m)
            {
                Console.WriteLine("N4 maior que a média.");
            }
        }
    }
}