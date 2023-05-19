namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 06 - Crie uma classe Produto com as propriedades Codigo e Descricao.
            //Em seguida, crie as classes Livro e CD que herdam de Produto e adicionam uma propriedade Autor e Artista, respectivamente.

            Livro livro = new Livro();
            {
                livro.Codigo = 112;
                livro.Descricao = "Este é o livro";
                livro.Autor = "George Orwell";
            }

            CD cd = new CD();
            {
                cd.Codigo = 221;
                cd.Descricao = "Este é o CD";
                cd.Artista = "Janet Jackson";
            }

            livro.Mostrar();
            Console.WriteLine();
            cd.Mostrar();

        }
    }
}