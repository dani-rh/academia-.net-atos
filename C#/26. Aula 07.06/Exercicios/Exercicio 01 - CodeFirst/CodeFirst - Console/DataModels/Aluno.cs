using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst___Console.DataModels
{
    public class Aluno
    {
        public int matricula { get; set; }
        public string nome { get; set; }

        public virtual ICollection<Curso> cursos{ get; set; }
    }
}
