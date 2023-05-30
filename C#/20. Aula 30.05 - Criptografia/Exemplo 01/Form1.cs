using CriptografiaSimetricaAndAssimetrica;

namespace Exemplo_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arquivoCripto = @"C:\\Users\\usuario\\Documents\\GitHub\\academia-.net-atos\\C#\\20. Aula 30.05 - Criptografia\\Exemplo 01\dadoscripto.txt";

            string arquivoDescripto = @"C:\Users\usuario\Documents\GitHub\academia-.net-atos\C#\20. Aula 30.05 - Criptografia\Exemplo 01\dadosdescripto.txt";

            Simetrica s = new Simetrica();
            string textoCriptografado = File.ReadAllText(arquivoCripto);
            textBox1.Text = textoCriptografado;
            string textoDescriptografado = s.DecryptData(textoCriptografado, "atos20232");
            File.WriteAllText(arquivoDescripto, textoDescriptografado);
            lblDescripto.Text = textoDescriptografado;
            MessageBox.Show("Arquivo descriptografado com sucesso!");

        }

    }
}