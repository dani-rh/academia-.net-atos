namespace Anotações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 01:
            //Considere que será concedido um bonus aos trabalhadores de uma empresa, conforme o salário atual do vendedor, descrito abaixo. Desenvolva o algoritmo para ler
            //o salário e calcular o valor em reais do aumento. Exibir na tela, o salário atual, o aumento (% e R$) e o novo salário.

            Console.WriteLine("Digite o salário do funcionário: ");
            double salarioatual = int.Parse(Console.ReadLine());

            if (salarioatual <= 900)
            {
                double aumento1 = (salarioatual * 0.05);
                double novosalario1 = (aumento1 + salarioatual);
                Console.WriteLine("O Salário atual é de R$ " + salarioatual + "O aumento salário é de 5% e o valor do aumento é de R$ " + aumento1 + ". O novo salário será de: R$ " + novosalario1);
            }
            if (salarioatual > 900 && salarioatual < 1400)
            {
                double aumento2 = (salarioatual * 0.08);
                double novosalario2 = (aumento2 + salarioatual);
                Console.WriteLine("O Salário atual é de R$ " + salarioatual + "O aumento salário é de 8% e o valor do aumento é de R$ " + aumento2 + ". O novo salário será de: R$ " + novosalario2);
            }
            if (salarioatual >= 1400)
            {
                double aumento3 = (salarioatual * 0.10);
                double novosalario3 = (aumento3 + salarioatual);
                Console.WriteLine("O Salário atual é de R$ " + salarioatual + "O aumento salário é de 10% e o valor do aumento é de R$ " + aumento3 + ". O novo salário será de: R$ " + novosalario3);
            }


        }
    }
}