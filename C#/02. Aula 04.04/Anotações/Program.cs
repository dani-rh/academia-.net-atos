namespace Anotações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Maior ou menor de idade
            Console.WriteLine("Digite uma idade: ");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Maior da idade!");
            }
            else
            {
                Console.WriteLine("Menor de idade!");
            }


            ////Calculadora - usuario seleciona a operação (+, -, /, *) depois insere dois valores e faz a conta
            Console.WriteLine("Digite 1 para somar, 2 para subtrair, 3 para dividir e 4 para multiplicar: ");
            int operador = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            if (operador == 1)
            {
                double soma;
                soma = valor1 + valor2;
                Console.WriteLine("A soma resulta em " + soma);
            }
            if (operador == 2)
            {
                double subtracao;
                subtracao = valor1 - valor2;
                Console.WriteLine("A subtração resulta em " + subtracao);
            }
            if (operador == 3)
            {
                double divisao;
                divisao = valor1 / valor2;
                Console.WriteLine("A divisão resulta em " + divisao);
            }
            if (operador == 4)
            {
                double multiplicacao;
                multiplicacao = valor1 * valor2;
                Console.WriteLine("A multiplicação resulta em: " + multiplicacao);
            }

            ////Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” - media 7
            Console.WriteLine("Digite a primeira nota: ");
            int nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            int nota2 = int.Parse(Console.ReadLine());

            int media = (nota1 + nota2) / 2;

            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
            }
    }
}