using System.Runtime.ConstrainedExecution;
using System;
using System.Security.Cryptography;

namespace Exemplo_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•Crie uma classe chamada Computador que possua 4 atributos: marca, modelo, tipo (notebook, netbook, tablet, etc) e preço.
            //Crie dois objetos onde o primeiro objeto deverá ser criado através da solicitação dos valores ao usuário por linha de execução.Já, os valores do segundo objeto, deverão ser definidos no código - fonte da classe que o criou.Exiba na tela os resultados.

            Computador c1 = new Computador();

            Console.WriteLine("Digite a marca do computador: ");
            c1.marca = Console.ReadLine();
            Console.WriteLine("Digite o modelo do computador: ");
            c1.modelo = Console.ReadLine();
            Console.WriteLine("Digite o tipo do computador: ");
            Console.WriteLine("Digite 1 para notebook");
            Console.WriteLine("Digite 2 para netbook");
            Console.WriteLine("Digite 3 para tablet");
            Console.WriteLine("Digite 4 para outros");
            c1.tipo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do computador: ");
            c1.preco = double.Parse(Console.ReadLine());

            Computador c2 = new Computador("HP", "HP ProBook 640 G2", 1, 3.000);

            Console.WriteLine(c1.retornInfos());
            Console.WriteLine(c2.retornInfos());

            Console.ReadLine();

            //Console.WriteLine("Computador 1: ");
            //c1.exibeDados();
            //Console.WriteLine("Computador 2: ");
            //c2.exibeDados();
        }
    }
}