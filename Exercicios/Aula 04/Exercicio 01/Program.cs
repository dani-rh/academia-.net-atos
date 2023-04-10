namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 9:
                    Console.WriteLine("o numero digitado é 9");
                    break;
                case 10:
                    Console.WriteLine("o numero digitado é 10");
                    break;
                default:
                    Console.WriteLine("o numero digitado não é 9 nem 10");
                    break;
            }
        }
    }
}