namespace Exercicio_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //11 - Crie uma classe "Aluno" com os atributos "nome", "nota1", "nota2" e "nota3". Os atributos devem ser privados e
            //acessados através de propriedades. Em seguida, crie um método para calcular a média e verificar se o aluno está aprovado
            //ou reprovado(se a nota for maior ou igual a 6, está aprovado, senão está reprovado).

            Aluno aluno = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite a nota 1: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            aluno.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3: ");
            aluno.Nota3 = double.Parse(Console.ReadLine());

            double media = aluno.CalcularMedia();
            string status = aluno.VerificarAprovacao();
            
            Console.WriteLine("O aluno " + aluno.Nome+ " obteve a média "+media+ " e está "+status+".");

            Console.ReadKey();
        }
    }
}