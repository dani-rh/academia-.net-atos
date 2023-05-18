namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //14 - Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes operações:
            //void armazenaPessoa(String nome, int idade, float altura);
            //void removePessoa(String nome);
            //Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
            //void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda

            Agenda agenda = new Agenda();

            while (true)
            {
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Adicionar pessoa.");
                Console.WriteLine("2 - Remover pessoa.");
                Console.WriteLine("3 - Buscar pessoa.");
                Console.WriteLine("4 - Imprimir agenda.");
                Console.WriteLine("5 - Sair.");

                string opcao = Console.ReadLine();  

                switch (opcao)
                {
                    //Adicionar pessoa
                    case "1":
                        Console.WriteLine("Digite o nome da pessoa:");
                        string nome = Console.ReadLine();
                        Console.WriteLine("Digite a idade da pessoa:");
                        int idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a altura da pessoa:");
                        float altura = float.Parse(Console.ReadLine());
                        agenda.ArmazenaPessoa(nome, idade, altura);
                        Console.WriteLine("Pessoa adicionada com sucesso.");
                        break;

                    case "2":
                        Console.WriteLine("Digite o nome da pessoa a ser removida: ");
                        string nomeRemover = Console.ReadLine();
                        agenda.RemovePessoa(nomeRemover);
                        break;
                    case "3":
                        Console.WriteLine("Digite o nome da pessoa a ser buscada: ");
                        string nomeBuscar = Console.ReadLine();
                        Pessoa pessoaEncontrada = agenda.BuscaPessoa(nomeBuscar);

                        if (pessoaEncontrada != null)
                        {
                            Console.WriteLine($"Pessoa encontrada: Nome: {pessoaEncontrada.Nome}, Idade: {pessoaEncontrada.Idade}, Altura: {pessoaEncontrada.Altura}");
                        }
                        else
                        {
                            Console.WriteLine("Pessoa não encontrada na agenda.");
                        }
                        break;

                    case "4":
                        agenda.ImprimeAgenda();
                        break;
                    case "5":
                        Console.WriteLine("Encerrando o programa...");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Digite um número de 1 a 5 para selecionar uma opção.");
                        break;
                }

                Console.WriteLine();

            }

        }
    }
}