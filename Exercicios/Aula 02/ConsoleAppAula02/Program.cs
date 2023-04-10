using System.ComponentModel.Design;
using System.Net.Http.Headers;

namespace ConsoleAppAula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercício 01:
            //double a;
            //double b;
            //Console.WriteLine("Digite um valor para A: ");
            //a = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um valor para B: ");
            //b = double.Parse(Console.ReadLine());
            //double media = (a + b) / 2;
            //Console.WriteLine("A média aritmética é: " + media);

            //Exercício 02:
            //double a;
            //double b;
            //double c;
            //double d;
            //Console.WriteLine("Digite um valor para A: ");
            //a = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um valor para B: ");
            //b = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um valor para C: ");
            //c = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um valor para D: ");
            //d = double.Parse(Console.ReadLine());
            //double mediaq = (a + b + c + d) / 4;
            //Console.WriteLine("A média aritmética entre esses quatro números é: " + mediaq);

            //Exercício 03:
            //Console.WriteLine("Digite um valor para A: ");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um valor para B: ");
            //int b = int.Parse(Console.ReadLine());

            //int c = a;
            //a = b;
            //b = c;
            //Console.WriteLine("O valor de A é: " + a + " e " + "o valor de B é: " + b);


            ////Exercício 04:
            //Console.WriteLine("Digite um dia: ");
            //int dia = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um mês: ");
            //int mês = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite um ano: ");
            //int ano = int.Parse(Console.ReadLine());
            //Console.WriteLine("A data DDMMAAAA é: " + dia + mês + ano);
            //Console.WriteLine("A data AAAAMMDD é: " + ano + mês + dia);

            //Exercício 05:
            //Console.WriteLine("Digite a distância percorrida: ");
            //double distancia = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite quantos litros de combustível foi consumido para percorrer essa distância: ");
            //double volume = int.Parse(Console.ReadLine());

            //double consumo = distancia / volume;
            //Console.WriteLine("O consumo móvel do automóvel é de " + consumo + "km/l.");

            //Exercício 06:

            //Console.Write("Digite o código do parafuso A: ");
            //int codigoA = int.Parse(Console.ReadLine());

            //Console.Write("Digite o código do parafuso B: ");
            //int codigoB = int.Parse(Console.ReadLine());

            //Console.Write("Quantidade de peças do parafuso A: ");
            //int quantidadeA = int.Parse(Console.ReadLine());

            //Console.Write("Quantidade de peças do parafuso B: ");
            //int quantidadeB= int.Parse(Console.ReadLine());

            //Console.Write("Valor unitário do parafuso A: R$ ");
            //double valorUniA = double.Parse(Console.ReadLine());

            //Console.Write("Valor unitário do parafuso B: R$ ");
            //double valorUniB = double.Parse(Console.ReadLine());

            //Console.Write("Porcentagem de IPI do parafuso A: ");
            //double IpiA = double.Parse(Console.ReadLine());

            //Console.Write("Porcentagem de IPI do parafuso B: ");
            //double IpiB = double.Parse(Console.ReadLine());

            //// Cálculo dos valores totais (incluindo IPI) para cada parafuso
            //double totalA = quantidadeA * valorUniA * (1 + IpiA / 100);
            //double totalB = quantidadeB * valorUniB * (1 + IpiB / 100);

            //// Exibição dos resultados na tela
            //Console.WriteLine("\nValores totais:");
            //Console.WriteLine("Parafuso A - Código: " + codigoA + ", Total: R$ " + totalA);
            //Console.WriteLine("Parafuso B - Código: " + codigoB + ", Total: R$ " + totalB);


            //Exercício 07:
            //int numeroVendedor;
            //double salarioFixo, totalVendas, percentualComissao, salarioTotal;

            //Console.Write("Digite o número do vendedor: ");
            //numeroVendedor = int.Parse(Console.ReadLine());

            //Console.Write("Digite o salário fixo do vendedor: R$ ");
            //salarioFixo = double.Parse(Console.ReadLine());

            //Console.Write("Digite o total de vendas do vendedor: R$ ");
            //totalVendas = double.Parse(Console.ReadLine());

            //Console.Write("Digite o percentual de comissão do vendedor: ");
            //percentualComissao = double.Parse(Console.ReadLine());

            //salarioTotal = salarioFixo + (totalVendas * percentualComissao / 100);

            //Console.WriteLine($"O salário total do vendedor {numeroVendedor} é R$ {salarioTotal:N2}.");


            //Exercício 08:
            //Console.WriteLine("Digite uma temperatura em Celsius: ");
            //double celsius = double.Parse(Console.ReadLine());
            //double fahrenheit = (9 * celsius + 160)/5;
            //Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);


            //Exercício 09: - terminar
            //Console.WriteLine("Digite o valor da mercadoria: ");
            //double valor = double.Parse(Console.ReadLine());

            //double entrada = Math.Ceiling(valor * 0,5); //entrada é a metade do valor arredondando pra cima
            //double prestacao = Math.Ceiling(valor - entrada) / 2; // cada prestação é o restante do valor dividido por 2 e arredondando pra cima

            //Console.WriteLine("Entrada: R$ " +entrada);
            //Console.WriteLine("Prestações: (2x) R$ " +prestacao);


            //Exercicios 10: - terminar




            //Exercício 11:
            //Console.WriteLine("Digite o número de eleitores no município: ");
            //double numeroEleitores = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o número de votos brancos: ");
            //double votosBrancos = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o número de votos nulos: ");
            //double votosNulos = double.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o número de votos válidos: ");
            //double votosValidos = double.Parse(Console.ReadLine());

            //double PBrancos = (votosBrancos / numeroEleitores) * 100;
            //Console.WriteLine("Votos brancos representam " + PBrancos + "%");
            //double PNulos = (votosNulos / numeroEleitores) * 100;
            //Console.WriteLine("Votos nulos representam " + PNulos + "%");
            //double PValidos = (votosValidos / numeroEleitores) * 100;
            //Console.WriteLine("Votos válidos representam " + PValidos + "%");


            //Exercicio 12 -





            //Console.WriteLine("Escreva seu nome: ");

            //string nome; //DECLARAÇÃO
            ////NOME - "Fabricio"; //ATRIBUIÇÃO

            //nome = Console.ReadLine();

            //Console.WriteLine("Seu nome é: " + nome); //Com concatenação


            //int idade = 32;
            //int a = 5;
            //int b = 2;

            //double a;
            //double b;

            //Console.WriteLine("Digite um valor para A: ");
            //a = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite um valor para B: ");
            //b = double.Parse(Console.ReadLine());

            ////Console.WriteLine("Sua idade é de " + idade + " anos");

            //double soma;
            //soma = a + b;

            //Console.WriteLine("A soma resulta em " + soma);

            //double sub = a - b;
            //Console.WriteLine(" A subtração resulta em: " + sub);

            //double multi = a * b;
            //double div = a / b;
            ////double div = (double)a / (double)b; //CAST
            ////double div = Convert.ToDouble(a) / Convert.ToDouble(b);
            ////double div = 5f / 2f;
            //Console.WriteLine("A multiplicação é : " + multi);
            //Console.WriteLine("A divisão entre " + a + " e " + b + " resulta em " + div);


            ////Maior ou menor de idade
            //Console.WriteLine("Digite uma idade: ");
            //int idade = int.Parse(Console.ReadLine());

            //if (idade >= 18)
            //{
            //    Console.WriteLine("Maior da idade!");
            //}
            //else
            //{
            //    Console.WriteLine("Menor de idade!");
            //}


            ////Calculadora - usuario seleciona a operação (+, -, /, *) depois insere dois valores e faz a conta
            //Console.WriteLine("Digite 1 para somar, 2 para subtrair, 3 para dividir e 4 para multiplicar: ");
            //int operador = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o primeiro valor: ");
            //int valor1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite o segundo valor: ");
            //int valor2 = int.Parse(Console.ReadLine());

            //if (operador == 1)
            //{
            //    double soma;
            //    soma = valor1 + valor2;
            //    Console.WriteLine("A soma resulta em " + soma);
            //}
            //if (operador == 2)
            //{
            //    double subtracao;
            //    subtracao = valor1 - valor2;
            //    Console.WriteLine("A subtração resulta em " + subtracao);
            //}
            //if (operador == 3)
            //{
            //    double divisao;
            //    divisao = valor1 / valor2;
            //    Console.WriteLine("A divisão resulta em " + divisao);
            //}
            //if (operador == 4)
            //{
            //    double multiplicacao;
            //    multiplicacao = valor1 * valor2;
            //    Console.WriteLine("A multiplicação resulta em: " + multiplicacao);
            //}

            ////Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado” - media 7
            //Console.WriteLine("Digite a primeira nota: ");
            //int nota1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Digite a segunda nota: ");
            //int nota2 = int.Parse(Console.ReadLine());

            //int media = (nota1 + nota2) / 2;

            //if (media >= 7)
            //{
            //    Console.WriteLine("Aprovado!");
            //}
            //else
            //{
            //    Console.WriteLine("Reprovado!");
    
            
        }
    
    }
}
