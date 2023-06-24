namespace ConsoleApp_Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.getInstance();
            Singleton s2 = Singleton.getInstance();

            if (s1 == s2)
            {
                Console.WriteLine("É o mesmo objeto!");
            }

            Pessoa p1 = Pessoa.getInstance();
            Pessoa p2 = Pessoa.getInstance();

            p2.nome = "Londero";
            Console.WriteLine(p2.nome);

            p1.nome = "Fabrício";
            Console.WriteLine(p2.nome);
        }
    }
}