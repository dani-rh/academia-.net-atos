namespace Windows_Form_01
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGerarEmail_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Botão gerar email foi clicado");


            string[] vetorSobrenome = textBoxSobrenome.Text.Split(' ');
            string[] vetorNome = textBoxNome.Text.Split(" ");

            textBoxEmail.Text = vetorSobrenome[vetorSobrenome.Length - 1].ToLower() + "_" + vetorNome[0].ToLower() + "@ufn.edu.br";

            textBoxListaEmail.AppendText(textBoxEmail.Text + Environment.NewLine);
            buttonLimpar.Enabled = true;

            textBoxNome.Text = string.Empty;
            textBoxSobrenome.Text = string.Empty;

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            textBoxNome.Text = string.Empty;
            textBoxSobrenome.Text = string.Empty;
            textBoxEmail.Text = string.Empty;
            textBoxListaEmail.Text = string.Empty;
            buttonLimpar.Enabled = false;

        }
    }
}