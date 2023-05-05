namespace Anotações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 01:
            int num;
            Console.WriteLine("Digite um numero: ");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 9:
                    Console.WriteLine("o numero digitado é 9");
                    break;
                case 10:
                    Console.WriteLine("o numero digitado é 10");
                    break;
                default:
                    Console.WriteLine("o numero digitado não é 9 nem 10");
                    break;
            }

            //Exemplo 02
            //Calculadora - usuario seleciona a operação (+, -, /, *) depois insere dois valores e faz a conta
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

            //Exemplo 03 - Usando operador ternário "?"
            int i;
            i = int.Parse(Console.ReadLine());
            Console.WriteLine(i + " é " + (i % 2 == 0 ? "par" : "impar"));

        }
    }
}