namespace Estacionamento
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker_dataAtual.Value = DateTime.Today;
            dateTimePicker_dataAtual.Format = DateTimePickerFormat.Custom;
            dateTimePicker_dataAtual.CustomFormat = "dd/MM/yyyy";

            dateTimePicker_dataAtual.BackColor = Color.White;
            dateTimePicker_dataAtual.ForeColor = Color.Black;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.label_horarioAtual.Text = DateTime.Now.ToString("HH:mm");
        }

        private void textBox_Placa_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Placa.Text.Equals(""))
            {
                MessageBox.Show("É necessário inserir uma placa.", "Alerta!");
            }

        }

        private void button_Entrada_Click(object sender, EventArgs e)
        {
            if (textBox_Placa.Text.Equals(""))
            {
                MessageBox.Show("É necessário inserir a placa do veículo.", "Alerta!");
            }


            //transformar a placa para maiusculo
            textBox_Placa.Text = textBox_Placa.Text.ToUpper();

            
            try
            {
                Veiculo veiculo = new Veiculo(placaVeiculo);
                veiculo.PlacaVeiculo = "ABC1234"; // Exemplo de placa inválida com 7 caracteres
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            List<Veiculo> listaEntrada = new List<Veiculo>();

            //gravar veículo que não esteja na lista de entrada
            if (Veiculo.jaCadastrada(textBox_Placa.Text, listaEntrada))
            {
                MessageBox.Show("Veículo já está no estacionamento.", "Alerta!");
            }
            else
            {
                listaEntrada.Add(new Veiculo(textBox_Placa.Text));
                textBox_listaEntradaDeVeiculos.AppendText(textBox_Placa.Text + Environment.NewLine);


            }

        }
    }
}