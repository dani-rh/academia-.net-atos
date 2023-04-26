using System.Drawing;
using System;

namespace Exercicio_21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada(metros, centímetros, polegadas ou pés) e uma unidade de
            //medida de saída usando um menu com o comando switch case.O programa deve, em seguida, pedir ao usuário um valor de entrada e converter esse
            //valor para a unidade de saída selecionada.

            int opEntrada, opSaida;
            double valorEntrada, valorSaida;

            Console.WriteLine("Digite a unidade de medida de entrada: ");
            Console.WriteLine("1 - para metros\n2 - para centímetros");
            Console.WriteLine("3 - para polegadas\n4 - para pés");
            opEntrada = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a unidade de saída: ");
            Console.WriteLine("1 - para metros\n2 - para centímetros");
            Console.WriteLine("3 - para polegadas\n4 - para pés");
            opSaida = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para conversão: ");
            valorEntrada = double.Parse(Console.ReadLine());




        }
    }
}