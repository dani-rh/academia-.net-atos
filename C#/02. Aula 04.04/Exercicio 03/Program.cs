namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 03 - Escreva a seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre 
            // si os valores de duas variáveis A e B.

            Console.WriteLine("Digite um valor para A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para B: ");
            int b = int.Parse(Console.ReadLine());

            int c = a;
            a = b;
            b = c;
            Console.WriteLine("O valor de A é: " + a + " e " + "o valor de B é: " + b);
        }
    }
}