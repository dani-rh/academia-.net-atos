using System.Diagnostics.Contracts;
using System.Runtime.Intrinsics.X86;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Reflection.Metadata.Ecma335;

namespace Avaliativo__01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desenvolva um jogo da velha utilizando matrizes em C#. Faça com que cada jogador insira a sua jogada em uma interface amigavel. 
            //Teste se a posição é válida e caso não seja solicite ao jogador repetir a jogada.Após cada jogada, apresente o tabuleiro com as
            //jogadas representadas por "X" e "O" e faça a verificação se algum jogador venceu.
            //Caso seja empate, apresente o resultado na tela. Possilibilite que o jogo seja reinicializado sem a necessidade de reiniciar o jogo.


            //Desafio extra, pode valer por alguma atividade futura: Faça a implementação de um jogo contra o computador.Faça o possível para evitar que o jogador vença do computador.
            //Para facilitar, faça com que o computador inicie jogando.

            //Prazo de entrega: 24 / 04
            //Forma e envio: Enviar pelo chat o link do github

            //Declara a função do tabuleiro
            char[,] tabuleiro = new char[3, 3];
            { for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        tabuleiro[i, j] = ' ';
                    }
                }
            }

            //Declara o jogador atual para determinar qual jogador deve jogar na próxima rodada
            char jogadorAtual = 'X';

            while (!VerificaFimDeJogo(tabuleiro))
            {
                //Limpa o console e imprime o tabuleiro atualizado
                Console.Clear();
                ImprimeTabuleiro(tabuleiro);

                Console.WriteLine("Jogador " + jogadorAtual + " insira a posição do tabuleiro i,j: ");
                string[] jogada = Console.ReadLine().Split(','); //String inserida pelo jogador é dividida em duas partes usando a vírgula como separador
                int linha;
                int coluna;

                //Verifica se a posição é existente na matriz e retorna a jogada nas variáveis linha e coluna
                if (jogada.Length != 2 || !int.TryParse(jogada[0], out linha) || !int.TryParse(jogada[1], out coluna) || linha < 0 || linha > 2 || coluna < 0 || coluna > 2)
                {
                    Console.WriteLine("Essa posição não existe! Tente novamente. ");
                    continue;
                }

                //Verifica se a posição já foi preenchida anteriormente
                if (tabuleiro[linha, coluna] != ' ')
                {
                    Console.WriteLine("Posição já preenchida! Tente novamente. ");
                    continue;
                }

                tabuleiro[linha, coluna] = jogadorAtual;
                jogadorAtual = (jogadorAtual == 'X') ? 'O' : 'X';
            }

            Console.Clear();
            ImprimeTabuleiro(tabuleiro);

            //Função para verificar o vencedor 
            char vencedor = VerificaVencedor(tabuleiro);
            if (vencedor == ' ')
            {
                Console.WriteLine("Empate!");
            }
            else
            {
                Console.WriteLine("Jogador " + vencedor + " venceu!");
            }

            //Imprimir tabuleiro com as posições
            static void ImprimeTabuleiro(char[,] tabuleiro)
            {
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(" ({0}, {1}) | ", i, j);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("________|_________|_________");
                for (int i = 1; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(" ({0}, {1}) | ", i, j);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("________|_________|_________");
                for (int i = 2; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        Console.Write(" ({0}, {1}) | ", i, j);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("        |         |        ");
            }
            //    Console.WriteLine(" {0} | {1} | {2} ", tabuleiro[0, 0], tabuleiro[0, 1], tabuleiro[0,2]);
            //    Console.WriteLine("___|___|___");
            //    Console.WriteLine(" {0} | {1} | {2} ", tabuleiro[1, 0], tabuleiro[1, 1], tabuleiro[1, 2]);
            //    Console.WriteLine("___|___|___");
            //    Console.WriteLine(" {0} | {1} | {2} ", tabuleiro[2, 0], tabuleiro[2, 1], tabuleiro[2, 2]);

            //{
            //    for (int i = 0; i < 1; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            Console.Write("({0},{1})|", i, j);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("_____|_____|_____");
            //    for (int i = 1; i < 2; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            Console.Write("({0},{1})|", i, j);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("_____|_____|_____");
            //    for (int i = 2; i < 3; i++)
            //    {
            //        for (int j = 0; j < 3; j++)
            //        {
            //            Console.Write("({0},{1})|", i, j);
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("     |     |     ");
            //}

            static bool VerificaFimDeJogo(char[,] tabuleiro)
            {
                return VerificaVencedor(tabuleiro) != ' ' || VerificaEmpate(tabuleiro);
            }

            static char VerificaVencedor(char[,] tabuleiro)
            {
                //Verificar se há um vencedor na linha (i)
                for (int i = 0; i < 3; i++)
                {
                    if (tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2] && tabuleiro[i, 0] != ' ')
                    {
                        return tabuleiro[i, 0];
                    }
                }
                //Verificar se há um vencedor na coluna (j)
                for (int j = 0; j < 3; j++)
                {
                    if (tabuleiro[0, j] == tabuleiro[1, j] && tabuleiro[1, j] == tabuleiro[2, j] && tabuleiro[0, j] != ' ')
                    {
                        return tabuleiro[0, j];
                    }
                }
                //Verificar se há um vencedor na diagonal principal
                if (tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0] && tabuleiro[0, 2] != ' ')
                {
                    return tabuleiro[0, 2];
                }
                //Se não houver vencedor, retorna espaço em branco
                return ' ';
            }

            static bool VerificaEmpate(char[,] tabuleiro)
            {
                //Verifica se todas as posições estão preenchidas
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (tabuleiro[i, j] == ' ')
                        {
                            return false;
                        }
                    }
                }

                //Se todas as posições estiverem preenchidas e não houver vencedor é empate
                return true;
            }

        }
    }
}