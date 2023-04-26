using System.Runtime.Intrinsics.X86;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 04 - Faça um programa em C# e no Visual Studio que receba a data na forma DDMMAAAA e imprima na 
            //forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis diferentes.
            
            Console.WriteLine("Digite um dia: ");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um mês: ");
            int mês = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um ano: ");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("A data DDMMAAAA é: " + dia + mês + ano);
            Console.WriteLine("A data AAAAMMDD é: " + ano + mês + dia);
        }
    }
}