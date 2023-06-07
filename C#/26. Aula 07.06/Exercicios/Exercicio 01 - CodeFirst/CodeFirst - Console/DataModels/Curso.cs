using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst___Console.DataModels
{
    public class Curso
    {
        public int id { get; set; }
        public string nome { get; set; }

        public virtual Aluno aluno{ get; set; }
    }
}
