using ConsoleApp1.DataModels;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite:\n" +
                "1 para criar uma pessoa\n" +
                "2 para alterar o nome da pessoa\n" +
                "3 para inserir um email\n" +
                "4 para excluir uma pessoa\n" +
                "5 para consultar TUDO\n" +
                "6 para consultar pelo ID"
                );

            int op = int.Parse(Console.ReadLine());

            Contexto contexto = new Contexto();

            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Insera o nome da pessoa:");
                        Pessoa p = new Pessoa();
                        p.nome = Console.ReadLine();

                        //modo 1
                        Console.WriteLine("Insira um email:");
                        string emailTemp = Console.ReadLine();

                        p.emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };

                        //modo 2
                        //Email e = new Email();
                        //Console.WriteLine("Insira um email:");
                        //e.email = Console.ReadLine();

                        //p.emails = new List<Email>();
                        //p.emails.Add(e);

                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();

                        Console.WriteLine("Pessoa inserida com sucesso!");

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;

                case 2:
                    try
                    {



                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                default:
                    break;


            }
        }
    }
}