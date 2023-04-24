using System.Runtime.ConstrainedExecution;

namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2.Modificar o programa em VS anterior para que ao final ele pergunte ao usuário se ele deseja
            //informar um outro número. Caso positivo, o programa em VS deve ser repetido.
           
            bool repetir = true;

            while (repetir)
            {
                int numero = 0;
                for (; numero <= 0;)
                {
                    Console.WriteLine("Digite um número inteiro positivo: ");
                    if (!int.TryParse(Console.ReadLine(), out numero) || numero <= 0)
                    {
                        Console.WriteLine("Valor incorreto!");
                    }
                }
                Console.WriteLine("Número digitado: " + numero);
                Console.Write("Números inteiros pares entre 1 e " + numero + ": ");
                for (int i = 1; i < numero; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + ", ");
                    }
                }

                Console.WriteLine("\nDeseja informar outro número (S/N)? ");
                string resposta = Console.ReadLine().ToUpper();

                if (resposta == "N")
                {
                    repetir = false;
                }
            }


        }
    }
}