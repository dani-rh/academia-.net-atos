﻿using System;
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
        ////Método de classe que sabe ler o conteúdo de um arquivo, linha a linha e jogar na tela
        //public static void lerArquivoParaTela (string nomeArquivo)
        //{
        //    StreamReader leitor = new StreamReader (nomeArquivo, Encoding.UTF8);
        //    do
        //    {
        //        Console.WriteLine(leitor.ReadLine());
        //    } while (!leitor.EndOfStream);
        //    leitor.Close (); //fecha o arquivo para não deixar acontecer duas aberturas de edição ao mesmo tempo
        //}

        //public static void lerArquivoExibeNomes(string nomeArquivo)
        //{
        //    StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
        //    string[] vetorLinha; //[nome, email, dataNascimento]
        //    string linha;
        //    do
        //    {
        //        linha = leitor.ReadLine();
        //        vetorLinha = linha.Split(";");
        //        Console.WriteLine(vetorLinha[0]);
        //    } while (!leitor.EndOfStream);
        //    leitor.Close();
        //}

        //public static void popularArquivoLista(string nomeArquivo, List<Pessoa> lista)
        //{
        //    StreamReader leitor = new StreamReader(nomeArquivo, Encoding.UTF8);
        //    string[] vetorLinha; //[nome, email, dataNascimento]
        //    string linha;
        //    do
        //    {
        //        linha = leitor.ReadLine();//Leandro Di Nardo Lazarin;lazarin@ufn.edu.br;12/12/1990
        //        vetorLinha = linha.Split(";"); //[Leandro Di Nardo Lazarin, lazarin@ufn.edu.br, 12/12/1990]
        //        lista.Add(new Pessoa(vetorLinha[0], vetorLinha[1], vetorLinha[2]));

        //    } while (!leitor.EndOfStream);
        //    leitor.Close();
        //}

        //public static void exibirLista(List<Pessoa> lista)
        //{
        //    foreach (var item in lista)
        //    {
        //        Console.WriteLine(item);
        //    }

        //}

    }
}
