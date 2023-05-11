using System.Reflection.Emit;

namespace Exercicio_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6 - Faça um programa em C# e no Visual Studio para receber o nome (totalmente em maiúsculo), 
            //    a altura (metros) e o peso (kg) de uma pessoa.
            //    O programa deve calcular o Indice de Massa Corpórea(IMC), 
            //    exibi - lo ao usuário e informar sua situação conforme a tabela.
            //    O cálculo do imc = peso / (altura * altura)

            //    IMC
            //    menor que 18->baixo peso
            //    maior que 18 e menor que 25->peso normal
            //    maior que 25 e menor que 30->sobrepeso
            //    maior que 30 e menor que 35->obesidade
            //    maior que 35->obesidade grau sério

            Console.WriteLine("Calculadora de IMC");

            //Pegar os dados do usuário
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine().ToUpper();

            Console.WriteLine("Altura (em metros): ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Peso (em kg): ");
            double peso = double.Parse(Console.ReadLine());

            //Calcular IMC
            double imc = peso / (altura * altura);

            //Determinar a situação

            string situacao;

            if (imc < 18)
                situacao = "Baixo peso";
            else if (imc < 25)
                situacao = "Peso normal";
            else if (imc < 30)
                situacao = "Sobrepeso";
            else if (imc < 35)
                situacao = "Obesidade";
            else
                situacao = "Obesidade grau sério";

            // Exibir o resultado
            Console.WriteLine("------------------");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("IMC: " + imc.ToString("F2"));
            Console.WriteLine("Situação: " + situacao);

            Console.ReadLine();

        }
    }
}