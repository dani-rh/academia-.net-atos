using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public void Apresentar ()
        {
            base.Apresentar ();
            Console.WriteLine("Disciplina: "+Disciplina);
        }

    }
}
