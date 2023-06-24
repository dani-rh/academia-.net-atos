using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Singleton
{
    internal class Pessoa
    {
        private static Pessoa pessoa = new Pessoa();

        public string nome = null;

        private Pessoa ()
        {

        }

        public static Pessoa getInstance()
        {
            return pessoa;
        }

    }
}
