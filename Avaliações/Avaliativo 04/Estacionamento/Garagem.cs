using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estacionamento
{
    internal class Garagem
    {
        private static TimeSpan horaAbertura = new TimeSpan(7, 0, 0); // 7h
        private static TimeSpan horaFechamento = new TimeSpan(19, 59, 0); // 20h
        private static int limiteVagas = 50;

        public static bool ValidarEntrada(TimeSpan horaEntrada, List<Veiculo> listaVeiculosEntrada)
        {
            if (!HorarioFuncionamento(horaEntrada))
            {
                MessageBox.Show("A garagem está fechada. Horário de funcionamento das 7h às 20h.", "Alerta!");
                return false;
            }

            if (!TemLugar(listaVeiculosEntrada))
            {
                MessageBox.Show("A garagem está lotada. Aguarde a saída de outro veículo.", "Alerta!");
                return false;
            }

            return true;
        }

        private static bool HorarioFuncionamento(TimeSpan hora)
        {
            return hora >= horaAbertura && hora <= horaFechamento;
        }

        private static bool TemLugar(List<Veiculo> listaVeiculosEntrada)
        {
            return listaVeiculosEntrada.Count < limiteVagas;
        }

    }
}
