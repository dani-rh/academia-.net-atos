using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercício 01 - Faça um algoritmo para calcular e mostrar a área de um triângulo a partir dos valores da base e da altura lidos pelo teclado: 
            //Área do triangulo = (base * altura) / 2;
            //Teste se a base ou a altura digitada não foi igual a zero.

            Console.WriteLine("Digite o valor da base do triângulo: ");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do triângulo: ");
            double alturaTriangulo = double.Parse(Console.ReadLine());

            if (baseTriangulo != 0 && alturaTriangulo != 0)
            {
                double areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;
                Console.WriteLine("A área do triângulo é: " + areaTriangulo);
            }
            else
            {
                Console.WriteLine("A base ou a altura não pode ser igual a zero!");
            }
        }
    }
}