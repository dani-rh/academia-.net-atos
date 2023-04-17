using System;
using System.Collections.Generic;

namespace Anotações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 DIMENSÃO -> vetorI[1 8 9 98] vetorS["Ana" "Bia" "Carlos", "Pedro"] vetorD[3.8, 8.9, 9.8, 5.7]

            //declaração
            int[] vetorI = new int[4];
            string[] vetorS = new string[4];
            double[] vetorD = new double[4];

            //acesso direto ou randomizável
            vetorI[0] = 15
            if (vetorS[1] == "Bia")
            {

            }
            vetorD[3] = vetorD[3] * 2.4;

            //percorrer 
            for (int i = 0; i < vetorI.length; i++)
            {
                Console.WriteLine(vetorI[i]);
            }

            //Listas = Coleções com características de vetores dinâmicos
            Exemplos:
            - List
            - LinkedList
            - ''Hash

           // 2 DIMENSÕES->comumente chamado de matriz ou array - relação de linhas por colunas matrizI[1 5 4 8 33 6 1 7 98 4 2 9]

             matrizS

                [
                    "ana"   "pedro" "sofia"
                    "bruno" "rafa"  "joa"
                ]


            //declaração
                int[,] matrizI = new int[3, 4];
                string[,] matrizS = new string[2, 3];

            //acessando direto a linha 1 e coluna 3
                matrizI[1, 3] = 999;

                if (matrizS[0, 1] == "joca")
                {

                }

            //
            matrizI
            [
                0  0   0  0
          
                0  0   0  0
          
                0  0   0  0
            ]
                Random gerador = new Random();

            for (int i = 0; i < 3; i++)
            {       //for externo é para as linhas
                for (int j = 0; j < 4; j++)
                {   //for interno é para as colunas
                    matrizI[i, j] = matriz[i, j] * 3;
                }
            }


        }
    }
}