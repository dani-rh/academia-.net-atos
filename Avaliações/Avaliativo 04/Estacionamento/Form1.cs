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
    }
}