namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que leia pelo teclado um valor e então calcule a tabuada de 1 a 10 de um número x lido utilizando laços de repetição, e mostre na tela.

            Console.WriteLine("Digite um valor: ");
            int x = int.Parse(Console.ReadLine());
            
            for (int i = 0; i <= 10; i++)
            {
                int multi = x * i;
                Console.WriteLine(x+ " X " +i+ " = " + multi);
            }
        }
    }
}