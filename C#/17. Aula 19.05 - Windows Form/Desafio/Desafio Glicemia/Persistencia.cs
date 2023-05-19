using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Glicemia
{
    internal class Persistencia
    {
        //Método de classe que sabe ler o conteúdo de um arquivo, linha a linha e jogar na tela
        public static void lerArquivoParaTela(string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                do
                {
                    Console.WriteLine(leitor.ReadLine());
                } while (!leitor.EndOfStream);
                leitor.Close(); //fecha o arquivo para não deixar acontecer duas aberturas de edição ao mesmo tempo
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo.");
            }

        }

        public static void popularArquivoLista(string nomeArquivo, List<Glicemia> lista)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha; //[data, valorGlicemia]
                string linha;
                do
                {
                    linha = leitor.ReadLine();//12/12/1990 120
                    vetorLinha = linha.Split(' '); //[12/12/1990, 120]
                    lista.Add(new Glicemia(vetorLinha[0], int.Parse(vetorLinha[1])));

                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo ou arquivo não localizado!");
            }
        }


    }
}
