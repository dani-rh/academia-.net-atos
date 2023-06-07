using System;
using System.Collections.Generic;

namespace DBFirst;

public partial class Pessoa
{
    public int Id { get; set; }

    public string Nome { get; set; } = null!;

    public virtual ICollection<Email> Emails { get; set; } = new List<Email>();
}
