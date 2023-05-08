namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 02 - Criar uma classe chamada Aluno com 3 construtores, sendo que o
            //primeiro recebe o nome e a matrícula do aluno, o segundo recebe apenas a
            //data de nascimento do aluno e o terceiro construtor recebe o nome do aluno,
            //a data de nascimento e o ano em que o aluno ingressou na faculdade.

            // Instanciação com o primeiro construtor
            Aluno aluno1 = new Aluno("Daniela", 01258);

            // Instanciação com o segundo construtor
            Aluno aluno2 = new Aluno(new DateOnly(1996, 7, 4));

            // Instanciação com o terceiro construtor
            Aluno aluno3 = new Aluno("Maria", new DateOnly(1999, 6, 1), 2014);
            
            Console.ReadKey();

        }
    }
}