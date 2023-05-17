using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_12
{
    internal class Carro
    {
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Velocidade += 10;
        }

        public void Frear()
        {
            if (Velocidade >= 10)
                Velocidade -= 10;
            else
                Velocidade = 0;
        }
    }
}
