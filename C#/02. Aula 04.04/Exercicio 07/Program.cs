namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 07 - Escreva um programa em C# e no Visual Studio que leia o número de um vendedor, o seu salário fixo, 
            //o total de vendas por ele efetuadas e o percentual que ganha sobre o total de vendas.
            //Calcule o salário total do vendedor.Escreva o número do vendedor e o salário total do vendedor.
            int numeroVendedor;
            double salarioFixo, totalVendas, percentualComissao, salarioTotal;

            Console.Write("Digite o número do vendedor: ");
            numeroVendedor = int.Parse(Console.ReadLine());

            Console.Write("Digite o salário fixo do vendedor: R$ ");
            salarioFixo = double.Parse(Console.ReadLine());

            Console.Write("Digite o total de vendas do vendedor: R$ ");
            totalVendas = double.Parse(Console.ReadLine());

            Console.Write("Digite o percentual de comissão do vendedor: ");
            percentualComissao = double.Parse(Console.ReadLine());

            salarioTotal = salarioFixo + (totalVendas * percentualComissao / 100);

            Console.WriteLine($"O salário total do vendedor {numeroVendedor} é R$ {salarioTotal:N2}.");
        }
    }
}