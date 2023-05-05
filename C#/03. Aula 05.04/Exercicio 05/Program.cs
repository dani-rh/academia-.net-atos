namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 05:
            ////Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” - media 7
            ///Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
            // é a média entre a nota do exame e a média das 2 notas.
            //Se esta média final for maior ou igual a 5, 0, o programa deve escrever “Aprovado”, caso contrário deve
            //escrever “Reprovado”.

            Console.WriteLine("Digite a primeira nota: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            int nota2 = int.Parse(Console.ReadLine());

            int media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }

        }
    }
}