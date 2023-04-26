using System.IO;
using System.Runtime.ConstrainedExecution;

namespace Exercicio_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 15 - Faça um programa para uma loja de tintas. O programa deverá pedir o tamanho em metros quadrados 
            //da área a ser pintada. Considere que a cobertura da tinta é de 1 litro para cada 3 metros quadrados
            //e que a tinta é vendida em latas de 18 litros, que custam R$ 80,00.
            //Informe ao usuário a quantidades de latas de tinta a serem compradas e o preço total.

            //1 litro -> 3 metros quadrados
            //quantidade = area*1 / 3
            //tinta vendida - 18 litros
            //18 litros custa 80 reais
            //ler o tamanho, falar quanto de litros vai de tinta
            //pegar a quantidade de latas e calcular o valor

            double area, quantidade, valortotal, quantidadeLatas, quantidadeLatasCeiling, quantidadeLatasFloor;
            
            Console.WriteLine("Digite e área a ser pintada: ");
            area = double.Parse(Console.ReadLine());
            quantidade = area / 3;
            quantidadeLatas = quantidade / 18;

            quantidadeLatasCeiling = Math.Ceiling(quantidadeLatas);
            quantidadeLatasFloor = Math.Floor(quantidadeLatas);


            Console.WriteLine("A área de " +area + " precisará de " +quantidade+ " litros de tinta.");
            Console.WriteLine("Será necessário comprar " +quantidadeLatas+ " latas de tinta.");
            valortotal = quantidadeLatasCeiling * 80;
            Console.WriteLine("Será necessário comprar " +quantidadeLatasCeiling+ " latas de tinta. - Ceiling");
            Console.WriteLine("Será necessário comprar " +quantidadeLatasFloor+ " latas de tinta - Floor");
            Console.WriteLine("Custará R$ " +valortotal);



        }
    }
}