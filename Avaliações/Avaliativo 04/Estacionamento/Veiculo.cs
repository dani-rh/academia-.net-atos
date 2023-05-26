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
        public Veiculo(string placaVeiculo, TimeSpan tempoPermanencia, decimal valorCobrado)
        {
            PlacaVeiculo = placaVeiculo;
            TempoPermanencia = tempoPermanencia;
            ValorCobrado = valorCobrado;
        }
        public Veiculo(string placaVeiculo)
        {
            PlacaVeiculo = placaVeiculo;
        }
        public string PlacaVeiculo
        {
            get { return placaVeiculo; }
            set
            {
                if (value == null || value.Length < 7)
                    return;

                if (value.Length == 7)
                    placaVeiculo = value;
                else
                    MessageBox.Show("A placa do veículo deve ter 7 caracteres.", "Alerta!");
            }
        }

        public DateTime DataEntrada
        {
            get { return dataEntrada; }
            set { dataEntrada = value; }
        }

        public string DataEntradaFormatada
        {
            get { return dataEntrada.ToString("dd/MM/yyyy"); }
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
        public string TempoPermanenciaFormatado
        {
            get { return TempoPermanencia.ToString(@"hh\:mm"); }
        }
        public decimal ValorCobrado
        {
            get { return valorCobrado; }
            set { valorCobrado = value; }
        }


        //     gerarData()


        //jaCadastrada(placa)
        public static bool jaCadastrada(string placaVeiculo, List<Veiculo> listaEntrada)
        {
            if (placaVeiculo.Length != 7)
            {
                MessageBox.Show("A placa do veículo deve ter 7 caracteres.", "Alerta!");
                return true; // Indicando que a placa é inválida
            }

            foreach (Veiculo veiculo in listaEntrada)
            {
                if (placaVeiculo.Equals(veiculo.placaVeiculo))
                {
                    return true; // Veículo já cadastrado na lista
                }
            }
            return false;//Veiculo não localizado na lista Veiculo
        }

        public void CalcularValorCobrado(TimeSpan horaSaida)
        {
            TempoPermanencia = horaSaida - HoraEntrada;

            int horas = (int)TempoPermanencia.TotalHours;
            if (horas > 0)
            {
                ValorCobrado = horas * 2;
            }
            else
            {
                ValorCobrado = 0;
            }
        }
    }
}
