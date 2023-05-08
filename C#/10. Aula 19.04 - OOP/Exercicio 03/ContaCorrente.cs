using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_03
{
    internal class ContaCorrente
    {
        public double saldo;

        public void definirSaldoInicial ()
        {
            Console.WriteLine("Digite o saldo inicial da conta: ");
            saldo = double.Parse(Console.ReadLine());
        }
        public void depositar ()
        {
            Console.WriteLine("Digite o valor que será depositado: ");
            double valor = double.Parse(Console.ReadLine());
            saldo += valor;
        }
        public bool sacar ()
        {
            Console.WriteLine("Digite o valor que será sacado: ");
            double valor = double.Parse(Console.ReadLine());

            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para saque!");
                return false;
            }
        }
        public double getSaldo()
        {
            return saldo;
        }

    }
}
