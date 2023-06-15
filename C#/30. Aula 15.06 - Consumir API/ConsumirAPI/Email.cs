using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumirAPI
{
    internal class Email
    {
        public int id { get; set; }
        public string email { get; set; }

        [JsonIgnore]
        public virtual Pessoa pessoa { get; set; }
    }
}
