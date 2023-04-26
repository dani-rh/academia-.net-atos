namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 05 - Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel 
            //(medido em Km/ l), sendo que são conhecidos a distância total percorrida e o volume de combustível
            //consumido para percorrê-la(medido em l).
                        Console.WriteLine("Digite a distância percorrida: ");
            double distancia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite quantos litros de combustível foi consumido para percorrer essa distância: ");
            double volume = int.Parse(Console.ReadLine());

            double consumo = distancia / volume;
            Console.WriteLine("O consumo móvel do automóvel é de " + consumo + "km/l.");
        }
    }
}