namespace Exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 08 - Faça um programa em VS que solicite um numero inteiro. Se o numero não for inteiro, solicite-o até que seja. Após, informe se ele é par ou impar.
            //Finalmente, pergunte ao usuário se ele quer repetir o programa em VS.
            
            bool repetir = true;

            while (repetir)
            {
                int numero = 0;
                for (; numero <= 0;)
                {
                    Console.WriteLine("Digite um número inteiro: ");
                    if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine("Valor incorreto!");
                    }
                }

                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número " + numero + " é par.");
                }
                else
                {
                    Console.WriteLine("O número " + numero + " é ímpar.");
                }
                
                Console.WriteLine("\nDeseja repetir o programa (S/N)? ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta == "N")
                {
                    repetir = false;
                }
            }

        }
    }
}