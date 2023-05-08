
    using Exercicio_02;
        
        UnidadeSaude obj1 = new UnidadeSaude("Unidade São José", "USJ");

    //milhares de linhas de código depois

    obj1.Responsavel.Nome = "Alexandre de Oliveira Zanberlan!;
    obj1.Responsavel.Tipo = "enfermEiro";
    obj1.Responsavel.RegistroConselho = "TEC123";

    
    Paciente pac1 = new Paciente("Leandro Lazarin", "9887879798797", DateOnly.Parse("1974/08/09"), "laza@ufn.edu.br");

    ProfissionalSaude resp1 = new ProfissionalSaude("Daniela Rodrigues", "Enfemeiro", "Enf1231");

    Triagem t1 = new Triagem(resp1, pac1, 88, 1.88, 122, 38, "amarelo");

    



