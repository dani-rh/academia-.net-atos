namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 03 - Fazer um laço(repetição) que fique solicitando números ao usuário. Se o usuário digitar 0 o programa em VS deve parar. 
            //Caso contrário, o programa em VS deve informar se o número é par ou ímpar e se ele é um número primo.

            int numero;

            while (true)
            {
                Console.WriteLine("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero == 0)
                {
                    break; //finaliza o loop
                }

                //Se não for 0, checa se é par ou impar:
                if (numero % 2 == 0)
                {
                    Console.WriteLine("O número "+numero+" é par.");
                }
                else
                {
                    Console.WriteLine("O número " +numero+ " é ímpar.");
                }

                //Checa se é primo:
                bool isPrime = true;
                if (numero < 2)
                {
                    isPrime = false;
                }

                for (int i = 2; i < numero; i++)
                {
                    if (numero % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("O número "+numero+" é um número primo.");
                }
                else
                {
                    Console.WriteLine("O número "+numero+" não é um número primo.");
                }

            }





        }
    }
}