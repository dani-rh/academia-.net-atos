namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 02

            Console.WriteLine("Digite o primeiro número: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            double c = double.Parse(Console.ReadLine());
            if (a < b + c && b < a + c && c < a + b)
            {
                Console.Write("Os lados representam um triângulo");
                if (a == b && b == c)
                {
                    Console.WriteLine(" equilátero.");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine(" isósceles.");
                }
                else
                {
                    Console.WriteLine(" escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Os valores não representam um triângulo.");
            }

        }
    }
}