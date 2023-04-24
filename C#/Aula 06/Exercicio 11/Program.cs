namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11.Ler as notas de uma turma de alunos e ao final imprimir a nota mais alta, a nota mais baixa,
            //a média aritmética da turma e a quantidade de alunos da turma. Usar - 1 para encerrar a leitura.

            int nota = 0;
            int maiorNota = int.MinValue;
            int menorNota = int.MaxValue;
            int somaNotas = 0;
            int quantidadeAlunos = 0;
            int numeroAluno = 1;
                        
            Console.WriteLine("Digite as notas dos alunos (digite -1 para encerrar).");
            
            while (nota != -1)
            {
                Console.WriteLine("Nota do aluno " +numeroAluno+ ": ");
                nota = int.Parse(Console.ReadLine());

                if (nota != -1)
                {
                    if (nota > maiorNota)
                    {
                        maiorNota = nota;
                    }
                    if (nota < menorNota)
                    {
                        menorNota = nota;
                    }

                    somaNotas += nota;
                    quantidadeAlunos++;
                    numeroAluno++;
                }
            }

            double mediaturma = (double)somaNotas / (double)quantidadeAlunos;

            Console.WriteLine("Maior nota: " +maiorNota);
            Console.WriteLine("Menor nota: " +menorNota);
            Console.WriteLine("Média aritmética da turma: " +mediaturma);
            Console.WriteLine("Quantidade de alunos: " +quantidadeAlunos);

        }
    }
}