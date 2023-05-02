using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;

namespace Anotações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, estou no primeiro programa 00");
            Pessoa p = new Pessoa();//instanciando o objeto

            Console.WriteLine("Digite o nome da pessoa: ");
            p.nome = Console.ReadLine();//aqui estou atribuindo nome

            Console.WriteLine("Digite a idade da pessoa: ");
            p.idade = int.Parse(Console.ReadLine()); //aqui estou atribuindo idade

            //abaixo, estou mostrando os dados?
            //Console.WriteLine("A pessoa instanciada é: "+p.nome);
            //Console.WriteLine("E tem "+p.idade+" anos");
            p.exibeDados();

            Pessoa p2 = new Pessoa("Snow", 6);
            p2.exibeDados();

            //Exemplo 01 - 
            //Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e anoFabricacao.Além disso, na main crie 2 objetos do tipo Carro e exiba na tela os valores dos atributos criados.
            //Esses valores devem ser solicitados ao usuário, por linha de execução.

            
        }
    }
}