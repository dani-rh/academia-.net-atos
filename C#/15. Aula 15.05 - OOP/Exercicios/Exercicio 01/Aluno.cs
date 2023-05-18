using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class Aluno : Pessoa
    {
        public string Matricula { get; set; }

        public void Apresentar ()
        {
            base.Apresentar ();
            Console.WriteLine("Matrícula: "+Matricula);
        }
    }
}
