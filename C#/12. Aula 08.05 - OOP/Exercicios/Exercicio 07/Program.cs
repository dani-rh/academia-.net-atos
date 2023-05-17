namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //7 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor (outra classe). Utilize o encapsulamento 
            //para garantir que o título e o autor não sejam vazios.

            Livro livro = new Livro();

            try
            {
                Console.WriteLine("Digite o título do livro: ");
                livro.Titulo = Console.ReadLine();

                Console.WriteLine("Digite o nome do autor do livro: ");
                string nomeAutor = Console.ReadLine();

                Autor autor = new Autor();
                autor.Nome = nomeAutor;

                livro.Autor = autor;

                Console.WriteLine("Título do livro: " + livro.Titulo);
                Console.WriteLine("Autor do livro: " + livro.Autor.Nome);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: "+ex.Message);
            }

            Console.ReadKey();

        }
    }
}