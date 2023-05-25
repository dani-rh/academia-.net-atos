using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    internal class Veiculo
    {
        public string placaVeiculo;
        public DateTime dataEntrada;
        public TimeSpan horaEntrada;
        public TimeSpan tempoPermanencia;
        public decimal valorCobrado;

        public Veiculo(string placaVeiculo, DateTime dataEntrada, TimeSpan horaEntrada)
        {
            PlacaVeiculo = placaVeiculo;
            DataEntrada = dataEntrada;
            HoraEntrada = horaEntrada;
        }
        public Veiculo (string placaVeiculo)
        {
            PlacaVeiculo = placaVeiculo;
        }
        public string PlacaVeiculo
        {
            get { return placaVeiculo; }
            set 
            {
                if (value.Length == 7)
                    placaVeiculo = value;
                else
                    throw new ArgumentException("A placa do veículo deve ter 7 caracteres.");
            }
        }

        public DateTime DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }
        public TimeSpan HoraEntrada
        {
            get { return horaEntrada; }
            set { horaEntrada = value; }
        }

        public TimeSpan TempoPermanencia
        {
            get { return tempoPermanencia; }
            set { tempoPermanencia = value; }
        }

        public decimal ValorCobrado
        {
            get { return valorCobrado; }
            set { valorCobrado = value; }
        }


            //     gerarData()


            //jaCadastrada(placa)
        public static bool jaCadastrada (string placaVeiculo,List<Veiculo>listaEntrada)
        {
            foreach(Veiculo i in listaEntrada)
            {
                if(placaVeiculo.Equals(i.placaVeiculo))
                {
                    return true;
                }
            }
            return false;//Veiculo não localizado na lista Veiculo
        }

            //temLugar()




    }
}
