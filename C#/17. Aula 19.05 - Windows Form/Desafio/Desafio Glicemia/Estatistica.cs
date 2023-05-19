using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Glicemia
{
    internal class Estatistica
    {
        public static double calcularMedia (List<Glicemia> lista)
        {
            //try
            //{
            //    double media = 0;
            //    foreach (var item in lista)
            //    {
            //        media += item.valor;
            //    }
            //    return media / lista.Count;
            //}
            //catch
            //{
            //    return 0;
            //}
            
            if(lista.Count == 0)
            {
                return 0;
            }
            return lista.Sum(x => x.valor) / lista.Count;
        }

        public static double calcularMediana(List<Glicemia> lista)
        {
            List<Glicemia> listaTemp = new List<Glicemia>();
            listaTemp.AddRange(lista);//AddRange pega o conteudo da lista o copia para a temporária
            listaTemp.Sort();

            for (int i = 0; i < lista.Count / 2; i++)
                
            return lista[i];
        }
    }
}
