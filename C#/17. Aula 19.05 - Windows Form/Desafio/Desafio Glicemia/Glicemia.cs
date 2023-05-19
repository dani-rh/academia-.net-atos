using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Glicemia
{
    internal class Glicemia :IComparable 
    {
        public int valor;
        
        public string data;

        public Glicemia(string data, int valor)
        {
            this.valor = valor;
            this.data = data;
        }

        public int CompareTo(object? obj)
        {
            Glicemia g = (Glicemia)obj;
            if(this.valor == g.valor)
            {
                return 0;
            } else if (this.valor < g.valor) //criterio de ordenação
            {
                return -1;
            }
        }

        public override string ToString()
        {
            return data + " - " + valor;
        }

    }
}
