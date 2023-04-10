namespace Exercicio_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}