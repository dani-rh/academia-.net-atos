namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 11 - Escreva um algoritmo para ler o número de eleitores de um município, 
            //o número de votos brancos, nulos e válidos.
            //Calcule e escreva o percentual que cada um  representa em relação ao total de eleitores.
            
            Console.WriteLine("Digite o número de eleitores no município: ");
            double numeroEleitores = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de votos brancos: ");
            double votosBrancos = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de votos nulos: ");
            double votosNulos = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de votos válidos: ");
            double votosValidos = double.Parse(Console.ReadLine());

            double PBrancos = (votosBrancos / numeroEleitores) * 100;
            Console.WriteLine("Votos brancos representam " + PBrancos + "%");
            double PNulos = (votosNulos / numeroEleitores) * 100;
            Console.WriteLine("Votos nulos representam " + PNulos + "%");
            double PValidos = (votosValidos / numeroEleitores) * 100;
            Console.WriteLine("Votos válidos representam " + PValidos + "%");
        }
    }
}