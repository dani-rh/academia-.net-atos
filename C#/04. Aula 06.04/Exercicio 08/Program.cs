namespace Exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 - Faça um programa no VS que receba o código, nome, salário base
            //e o total de vendas de um funcionário.
            //Caso o total de vendas seja acima de R$ 500,00, adicionar ao seu
            //salário final 5 % do total de vendas.
            //Caso o total de vendas seja mais que R$ 1000,00, adicionar ao seu
            //salário final 7 % do total de vendas.
            //E por fim, se o total de vendas seja maior que R$ 5000,00,
            //adicionar ao seu salário final 10 % do
            //total de vendas.

            Console.WriteLine("Digite o código do funcionário: ");
            int codigo;
            int.TryParse(Console.ReadLine(), out codigo);

            Console.WriteLine("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o salário base do funcionário: ");
            double salarioBase;
            double.TryParse(Console.ReadLine(), out salarioBase);

            Console.WriteLine("Digite o total de vendas do funcionário: ");
            double totalVendas;
            double.TryParse(Console.ReadLine(), out totalVendas);

            double salarioFinal = salarioBase;

            if (totalVendas > 500)
            {
                salarioFinal += totalVendas * 0.05;

                if (totalVendas > 1000)
                {
                    salarioFinal += totalVendas * 0.02;

                    if (totalVendas > 5000)
                    {
                        salarioFinal += totalVendas * 0.03;
                    }
                }
            }

            Console.WriteLine("Código: " + codigo);
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Salário final: " + salarioFinal.ToString("C"));

            Console.ReadLine();

        }
    }
}