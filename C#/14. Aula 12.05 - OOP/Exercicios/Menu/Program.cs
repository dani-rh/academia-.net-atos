using System;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //    Desafio: Programa em C# no modo terminal, tendo como base o seguinte MENU.

            //Menu
            //1 - Cadastrar pessoa(controle de duplicidade: email)
            //2 - Listar pessoa
            //3 - Pesquisar pessoa(atributo nome)
            //4 - Excluir pessoa
            //5 - Sair

            //Opção:
            //        Elementos necessários:
            //    Classe Pessoa(nome, email, dataNascimento(string))
            //        -método para gerar o email da pessoa automaticamente: sobrenome_nome @ufn.edu.br
            //    Lista de Pessoas
            //        -ordenação(Sort)
            //    Arquivo
            //        - texto puro->csv ou seja, separado por;
            //        -StreamReader(classe leitora)
            //        - StreamWriter(classe escritora)

            //    Cadastrar->nome e dataNascimento -> constroi objeto com email gerado->joga na lista -> atualizar arquivo
            //    Listar->mostrar a lista
            //    Pesquisar->percorrer a lista a procura de alguma pessoa
            //    Excluir->pesquisar->retirar da lista -> atualizar arquivo

            List<Pessoa> listaPessoas = new List<Pessoa>();
            string nomeArquivo = "dados.dat";
            Persistencia.popularArquivoLista(nomeArquivo, listaPessoas); //conectando com a base de dados

            string opcao;
            do {
                Console.WriteLine("1 - Cadastrar pessoa");
                Console.WriteLine("2 - Listar pessoa");
                Console.WriteLine("3 - Pesquisar pessoa");
                Console.WriteLine("4 - Excluir pessoa");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("Opção: ");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("Cadastrando pessoa");
                        //rotina para cadastrar pessoa
                        Comunicacao.cadastrar(listaPessoas, nomeArquivo);
                        break;
                    case "2":
                        Console.WriteLine("Listando pessoa");
                        //rotina para listar pessoa
                        Comunicacao.listar(listaPessoas);
                        break;
                    case "3":
                        Console.WriteLine("Pesquisando pessoa");
                        //rotina para pesquisar pessoa
                        Comunicacao.pesquisar(listaPessoa);
                        break;
                    case "4":
                        Console.WriteLine("Excluindo pessoa");
                        //rotina para excluir pessoa
                        Comunicacao.excluir(listaPessoas, nomeArquivo);
                        break;
                    case "5":
                        Console.WriteLine("Obrigada por usar o sistema.");
                        //rotina para sair
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                Console.WriteLine("Pressione algo para continuar.");
                Console.ReadKey();
            } while (opcao != "5");


            Persistencia.exibirLista(listaPessoas);

            Console.WriteLine("Digite o nome a ser excluído: ");
            nome = Console.ReadLine();

            bool removeu = false;
            foreach (var item in listaPessoas)
            {
                if (nomeArquivo == item.Nome)
                {
                    listaPessoas.Remove(item);
                    removeu = true;
                    break;
                }
            }

            if (removeu)
            {
                Persistencia.gravarListaArquivo(listaPessoas, "dados.dat");
            }




            //{
            //    List<Pessoa> listaPessoas = new List<Pessoa>();

            //}
        }
    }
}