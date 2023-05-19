using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    internal class Circulo:Forma
    {
        public double Raio { get; set; }

        public override double CalcularArea()
        {
            return Math.PI * Raio * Raio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Raio;
        }

    }
}
