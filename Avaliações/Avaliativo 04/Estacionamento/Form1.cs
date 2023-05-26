using System.Linq;
using System.Numerics;

namespace Estacionamento
{
    public partial class Form1 : Form
    {
        private List<Veiculo> listaVeiculosEntrada;
        private List<Veiculo> listaVeiculosSaida;

        public Form1()
        {
            InitializeComponent();

            listaVeiculosEntrada = Persistencia.LerArquivoVeiculosEntrada();
            listaVeiculosSaida = Persistencia.LerArquivoVeiculosSaida();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker_dataAtual.Value = DateTime.Today;
            dateTimePicker_dataAtual.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dataAtual.CustomFormat = "dd/MM/yyyy";

            AtualizarListaVeiculosEntrada();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label_horarioAtual.Text = DateTime.Now.ToString("HH:mm");
        }

        private void AtualizarListaVeiculosEntrada()
        {
            textBox_listaEntradaDeVeiculos.Clear();

            foreach (Veiculo veiculo in listaVeiculosEntrada)
            {
                textBox_listaEntradaDeVeiculos.AppendText(veiculo.PlacaVeiculo + " - " + veiculo.DataEntrada.ToShortDateString() + " - " + veiculo.HoraEntrada.ToString() + Environment.NewLine);
            }
        }

        private void AtualizarListaVeiculosSaida()
        {
            foreach (Veiculo veiculo in listaVeiculosSaida)
            {
                textBox_listaSaidaDeVeiculos.AppendText(veiculo.PlacaVeiculo + Environment.NewLine);
            }
        }

        private void button_Entrada_Click(object sender, EventArgs e)
        {
            //transformar a placa para maiusculo no momento do registro
            string placa = textBox_Placa.Text.ToUpper();

            // Verificar se o campo de placa est� vazio
            if (string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("O campo de placa � obrigat�rio.", "Alerta!");
                return;
            }
            // Verificar se a placa possui menos de 7 caracteres
            if (placa.Length < 7)
            {
                MessageBox.Show("A placa do ve�culo deve ter 7 caracteres.", "Alerta!");
                return;
            }

            // Obter o hor�rio de entrada digitado pelo usu�rio
            TimeSpan horaEntrada;
            if (!TimeSpan.TryParse(textBox_horaEntrada.Text, out horaEntrada))
            {
                MessageBox.Show("Hor�rio de entrada inv�lido. Digite no formato HH:mm.", "Alerta!");
                return;
            }

            // Verificar garagem
            if (!Garagem.ValidarEntrada(horaEntrada, listaVeiculosEntrada))
            {
                return;
            }

            //gravar veiculo que n�o esteja na lista de entrada
            if (Veiculo.jaCadastrada(placa, listaVeiculosEntrada))
            {
                MessageBox.Show("Ve�culo j� est� no estacionamento.", "Alerta!");
            }
            else
            {
                Veiculo veiculo = new Veiculo(placa, DateTime.Today, horaEntrada);
                listaVeiculosEntrada.Add(veiculo);

                // Atualizar o campo textBox_listaEntradaDeVeiculos
                textBox_listaEntradaDeVeiculos.AppendText(placa + " - " + veiculo.DataEntradaFormatada + " - " + horaEntrada.ToString() + Environment.NewLine);

                Persistencia.GravarArquivoVeiculosEntrada(listaVeiculosEntrada);

                // Atualizar a lista de ve�culos na caixa de texto
                AtualizarListaVeiculosEntrada();
            }

            // Limpar os campos de entrada
            textBox_Placa.Clear();
            textBox_horaEntrada.Clear();
        }

        private void button_Saida_Click(object sender, MouseEventArgs e)
        {
            //transformar a placa para maiusculo no momento do registro
            string placa = textBox_Placa.Text.ToUpper();

            // Verificar se o campo de placa est� vazio
            if (string.IsNullOrEmpty(placa))
            {
                MessageBox.Show("O campo de placa � obrigat�rio.", "Alerta!");
                return;
            }
            // Verificar se a placa possui menos de 7 caracteres
            if (placa.Length < 7)
            {
                MessageBox.Show("A placa do ve�culo deve ter 7 caracteres.", "Alerta!");
                return;
            }

            // Obter o hor�rio de sa�da digitado pelo usu�rio
            TimeSpan horaSaida;
            if (!TimeSpan.TryParse(textBox_horaSaida.Text, out horaSaida))
            {
                MessageBox.Show("Hor�rio de sa�da inv�lido. Digite no formato HH:mm.", "Alerta!");
                return;
            }

            // Verificar se o ve�culo est� na lista de entrada e no arquivo de entrada
            Veiculo veiculoSaida = listaVeiculosEntrada.FirstOrDefault(veiculo => veiculo.PlacaVeiculo == placa);
            if (veiculoSaida == null)
            {
                MessageBox.Show("Ve�culo n�o est� na garagem.", "Alerta!");
                return;
            }
            else
            {
                

                ////gravar veiculo na lista de saida que esteja lista de entrada (mas em formato diferente)
                //Veiculo veiculo = new Veiculo(placa);
                //listaVeiculosSaida.Add(veiculo);

                //// Atualizar o campo textBox_listaSaidaDeVeiculos
                //textBox_listaSaidaDeVeiculos.AppendText(placa + Environment.NewLine);

                //Persistencia.GravarArquivoVeiculosSaida(listaVeiculosSaida);

                //// Atualizar a lista de ve�culos na caixa de texto
                //AtualizarListaVeiculosSaida();

                //// Calcular o tempo de perman�ncia e o valor cobrado
                //veiculoSaida.CalcularValorCobrado(horaSaida);

                ////mostrar calculo de tempo de permanencia no textbox
                //textBox_tempoDePermanencia.Text = veiculoSaida.TempoPermanenciaFormatado;
            }


        }
    }
}