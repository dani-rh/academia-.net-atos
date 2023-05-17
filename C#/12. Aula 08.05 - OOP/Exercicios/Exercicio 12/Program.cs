namespace Exercicio_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //12 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida, crie um método para acelerar o carro
            //(aumentando a velocidade em 10) e outro para frear o carro(diminuindo a velocidade em 10, mas nunca deixando a
            //velocidade negativa).

            Carro meuCarro = new Carro();
            meuCarro.Modelo = "Fusca";
            meuCarro.Ano = 2020;

            Console.WriteLine("Velocidade inicial: " + meuCarro.Velocidade);  // Velocidade inicial: 0

            meuCarro.Acelerar();
            Console.WriteLine("Velocidade após acelerar: " + meuCarro.Velocidade);  // Velocidade após acelerar: 10

            meuCarro.Frear();
            Console.WriteLine("Velocidade após frear: " + meuCarro.Velocidade);  // Velocidade após frear: 0
        }
    }
}