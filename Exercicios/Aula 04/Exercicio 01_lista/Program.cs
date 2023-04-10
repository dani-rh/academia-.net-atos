namespace Exercicio_01_lista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01 - lista:
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