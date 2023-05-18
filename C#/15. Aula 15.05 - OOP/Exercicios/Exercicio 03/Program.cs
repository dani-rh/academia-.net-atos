namespace Exercicio_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - Crie uma classe Animal com propriedades Nome e Idade.
            //Em seguida, crie as classes Cachorro e Gato que herdam de Animal e adicionam uma propriedade Raca.

            Cachorro cachorro = new Cachorro();
            {
                cachorro.Nome = "Snow";
                cachorro.Idade = 6;
                cachorro.Raca = "Shitzu";
            }

            Gato gato = new Gato();
            {
                gato.Nome = "Mingau";
                gato.Idade = 4;
                gato.Raca = "Persa";
            }

            cachorro.Mostrar();
            Console.WriteLine();
            gato.Mostrar();

        }
    }
}