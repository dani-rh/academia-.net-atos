namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Escreva um algoritmo que leia os valores para um vetor de 10 elementos
            //e então mostre na tela a quantidade de números pares e ímpares.

            int[] numeros = new int[10];
            int numPares = 0;
            int numImpares = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Informe um valor para a posição " + (i+1) + ":");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 == 0)
                {
                    numPares++;
                }
                else
                {
                    numImpares++;
                }
            }
            Console.WriteLine("Foram digitados " + numPares + " números pares.");
            Console.WriteLine("Foram digitados " + numImpares + " números ímpares.");
        }
    }
}