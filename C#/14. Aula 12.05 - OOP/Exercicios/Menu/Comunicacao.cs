using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
    internal class Comunicacao
    {
        //Valida se o nome inserido é válido
        public static bool validaNome(string nome)
        {
            string[] vetor = nome.Split();
            if(vetor.Length < 2)
            {
                return false;
            }
            return true;
        }

        //Valida a data de nascimento
        public static bool validaData(string data)
        {
            //   dd/mm/aaaa --- exemplo de 'preocupacao'
            string[] vetor = data.Split('/');

            if (vetor.Length != 3 || vetor[0].Length > 2 || vetor[1].Length > 2 || vetor[2].Length != 4)
            {
                return false;
            }
            return true;
        }

        //Case 1 - cadastrar 
        public static void cadastrar(List<Pessoa> lista, string nomeArquivo)
        {
            string nome;
            string dataNascimento;
            Pessoa pessoa;

            do
            {
            Console.WriteLine("Nome: ");
            nome = Console.ReadLine().ToUpper();
            }while (!validaNome(nome));

            do
            {
                Console.WriteLine("Data Nascimento: ");
                dataNascimento = Console.ReadLine();
            } while (!validaData(dataNascimento));

            pessoa = new Pessoa(nome, dataNascimento);

            if(!lista.Contains(pessoa)) 
            {
                lista.Add(pessoa);
                Persistencia.atualizarPessoaArquivo(pessoa, "dados.dat");
                Console.WriteLine("Pessoa cadastrada na base de dados.");
            }
            else
            {
                Console.WriteLine("Pessoa com este email já na base de dados");
            }
        }

        //Case 2 - listar 
        public static void listar(List<Pessoa> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        //Case 3 - excluir
        public static void excluir(List<Pessoa> lista, string nomeArquivo)
        {
            Console.Write("Digite nome a ser excluído: ");
            string nome = Console.ReadLine().ToUpper();

            bool removeu = false;
            foreach (var item in lista)
            {
                if (nome == item.Nome)
                {
                    lista.Remove(item);
                    removeu = true;
                    Console.WriteLine("Pessoa excluída da base de dados!");
                    break;
                }
            }
            if (removeu)
            {
                Persistencia.gravarListaArquivo(lista, "dados.dat");
            }
        }


    }
}
