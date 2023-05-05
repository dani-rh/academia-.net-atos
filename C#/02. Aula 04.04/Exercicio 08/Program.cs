namespace Exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 08 - Ler uma temperatura em graus Celsius e apresentá-la convertida em graus Fahrenheit. 
            //A fórmula da conversão é F = (9 * C + 160) / 5.
                        Console.WriteLine("Digite uma temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (9 * celsius + 160) / 5;
            Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);
        }
    }
}