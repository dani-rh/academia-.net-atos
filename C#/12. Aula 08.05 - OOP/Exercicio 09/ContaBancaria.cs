using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_09
{
    internal class ContaBancaria
    {
        private string _numeroConta;
        private string _titular;
        private double _saldo;
        private double _limite;

        public string NueroConta { get; set; }

        public string Titular
        {
            get
            {
                return _titular;
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _titular = value.ToUpper();
                }
            }
        }

        public double Saldo
        {
            get { return _saldo; }
        }

        public double Limite
        {
            get { return _limite; }
            set
            {
                if(value > 0)
                {
                    _limite = value;
                }
            }
        }

        public void Depositar (double valDeposito)
        {
            if(valDeposito > 0)
            {

            }
        }


    }
}
