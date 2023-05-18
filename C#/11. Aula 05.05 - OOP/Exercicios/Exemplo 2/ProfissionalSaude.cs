using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_02
{
    internal class ProfissionalSaude
    {
        //3 elementos que ao mesmo tempo são métodos get and set
        public string Nome { get; set; }
        public string Tipo { get; set; }
        public string RegistroConselho { get; set; }

        public ProfissionalSaude() { }

        public ProfissionalSaude(string nome, string tipo, string registroConselho)
        {
            Nome = nome.ToUpper();
            Tipo = tipo.ToUpper();
            RegistroConselho = registroConselho.ToUpper();
        }

        public string SobreNome()
        {
            string[] lista = Nome.Split();

            return lista[lista.Length - 1] + " - " + RegistroConselho;
        }


    }
}
