namespace Exemplo_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mar, mo;
            int ano;

            Carro c1 = new Carro();
            Carro c2 = new Carro();
            
            Console.WriteLine("Digite a marca do carro: ");
            c1.marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do carro: ");
            c1.modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricação: ");
            c1.anoFabricacao = Console.ReadLine();

            Console.WriteLine("Digite a marca do carro: ");
            c2.marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do carro: ");
            c2.modelo = Console.ReadLine();
            Console.WriteLine("Digite o ano de fabricação: ");
            c2.anoFabricacao = Console.ReadLine();

            Console.WriteLine("Carro 1: ");
            c1.exibeDados();
            Console.WriteLine("Carro 2: ");
            c2.exibeDados();

        }
    }
}