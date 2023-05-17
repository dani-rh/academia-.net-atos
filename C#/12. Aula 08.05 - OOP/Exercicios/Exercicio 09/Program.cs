using System.Drawing;

namespace Exercicio_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 09 - Crie uma classe chamada ContaBancaria que tenha as propriedades NumeroConta, Titular, Saldo e Limite. Crie também
            //um método chamado Depositar, que recebe um valor e adiciona ao saldo da conta, e um método Sacar, que recebe um
            //valor e verifica se o saldo é suficiente para a operação.

            ContaBancaria conta = new ContaBancaria();

            conta.NumeroConta = "897-6";
            conta.Titular = "Daniela Rodrigues Haeitmann";
            conta.Saldo = 900;
            conta.Limite = 500;

            Console.WriteLine("Saldo: " +conta.Saldo);

            Console.WriteLine("Digite o valor que será depositado: ");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.Depositar(valorDeposito);
            Console.WriteLine("Saldo: "+conta.Saldo);

            Console.WriteLine("Digite o valor que será sacado: ");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Sacar(valorSaque);

            Console.WriteLine("Saldo atual da conta: " + conta.GetSaldo());

            Console.ReadKey();
        }
    }
}