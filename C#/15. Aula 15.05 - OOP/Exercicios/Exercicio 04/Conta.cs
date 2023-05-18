using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_04
{
    internal class Conta
    {
        public int Numero { get; set; }

        public double Saldo { get; set; }

        public void Mostrar()
        {
            Console.WriteLine("Número da conta: " + Numero);
            Console.WriteLine("Saldo da conta: " + Saldo);
        }
    }
}
