namespace Exercicio_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
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
                        Console.WriteLine("N2 " + n2);
                        Console.WriteLine("N3 " + n3);
                    }
                    else if (n2 > n3)
                    {
                        Console.WriteLine("N3 " + n3);
                        Console.WriteLine("N2 " + n2);
                    }
                    else
                    {
                        Console.WriteLine("N2 e N3 são iguais");
                    }
                    Console.WriteLine("N1 " + n1);
                }
                else if (n2 > n1 && n2 > n3)
                {
                    if (n1 < n3)
                    {
                        Console.WriteLine("N1 " + n1);
                        Console.WriteLine("N3 " + n3);
                    }
                    else if (n1 > n3)
                    {
                        Console.WriteLine("N3 " + n3);
                        Console.WriteLine("N1 " + n1);
                    }
                    else
                    {
                        Console.WriteLine("N1 e N3 são iguais");
                    }
                    Console.WriteLine("N2 " + n2);
                }
                else if (n3 > n1 && n3 > n2)
                {
                    if (n1 < n2)
                    {
                        Console.WriteLine("N1 " + n1);
                        Console.WriteLine("N2 " + n2);
                    }
                    else if (n1 > n2)
                    {
                        Console.WriteLine("N2 " + n2);
                        Console.WriteLine("N1 " + n1);
                    }
                    else
                    {
                        Console.WriteLine("N1 e N2 são iguais");
                    }
                    Console.WriteLine("N3 " + n3);
                }
                else
                {
                    Console.WriteLine("Algum dos valores são iguais");
                }

            }
        }
    }
}