namespace Exercicio_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 18 - Escreva um algoritmo que leia 3 valores pelo teclado e então informe qual o maior deles.

            int n1, n2, n3;

            Console.WriteLine("Digite o N1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o N2: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o N3: ");
            n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {
                if (n2 < n3)
                {
                    Console.WriteLine("N2 "+ n2);
                    Console.WriteLine("N3 "+ n3);
                }
                else if (n2 > n3)
                {
                    Console.WriteLine("N3 " +n3);
                    Console.WriteLine("N2 " +n3);
                }
                else
                {
                    Console.WriteLine("N2 e N3 são iguais.");
                }
                Console.WriteLine("N1 Maior "+n1);
            }
            
            if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("N2 Maior "+n2);
            }
            if (n3 > n1 && n3 > n2)
            {
                Console.WriteLine("N3 Maior "+n3);
            }
                        
        }
    }
}