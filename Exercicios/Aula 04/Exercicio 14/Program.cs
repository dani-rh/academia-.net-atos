namespace Exercicio_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um programa que peça o tamanho de um arquivo para download(em MB) e a velocidade de um
            //link de Internet(em Mbps). Em seguida, calcule e informe o tempo aproximado de download
            //do arquivo usando este link(em minutos).

            double tamanho, velocidade, tempo, velocidadeMB, tempoMinuto;
            Console.WriteLine("Digite o tamanho do arquivo");
            tamanho = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a velocidade do link");
            velocidade = double.Parse(Console.ReadLine());

            velocidadeMB = velocidade * 0.125;

            tempo = tamanho / velocidadeMB;

            Console.WriteLine("O tempo em segundos é = " +tempo);

            tempoMinuto = tempo / 60;
            ArraySegment = (int)tempo % 60;
            Console.WriteLine("O tempo em minutos é = " + tempoMinuto + " e ");

        }
    }
}