namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 04 - Crie uma classe Conta com as propriedades Numero e Saldo.
            //Em seguida, crie as classes ContaCorrente e ContaPoupanca que herdam de Conta e
            //adicionam uma propriedade TaxaDeJuros e LimiteDeCredito, respectivamente.

            ContaCorrente contaCorrente = new ContaCorrente();
            {
                contaCorrente.Numero = 1234;
                contaCorrente.Saldo = 500;
                contaCorrente.TaxadeJuros = 1.5;
            }

            ContaPoupanca contaPoupanca = new ContaPoupanca();
            {
                contaPoupanca.Numero = 9876;
                contaPoupanca.Saldo = 500;
                contaPoupanca.LimiteDeCredito = 900;
            }

            contaCorrente.Mostrar();
            Console.WriteLine();
            contaPoupanca.Mostrar();

        }
    }
}