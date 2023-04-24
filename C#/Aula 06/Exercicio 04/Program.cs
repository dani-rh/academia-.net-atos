using System.Diagnostics.Metrics;
using System.Threading.Channels;

namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exercicio 04. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). Você foi contratado para fazer um programa em VS que conte os votos dos candidatos.
            //Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos.O mesmo para ZECA.
            //Você também pode aceitar votos em branco(palavra BRANCO).O programa em VS termina quando o usuário
            //escrever FIM.Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número de votos em branco. 

            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;

            while (true)
            {
                Console.WriteLine("Digite o voto (JOAO, ZECA ou BRANCO) e FIM ao finalizar a votação: ");
                string voto = Console.ReadLine().ToUpper();

                if (voto == "FIM")
                {
                    break;
                }
                else if (voto == "JOAO")
                {
                    votosJoao++;
                }
                else if (voto == "ZECA")
                {
                    votosZeca++;
                }
                else if (voto == "BRANCO")
                {
                    votosBranco++;
                }
                else
                {
                    Console.WriteLine("Voto inválido!");
                }
            }

            Console.WriteLine("Votos para João: " +votosJoao);
            Console.WriteLine("Votos para Zeca: " +votosZeca);
            Console.WriteLine("Votos em branco: " +votosBranco);

        }
    }
}