using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    internal class Conta
    {
        private string _numero;
        private double _saldo;
        private double _limite;

        public Conta(string  numero, double saldo, double limite) 
        {
            _numero = numero;
            _saldo = saldo;
            _limite = limite;
        }

        public string Numero
        {
            get { return _numero; }
        }

        public double Saldo
        {
            get { return _saldo; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O saldo não pode ser negativo.");
                }
                _saldo = value;
            }
        }

        public double Limite
        {
            get { return _limite; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("O limite deve ser positivo.");
                }
                _limite = value;
            }
        }

        public void Depositar (double valor)
        {
            Saldo += valor;
        }

        public void Sacar (double valor)
        {
            if (Saldo - valor < 0)
            {
                throw new ArgumentException("Saldo insuficiente para realizar o saque.");
            }
            Saldo -= valor;
        }

    }
}
