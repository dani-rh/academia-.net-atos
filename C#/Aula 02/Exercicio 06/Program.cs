using System.Drawing;

namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 06 - Escreva um programa em C# e no Visual Studio que leia os dados para o parafuso A e para o parafuso B, 
            //isto é, o código, a quantidade de peças e o valor unitário de cada parafuso e a porcentagem
            //de IPI(única) a ser acrescentada.

            Console.Write("Digite o código do parafuso A: ");
            int codigoA = int.Parse(Console.ReadLine());

            Console.Write("Digite o código do parafuso B: ");
            int codigoB = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de peças do parafuso A: ");
            int quantidadeA = int.Parse(Console.ReadLine());

            Console.Write("Quantidade de peças do parafuso B: ");
            int quantidadeB = int.Parse(Console.ReadLine());

            Console.Write("Valor unitário do parafuso A: R$ ");
            double valorUniA = double.Parse(Console.ReadLine());

            Console.Write("Valor unitário do parafuso B: R$ ");
            double valorUniB = double.Parse(Console.ReadLine());

            Console.Write("Porcentagem de IPI do parafuso A: ");
            double IpiA = double.Parse(Console.ReadLine());

            Console.Write("Porcentagem de IPI do parafuso B: ");
            double IpiB = double.Parse(Console.ReadLine());

            // Cálculo dos valores totais (incluindo IPI) para cada parafuso
            double totalA = quantidadeA * valorUniA * (1 + IpiA / 100);
            double totalB = quantidadeB * valorUniB * (1 + IpiB / 100);

            // Exibição dos resultados na tela
            Console.WriteLine("\nValores totais:");
            Console.WriteLine("Parafuso A - Código: " + codigoA + ", Total: R$ " + totalA);
            Console.WriteLine("Parafuso B - Código: " + codigoB + ", Total: R$ " + totalB);
        }
    }
}