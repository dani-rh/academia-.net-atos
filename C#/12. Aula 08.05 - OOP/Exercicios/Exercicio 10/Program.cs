namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Espécie e Idade. Crie também um método chamado
            //EmitirSom, que imprime na tela o som do animal.

            Animal animal = new Animal();
            animal.Nome = "Leão";
            animal.Especie = "Felino";
            animal.Idade = 5;

            Console.WriteLine("Nome: " + animal.Nome);
            Console.WriteLine("Espécie: " + animal.Especie);
            Console.WriteLine("Idade: " + animal.Idade);

            animal.EmitirSom();

        }
    }
}