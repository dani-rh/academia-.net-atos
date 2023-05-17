namespace Exercicio_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 13 - Crie uma classe autor. Em seguida, crie uma classe "Livro" com os atributos "titulo" e "autor". O atributo autor, deve ser 
            //uma instancia de uma classe Autor. Crie um método para exibir as informações do livro.

            Autor autor = new Autor();
            autor.Nome = "Carla Madeira";
            autor.Nacionalidade = "Brasileira";

            Livro livro = new Livro();
            livro.Titulo = "Tudo é rio";
            livro.Autor = autor;

            livro.ExibirInformacoes();
        }
    }
}