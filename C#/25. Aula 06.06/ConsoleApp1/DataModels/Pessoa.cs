using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DataModels
{
    internal class Pessoa
    {
        public int id { get; set; }
        public string nome { get; set; }

        public virtual ICollection<Email> emails { get; set; }
    }
}
