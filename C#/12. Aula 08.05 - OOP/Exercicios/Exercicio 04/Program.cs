using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4 - Crie uma classe chamada Pessoa que tenha as propriedades Nome e Idade.
            //Utilize o encapsulamento para garantir que o nome não seja vazio e que a idade seja maior que zero.

            Pessoa p = new Pessoa();

            try
            {
                Console.WriteLine("Digite o nome da pessoa: ");
                p.Nome = Console.ReadLine();

                Console.WriteLine("Digite a idade da pessoa: ");
                p.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome: " + p.Nome);
                Console.WriteLine("Idade: " + p.Idade);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
                Console.WriteLine("Digite qualquer tecla para sair.");
            }
            Console.ReadKey();
        }
    }
}