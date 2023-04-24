using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. A cada solicitação, teste se o usuário informou um valor válido. 
            //Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), informe que ele está incorreto e saia do programa em VS.
            //Se o nome for lido corretamente, solicite a idade.Se ela for incorreta(menor ou igual a zero), informe que está errada e saia.Se estiver correta, solicite o salário.
            //Se ele estiver incorreto(menor ou igual a zero), informe que está incorreto e saia.Se estiver correto, mostre todos os valores lidos.

            string nome = "";
            int idade = 0;
            double salario = 0;

            for (int i = 0; i < 3; i++)
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Digite seu nome: ");
                        nome = Console.ReadLine();
                        if (string.IsNullOrEmpty(nome) || int.TryParse(nome, out int n))
                        {
                            Console.WriteLine("Informação incorreta.");
                            return;
                        }
                        break;

                    case 1:
                        Console.WriteLine("Digite sua idade: ");
                        string idadeString = Console.ReadLine();
                        if (!int.TryParse(idadeString, out idade) || idade <= 0)
                        {
                            Console.WriteLine("Idade incorreta.");
                            return;
                        }
                        break;
                    case 2:
                        Console.WriteLine("Digite seu salário: ");
                        string salarioString = Console.ReadLine();
                        if (!double.TryParse(salarioString, out salario) || idade <= 0)
                        {
                            Console.WriteLine("Salário incorreto.");
                            return;
                        }
                        break;
                }
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Salário: " + salario);

        }
    }
}