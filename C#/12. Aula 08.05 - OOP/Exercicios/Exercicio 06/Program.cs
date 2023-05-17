namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Exercício 06 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endereço e Cidade. 
            //Produto que tenha as propriedades Nome, Fabricante e Preco. Utilize o encapsulamento para garantir que o nome não
            //seja vazio e que o preço seja positivo.

            //Criar um fabricante
            Fabricante fabricante = new Fabricante();
            {
                fabricante.Nome = "ABC";
                fabricante.Endereco = "Rua Arcindo Sardo, 156";
                fabricante.Cidade = "Curitiba";
            }

            //Criar um produto
            Produto produto = new Produto();
            {
                produto.Nome = "Produto 1";
                produto.Preco = 150;
                produto.Fabricante = fabricante;
            }

            Console.WriteLine("Nome do produto: " + produto.Nome);
            Console.WriteLine("Preço do produto: R$" + produto.Preco);
            Console.WriteLine("Fabricante do produto: " + produto.Fabricante.Nome);
            Console.WriteLine("Endereço do fabricante: " + produto.Fabricante.Endereco);
            Console.WriteLine("Cidade do fabricante: " + produto.Fabricante.Cidade);

            Console.ReadKey();

        }
    }
}