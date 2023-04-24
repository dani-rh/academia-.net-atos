namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 06 - Usando operador ternário "?"
            int i;
            i = int.Parse(Console.ReadLine());
            Console.WriteLine(i+" é "+(i % 2 == 0 ? "par" : "impar"));
        }
    }
}