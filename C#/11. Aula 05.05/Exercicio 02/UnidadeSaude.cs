using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_02
{
    internal class UnidadeSaude
    {
        //2 atributos
        public string Nome { set; get; }
        public string Sigla { get; set; }
        public ProfissionalSaude Responsavel { set; get; }

  
        public UnidadeSaude()
        {
            Responsavel = new ProfissionalSaude();
        }

        public UnidadeSaude(string nome, string sigla)
        {
            Nome = nome.ToUpper();
            Sigla = sigla.ToUpper();
            Responsavel = new ProfissionalSaude();//instanciando um responsavel, mas sem defini-lo
        }

        public UnidadeSaude(string nome)
        {
            Nome = nome.ToUpper();
            Responsavel = new ProfissionalSaude();
        }

        //sobrecarga - funciona de 3 jeitos diferentes
        //polimorfismo
        //teoria dos conjuntos



    }
}
