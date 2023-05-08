namespace Exercicio_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01 - Criar uma classe chamada Pessoa com 2 construtores,
            //um que receba o nome e a idade da pessoa e outro recebendo apenas a idade.
            //Solicite ao usuário qual dos construtores ele gostaria de utilizar na instanciação da classe.
            //Além de receber parâmetros, os construtores imprimem na tela o conteúdo dos parâmetros recebidos.

            Console.WriteLine("Olá! Deseja instanciar a pessoa com nome e idade (digite 1) ou somente idade (digite 2)");
            int op = int.Parse(Console.ReadLine());
            int idade;
            string nome;

            if (op == 1)
            {
                Console.WriteLine("Digite o nome e a idade: ");
                nome = Console.ReadLine();
                idade = int.Parse(Console.ReadLine());
                Pessoa p = new Pessoa(nome, idade);
            }
            else if (op == 2) 
            {
                Console.WriteLine("Digite a idade: ");
                idade = int.Parse(Console.ReadLine());
                Pessoa p = new Pessoa(idade);
            }

            Console.ReadLine();
        }
    }
}