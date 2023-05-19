using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Glicemia
{
    internal class Comunicacao
    {

        // listar glicemia
        public static void exibir(List<Glicemia> lista)
        {
            foreach (var item in lista)
            {
                Console.WriteLine(item);
            }
        }

        //Case 4 - Pesquisar
        public static void pesquisar(List<Pessoa> lista)
        {
            Console.Write("Digite nome a ser pesquisado: ");
            string nomePesquisado = Console.ReadLine().ToUpper();

            bool pessoaEncontrada = false;

            foreach (var item in lista)
            {
                if (item.Nome.ToUpper().Contains(nomePesquisado))
                {
                    Console.WriteLine(item);
                    pessoaEncontrada = true;
                }
                if (pessoaEncontrada)
                {
                    Console.WriteLine("Pessoa(s) localizada(s) na base de dados!");
                }
                else
                {
                    Console.WriteLine("Pessoa não localizada na base de dados!");
                }
            }
        }
    }
}
