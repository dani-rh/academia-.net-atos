namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 06 - Faça um programa em VS que solicite ao o usuário que informe a idade e valide a entrada de dados,
            // ou seja, repita a leitura até que ela esteja correta(maior do que zero). 
            //Ao final, mostre a idade digitada.

            int idade = 0;

            for (; idade <= 0;)
            {
                Console.WriteLine("Informe a idade: ");


                if (!int.TryParse(Console.ReadLine(), out idade) || idade < 0)
                {
                    Console.WriteLine("Idade inválida. Por favor, digite um valor correto: ");
                    idade = 0;
                }
            }

            Console.WriteLine("Idade digitada: " +idade);

        }
    }
}