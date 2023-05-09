namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 - Crie uma classe chamada Conta que tenha as propriedades Número, Saldo e Limite.
            //Utilize o encapsulamento para garantir que o saldo nunca seja menor que zero
            //e que o limite seja positivo e que o Número da conta não possa ser alterado.

            Conta minhaConta = new Conta("12345-6", 1000, 500);

            Console.WriteLine("Número da conta: "+minhaConta.Numero);
            Console.WriteLine("Saldo: " +minhaConta.Saldo);
            Console.WriteLine("Limite: " +minhaConta.Limite);

            Console.ReadLine();


        }
    }
}