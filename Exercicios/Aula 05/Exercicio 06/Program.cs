namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 06 - Escreva um algoritmo que leia o número de alunos de uma turma e em seguida leia a quantidade de avaliações aplicadas para aquela turma.
            //Por fim, leia as notas das avaliações de cada aluno e mostre sua nota final (média das notas das avaliações).

            int alunos, quantAvalia, i, j;
            double notaAluno, somaNota = 0, media = 0;

            Console.WriteLine("Digite a quantidade de alunos: ");
            alunos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de avaliações: ");
            quantAvalia = int.Parse(Console.ReadLine());

            for (i = 0; i < alunos; i++)
            {
                for (j = 0; j < quantAvalia; j++)
                {
                    Console.WriteLine("Digite a nota " +(j+1)+ " do aluno " +(i+1));
                    notaAluno = double.Parse(Console.ReadLine());
                    somaNota += notaAluno;
                    somaNota = 0;
                }
                media = somaNota / quantAvalia;
                Console.WriteLine("A média do aluno " +(i+j)+ " = " +media);
                media = 0;
            }



        }
    }
}