using System;
using System.Collections.Generic;

namespace DBFirst;

public partial class Pessoa
{
    public int id { get; set; }

    public string nome { get; set; } = null!;

    public virtual ICollection<Email> emails { get; set; } = new List<Email>();
}
