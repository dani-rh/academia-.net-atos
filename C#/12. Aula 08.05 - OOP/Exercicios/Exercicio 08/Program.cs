namespace Exercicio_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //8 - Crie uma classe chamada Aluno que tenha as propriedades Nome e Matricula. Utilize o encapsulamento para garantir 
            //que o nome não seja vazio(utilize função nativa) e que a matrícula seja positiva.

            Aluno aluno = new Aluno();

            try
            {
                Console.WriteLine("Digite o nome do aluno: ");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("Digite a matrícula do aluno: ");
                aluno.Matricula = int.Parse(Console.ReadLine());

                Console.WriteLine("Nome do aluno: "+aluno.Nome);
                Console.WriteLine("Matrícula do aluno: "+aluno.Matricula);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: "+ex.Message);
            }
            Console.ReadKey();
        }
    }
}