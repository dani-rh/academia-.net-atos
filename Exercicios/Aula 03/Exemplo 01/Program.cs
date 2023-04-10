using System.Xml.Linq;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicios lista aula 03 


            //Exemplo 01:
            //Considere que será concedido um bonus aos trabalhadores de uma empresa, conforme o salário atual do vendedor, descrito abaixo. Desenvolva o algoritmo para ler
            //o salário e calcular o valor em reais do aumento. Exibir na tela, o salário atual, o aumento (% e R$) e o novo salário.

            Console.WriteLine("Digite o salário do funcionário: ");
            double salarioatual = int.Parse(Console.ReadLine());

            if (salarioatual <= 900)
            {
                double aumento1 = (salarioatual * 0.05);
                double novosalario1 = (aumento1 + salarioatual);
                Console.WriteLine("O Salário atual é de R$ " + salarioatual + "O aumento salário é de 5% e o valor do aumento é de R$ " + aumento1 + ". O novo salário será de: R$ " + novosalario1);
            }
            if (salarioatual > 900 && salarioatual < 1400)
            {
                double aumento2 = (salarioatual * 0.08);
                double novosalario2 = (aumento2 + salarioatual);
                Console.WriteLine("O Salário atual é de R$ " + salarioatual + "O aumento salário é de 8% e o valor do aumento é de R$ " + aumento2 + ". O novo salário será de: R$ " + novosalario2);
            }
            if (salarioatual >= 1400)
            {
                double aumento3 = (salarioatual * 0.10);
                double novosalario3 = (aumento3 + salarioatual);
                Console.WriteLine("O Salário atual é de R$ " + salarioatual + "O aumento salário é de 10% e o valor do aumento é de R$ " + aumento3 + ". O novo salário será de: R$ " + novosalario3);
            }

            ////Exercicio 02

            //Console.WriteLine("Digite o primeiro número: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo número: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o terceiro número: ");
            //double c = double.Parse(Console.ReadLine());
            //if (a < b + c && b < a + c && c < a + b)
            //{
            //    Console.Write("Os lados representam um triângulo");
            //    if (a == b && b == c)
            //    {
            //        Console.WriteLine(" equilátero.");
            //    }
            //    else if (a == b || a == c || b == c)
            //    {
            //        Console.WriteLine(" isósceles.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" escaleno.");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Os valores não representam um triângulo.");

            //Exercício 05 - terminar:
            ////Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” - media 7
            ///Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
            // é a média entre a nota do exame e a média das 2 notas.
            //Se esta média final for maior ou igual a 5, 0, o programa deve escrever “Aprovado”, caso contrário deve
            //escrever “Reprovado”.

            //Console.WriteLine("Digite a primeira nota: ");
            //int nota1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a segunda nota: ");
            //int nota2 = int.Parse(Console.ReadLine());

            //int media = (nota1 + nota2) / 2;

            //if (media >= 7)
            //{
            //    Console.WriteLine("Aprovado!");
            //}
            //else
            //{
            //    Console.WriteLine("Reprovado!");
            //}

            //Exercício 06
        }
}