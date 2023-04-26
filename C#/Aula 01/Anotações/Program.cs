namespace Anotações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu nome: ");

            string nome; //DECLARAÇÃO
            //NOME - "Fabricio"; //ATRIBUIÇÃO

            nome = Console.ReadLine();

            Console.WriteLine("Seu nome é: " + nome); //Com concatenação

            string s; //texto, todo e qualquer texto
            char c; //caractere
            int x; //números inteiros
            float y;//números reais
            double d;//números reais
            bool bo;//bolleano, lógico, 0 ou 1, true or false

            //inteiros
            int idade = 32;
            int a = 5;
            int b = 2;

            double a;
            double b;

            Console.WriteLine("Digite um valor para A: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para B: ");
            b = double.Parse(Console.ReadLine());

            //Console.WriteLine("Sua idade é de " + idade + " anos");

            double soma;
            soma = a + b;

            Console.WriteLine("A soma resulta em " + soma);

            double sub = a - b;
            Console.WriteLine(" A subtração resulta em: " + sub);

            double multi = a * b;
            double div = a / b;
            //double div = (double)a / (double)b; //CAST
            //double div = Convert.ToDouble(a) / Convert.ToDouble(b);
            //double div = 5f / 2f;
            Console.WriteLine("A multiplicação é : " + multi);
            Console.WriteLine("A divisão entre " + a + " e " + b + " resulta em " + div);

            double a;
            double b;
            Console.WriteLine("Digite um valor para A: ");
            a = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite um valor para B: ");
            b = double.Parse(Console.ReadLine());
            double media = (a + b) / 2;
            Console.WriteLine("A média aritmética é: " + media);


            Console.WriteLine("Digite uma temperatura em Celsius: ");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (1.8 * celsius) + 32;
            Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);

            Console.WriteLine("Digite um valor para A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite um valor para B: ");
            int b = int.Parse(Console.ReadLine());

            int c = a;
            a = b;
            b = c;
            Console.WriteLine("O valor de A é: " + a + " e " + "o valor de B é: " + b);
        }
    }
}