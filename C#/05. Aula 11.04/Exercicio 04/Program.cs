namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Escreva um algoritmo que leia dois valores pelo teclado, x e y, e em seguida calcule a potência de x elevado na y sem utilizar a função pow.

            Console.WriteLine("Digite um valor para x: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para y: ");
            int y = int.Parse(Console.ReadLine());

            int resultado = 1;

            for (int i = 0; i < y; i++) 
            {
                resultado *= x;
            }

            Console.WriteLine("O resultado de " + x + " elevado a " + y + " é " + resultado+ ".");

        }
    }
}