namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 02 - Escreva um algoritmo que leia valores para dois vetores de 20 elementos
            // e então realize a soma dos elementos da mesma posição, armazenando o resultado em um outro vetor.

            int[] valores1 = new int[20];
            int[] valores2 = new int[20];
            int[] soma = new int[20];

            for (int i = 0; i < valores1.Length; i++)
            {
                Console.Write("Informe um valor para a posição " + (i+1) + ": ");
                valores1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < valores2.Length; i++)
            {
                Console.Write("Informe um valor para a posição " + (i + 1) + ": ");
                valores2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < soma.Length; i++)
            {
                soma[i] = valores1[i] + valores2[i];
                Console.WriteLine("A soma da posição " +(i+1)+ " é igual à " + soma[i]);
            }

        }
    }
}