namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 07 - Classe Abstrata "ContaBancaria"
            //Crie uma classe abstrata chamada "ContaBancaria" com três propriedades abstratas: "Titular", "Saldo" e "TaxaDeJuros".
            //Em seguida, crie duas classes que herdam de "ContaBancaria": "ContaCorrente" e "ContaPoupanca".
            //Implemente as propriedades "Titular", "Saldo" e "TaxaDeJuros" para cada uma dessas classes.
            //Por fim, crie um objeto "ContaCorrente" e um objeto "ContaPoupanca", e imprima as suas propriedades na tela.

            ContaCorrente contaCorrente = new ContaCorrente
            {
                Titular = "Daniela",
                Saldo = 1000,
                TaxaDeJuros = 05
            };

            ContaPoupanca contaPoupanca = new ContaPoupanca
            {
                Titular = "Felippe",
                Saldo = 2000,
                TaxaDeJuros = 03
            };

            Console.WriteLine("Conta Corrente: ");
            Console.WriteLine("Titular: "+contaCorrente.Titular);
            Console.WriteLine("Saldo: "+contaCorrente.Saldo);
            Console.WriteLine("Taxa de Juros: "+contaCorrente.TaxaDeJuros);

            Console.WriteLine();

            Console.WriteLine("Conta Poupança:");
            Console.WriteLine("Titular: "+contaPoupanca.Titular);
            Console.WriteLine("Saldo: "+contaPoupanca.Saldo);
            Console.WriteLine("Taxa de Juros: "+contaPoupanca.TaxaDeJuros);
        }
    }
}