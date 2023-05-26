using System.Numerics;

namespace Estacionamento
{
    public partial class Form1 : Form
    {
        private List<Veiculo> listaVeiculosEntrada;
        public Form1()
        {
            InitializeComponent();

            listaVeiculosEntrada = Persistencia.LerArquivoVeiculosEntrada();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker_dataAtual.Value = DateTime.Today;
            dateTimePicker_dataAtual.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dataAtual.CustomFormat = "dd/MM/yyyy";

            dateTimePicker_dataAtual.BackColor = Color.White;
            dateTimePicker_dataAtual.ForeColor = Color.Black;

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
                textBox_listaEntradaDeVeiculos.AppendText(placa + " - " + DateTime.Today.ToShortDateString() + " - " + horaEntrada.ToString() + Environment.NewLine);

                Persistencia.GravarArquivoVeiculosEntrada(listaVeiculosEntrada);

                // Atualizar a lista de ve�culos na caixa de texto
                AtualizarListaVeiculosEntrada();
            }
        }
    }
}