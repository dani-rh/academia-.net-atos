using System.Transactions;
using static System.Net.Mime.MediaTypeNames;

namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //10. Ler nome, sexo e idade de 50 pessoas e após imprimir:
            //Número de pessoas do sexo masculino.
            //Número de pessoas do sexo feminino.
            //Número de pessoas com idade inferior a 30 anos.
            //Número de pessoas com idade superior a 60 anos.
            //Média de idade das mulheres.

            //variáveis 

            int numPessoasSexoMasc = 0;
            int numPessoasSexoFemin = 0;
            int numPessoasMenos30 = 0;
            int numPessoasMais60 = 0;
            double somaIdadeSexoFemin = 0;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite o nome da pessoa " + (i + 1) + ": ");
                string nome = Console.ReadLine();

                Console.WriteLine("Digite o sexo da pessoa " + (i + 1) + " (F/M): ");
                char sexo = char.Parse(Console.ReadLine());

                Console.WriteLine("Digite a idade da pessoa " + (i + 1) + ": ");
                int idade = int.Parse(Console.ReadLine());

                if (sexo == 'M')
                {
                    numPessoasSexoMasc++;
                }
                else if (sexo == 'F')
                {
                    numPessoasSexoFemin++;
                    somaIdadeSexoFemin += idade;
                }

                if (idade < 30)
                {
                    numPessoasMenos30++;
                }
                if (idade > 60)
                {
                    numPessoasMais60++;
                }
            }

            Console.WriteLine("Número de pessoas do sexo masculino: " + numPessoasSexoMasc);
            Console.WriteLine("Número de pessoas do sexo feminino: " + numPessoasSexoFemin);
            Console.WriteLine("Número de pessoas com menos de 30 anos: " + numPessoasMenos30);
            Console.WriteLine("Número de pessoas com mais de 60 anos: " + numPessoasMais60);

            if (numPessoasSexoFemin > 0)
            {
                double mediaIdadeSexoFemin = somaIdadeSexoFemin / numPessoasSexoFemin;
                Console.WriteLine("A média de idade das pessoas do sexo feminino é: " + mediaIdadeSexoFemin);
            }
        }
    }
}