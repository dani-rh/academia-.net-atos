namespace Anotações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - Orientações a Objetos
                // - Herança: sobreescrita
                // - Listas e coleções (listas, filas, pilhas, árvores, gráficos, hash...)
                // - Métodos e atributos (instância/objeto ou classe)
                //Console.WriteLine() - Console é a classe
                    String frase = "alexandre zamberlan;08/09/1974;masculino";
                    String[] vetor = frase.Split(';');

            // - Arquivo texto
            //- plain text
            //- JSON -> REST
            //- XML -> SOAP
            //- CSV



            // - Sistema
            // - Backend ------> Frontend
            //    BD ======== Regras de negócio ======== Nível do usuário


            //Desafio: Programa em C# no modo terminal, tendo como base o seguinte menu:

            //    Menu:
            // 1 - Cadastrar pessoa (controle de duplicidade: email)
            // 2 - Listar pessoa
            // 3 - Pesquisar pessoa (atributo nome como chave de pesquisa)
            // 4 - Excluir pessoa
            // 5 - Sair
            //Opção


            // Elementos necessários:
                // Classe pessoa (nome, email, dataNascimento(string)
                    // - método para gerar o email da pessoa automaticamente: sobrenome_nome@ufn.edu.br
                // Lista de pessoas
                    // - ordenação (Sort)
                //Arquivo
                    // - texto puro -> csv ou seja, separado por ;
                    // - StreamReader (classe leitora)
                    // - StreamWriter (classe escritora)


                // Cadastrar -> nome e dataNascimento -> constroi
                // Listar -> mostrar a lista
                // Pesquisar -> percorrer a lista a procura de alguma pessoa
                // Excluir -> pesquisar -> retirar da lista -> atualizar lista






        }
    }
}