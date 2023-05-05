namespace Exercicio_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 07 - Faça um programa em C# e no VS para receber uma frase qualquer e uma palavra de pesquisa.
            //O programa deve avaliar se a palavra aparece na frase, informando o usuário via mensagem.

            string palavra, frase;
            Console.WriteLine("Digite uma frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Digite uma palavra: ");
            palavra = Console.ReadLine();

            if (frase.Contains(palavra))
            {
                Console.WriteLine("A palavra " + palavra + " está inclusa na frase: " + frase);
            }
            else
            {
                Console.WriteLine("Não possui a palavra.");
            }

            ////Usando ternário
            //string palavra, frase;
            //Console.WriteLine("Digite uma frase: ");
            //frase = Console.ReadLine();
            //Console.WriteLine("Digite uma palavra: ");
            //palavra = Console.ReadLine();
            //Console.WriteLine(frase.Contains(palavra) ? "A palavra " + palavra + " existe na frase " + frase: "Não possuui a palavra");
        }
    }
}