using System;
using System.Collections.Generic;

namespace DBFirst;

public partial class Email
{
    public int Id { get; set; }

    public string Email1 { get; set; } = null!;

    public int? FkPessoa { get; set; }

    public virtual Pessoa? FkPessoaNavigation { get; set; }
}
