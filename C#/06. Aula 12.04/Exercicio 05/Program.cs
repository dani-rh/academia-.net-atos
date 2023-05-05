namespace Exercicio_05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Exercício 05 - Modifique o programa em VS anterior para aceitar votos nulos (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO).
            //Ao final, informe o nome do candidato vencedor, o número de votos nulos e o número de pessoas que votaram.

            int votosJoao = 0;
            int votosZeca = 0;
            int votosBranco = 0;
            int votosNulos = 0;

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
                    votosNulos++;
                }
            }

            if (votosJoao > votosZeca)
            {
                Console.WriteLine("João venceu com " +votosJoao+ " votos.");
            }
            else
            {
                Console.WriteLine("Zeca venceu com " +votosZeca+ " votos.");
            }

            Console.WriteLine("Foram recebidos " + votosNulos+ " votos nulos.");
            int totalVotos = votosBranco + votosNulos + votosJoao + votosZeca;
            Console.WriteLine("Ao final, " +totalVotos+ " pessoas votaram.");

        }
    }
}