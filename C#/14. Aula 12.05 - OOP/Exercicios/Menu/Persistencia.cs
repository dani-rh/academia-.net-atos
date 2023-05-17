using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Menu
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

        public static void lerArquivoExibeNomes(string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
                string[] vetorLinha; //[nome, email, dataNascimento]
                string linha;
                do
                {
                    linha = leitor.ReadLine();
                    vetorLinha = linha.Split(";");
                    Console.WriteLine(vetorLinha[0]);
                } while (!leitor.EndOfStream);
                leitor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo.");
            }
        }

        public static void popularArquivoLista(string nomeArquivo, List<Pessoa> lista)
        {
            //try
            
            StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
            string[] vetorLinha; //[nome, email, dataNascimento]
            string linha;
            do
            {
                linha = leitor.ReadLine();//Leandro Di Nardo Lazarin;lazarin@ufn.edu.br;12/12/1990
                vetorLinha = linha.Split(";"); //[Leandro Di Nardo Lazarin, lazarin@ufn.edu.br, 12/12/1990]
                lista.Add(new Pessoa(vetorLinha[0], vetorLinha[1], vetorLinha[2]));

            } while (!leitor.EndOfStream);
            leitor.Close();
            
            //catch (Exception)
            //{
            //    Console.WriteLine("Problemas com arquivo ou arquivo não localizado!");
            //}
        }

        public static void gravarListaArquivo(List<Pessoa> lista, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo); //sempre o arquivo é criado do zero
                                                                       //StreamWriter escritor = new StreamWriter(nomeArquivo, append:true); //possibilidade de adicionar dados no arquivo
                foreach (var item in lista)
                {
                    escritor.WriteLine(item.Nome + ";" + item.Email + ";" + item.DataNascimento);
                    escritor.Flush();//garante que a informação seja gravada antes de fechar o loop (descarregada do buffer)
                }
                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo.");
            }
        }
        public static void atualizarPessoaArquivo(Pessoa pessoa, string nomeArquivo)
        {
            try
            {
                StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);

                escritor.WriteLine(pessoa.Nome + ";" + pessoa.Email + ";" + pessoa.DataNascimento);

                escritor.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Problemas com arquivo.");
            }
        }

    }
}
