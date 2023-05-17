namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Crie uma classe chamada Conta que tenha as propriedades Número, Saldo e Limite.
            //Utilize o encapsulamento para garantir que o saldo nunca seja menor que zero
            //e que o limite seja positivo e que o Número da conta não possa ser alterado.

            //Instanciando a conta:
            Conta minhaConta = new Conta("12345-6", 1000, 500);

            Console.WriteLine("Número da conta: "+minhaConta.Numero);
            Console.WriteLine("Saldo: " +minhaConta.Saldo);
            Console.WriteLine("Limite: " +minhaConta.Limite);

            // Realizar operações na conta
            try
            {
                Console.WriteLine("Digite um valor para depósito: ");
                double deposito = double.Parse(Console.ReadLine());
                minhaConta.Depositar(deposito);
                Console.WriteLine("Depósito realizado. Novo saldo: R$" + minhaConta.Saldo);

                Console.WriteLine("Digite um valor para saque: ");
                double saque = double.Parse(Console.ReadLine());
                minhaConta.Sacar(saque);
                Console.WriteLine("Saque realizado. Novo saldo: R$" + minhaConta.Saldo);

                //Teste para sacar um valor maior que o saldo disponível
                Console.WriteLine("Tente sacar um valor maior que o saldo disponível: ");
                double maior = double.Parse(Console.ReadLine());
                minhaConta.Sacar(maior);
                Console.WriteLine("Saque realizado. Novo saldo: R$" + minhaConta.Saldo);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

            Console.ReadKey();


        }
    }
}