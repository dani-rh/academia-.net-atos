using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento
{
    internal class Persistencia
    {
        private const string VeiculosEntradaFilePath = "veiculosEntrada.dat";
        private const string VeiculosSaidaFilePath = "veiculosSaida.dat";

        public static List<Veiculo>LerArquivoVeiculosEntrada()
        {
            List<Veiculo> listaVeiculosEntrada = new List<Veiculo>();

            if (File.Exists(VeiculosEntradaFilePath))
            {
                using (StreamReader leitor = new StreamReader(VeiculosEntradaFilePath))
                {
                    string linha;
                    while((linha = leitor.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(';');
                        if (dados.Length == 3)
                        {
                            string placaVeiculo = dados[0];
                            DateTime dataEntradaFormatada = DateTime.ParseExact(dados[1], "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            TimeSpan horaEntrada = TimeSpan.Parse(dados[2]);

                            Veiculo veiculo = new Veiculo(placaVeiculo, dataEntradaFormatada, horaEntrada);
                            listaVeiculosEntrada.Add(veiculo);
                        }
                    }
                }
            }
            return listaVeiculosEntrada;
        }

        public static List<Veiculo> LerArquivoVeiculosSaida()
        {
            List<Veiculo> listaVeiculosSaida = new List<Veiculo>();

            if(File.Exists(VeiculosSaidaFilePath))
            {
                using (StreamReader leitor = new StreamReader(VeiculosSaidaFilePath))
                {
                    string linha;
                    while((linha = leitor.ReadLine()) != null)
                    {
                        string[] dados = linha.Split(';');
                        if (dados.Length == 5)
                        {
                            string placaVeiculo = dados[0];
                            DateTime dataEntrada = DateTime.Parse(dados[1]);
                            TimeSpan horaEntrda = TimeSpan.Parse(dados[2]);
                            TimeSpan tempoPermanencia = TimeSpan.Parse(dados[3]);
                            decimal valorCobrado = decimal.Parse(dados[4]);

                            Veiculo veiculo = new Veiculo(placaVeiculo, dataEntrada, horaEntrda)
                            {
                                TempoPermanencia = tempoPermanencia,
                                ValorCobrado = valorCobrado
                            };
                            listaVeiculosSaida.Add(veiculo);
                        }
                    }
                }
            }
            return listaVeiculosSaida;
        }

        public static void GravarArquivoVeiculosEntrada(List<Veiculo>listaVeiculosEntrada)
        {
            using (StreamWriter escritor = new StreamWriter(VeiculosEntradaFilePath))
            {
                foreach(Veiculo veiculo in listaVeiculosEntrada)
                {
                    string linha = $"{veiculo.PlacaVeiculo};{veiculo.DataEntradaFormatada};{veiculo.HoraEntrada.ToString()}";
                    escritor.WriteLine(linha);
                }
            }
        }

        public static void GravarArquivoVeiculosSaida(List<Veiculo>listaVeiculosSaida)
        {
            using (StreamWriter escritor = new StreamWriter(VeiculosSaidaFilePath))
            {
                foreach (Veiculo veiculo in listaVeiculosSaida)
                {
                    string linha = $"{veiculo.PlacaVeiculo};{veiculo.DataEntradaFormatada};{veiculo.HoraEntrada.ToString()};{veiculo.TempoPermanencia.TotalMinutes};{veiculo.ValorCobrado}";
                    escritor.WriteLine(linha);
                }
            }
        }


    }
}
