namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 05 - Crie uma classe Forma com os métodos CalcularArea e CalcularPerimetro.
            // Em seguida, crie as classes Retangulo e Circulo que herdam de Forma e implementam os métodos
            // CalcularArea e CalcularPerimetro de forma diferente.

            Retangulo retangulo = new Retangulo();
            retangulo.Largura = 5;
            retangulo.Altura = 3;
            Console.WriteLine("Área do retângulo: " + retangulo.CalcularArea());
            Console.WriteLine("Perímetro do retângulo: " + retangulo.CalcularPerimetro());

            Circulo circulo = new Circulo();
            circulo.Raio = 2;
            Console.WriteLine("Área do círculo: " + circulo.CalcularArea());
            Console.WriteLine("Perímetro do círculo: " + circulo.CalcularPerimetro());

            Console.ReadLine();

        }
    }
}