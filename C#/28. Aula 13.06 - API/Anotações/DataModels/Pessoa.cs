using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Anotações.DataModels
{
    public class Pessoa
    {
        
        public int id { get; set; }
        public string nome { get; set; }

        [JsonIgnore]

        public virtual ICollection<Email>? emails { get; set; }
    }
}
