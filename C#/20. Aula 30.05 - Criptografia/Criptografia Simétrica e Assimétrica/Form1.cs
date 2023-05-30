using System.ComponentModel.DataAnnotations;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        private Assimetrica a = new Assimetrica(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Cripto_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            string msg = txbMensagem.Text;
            string msgCripto = s.EncryptData(msg, "atos");
            lblCripto.Text = msgCripto;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Simetrica s = new Simetrica();
            lblDescripto.Text = s.DecryptData(lblCripto.Text, "atos");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Assimetrica a = new Assimetrica();
            //MessageBox.Show(a.getPublicKey()); //retorna mensagem publica
            string msg, msgCripto;
            msg = txbMensagem.Text;
            msgCripto = a.encrypt(msg);
            lblCripto.Text = msgCripto;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //descriptograr assimetrica
            lblDescripto.Text = a.decrypt(lblCripto.Text);

        }
    }
}