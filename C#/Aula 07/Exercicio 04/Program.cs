namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 04. Escreva um algoritmo que leia dois vetores de 10 posições e faça a multiplicação
            // dos elementos de mesmo índice, colocando o resultado em um terceiro vetor.
            // Mostre o vetor resultante.

            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];

            int[] vetorResultado = new int[10];

            Console.WriteLine("Digite os valores do primeiro vetor: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Vetor 1 = ", (i+1));
                vetor1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDigite os valores do segundo vetor: ");
            for (int i = 0; i < 10;i++)
            {
                Console.WriteLine("Vetor 2 = ", (i+1));
                vetor2[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nMultiplicando os vetores: ");
            for (int i = 0; i< 10;i++)
            {
                vetorResultado[i] = vetor1[i] * vetor2[i];
                Console.WriteLine("VetorResultado[{0}] = {1}", i, vetorResultado[i]);
            }
        }
    }
}