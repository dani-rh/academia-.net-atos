using System.Data;

namespace ADOnet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTodos_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from pessoas";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;

        }

        //não se faz isso::!!!
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            Banco bd = new Banco();

            string sql = "select * from pessoas where nome = '" + txbNome.Text + "'";

            DataTable dt = new DataTable();

            dt = bd.executarConsultaGenerica(sql);

            dataGridView1.DataSource = dt;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txbNome.Text;
            p.profissao = txtProfissao.Text;

            if (p.gravarPessoa())
            {
                MessageBox.Show("Cadastrado com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Pessoa p = new Pessoa();
            p.id = Convert.ToInt32(txbID.Text);

            if (p.excluirPessoa())
            {
                MessageBox.Show("Excluída com sucesso!");
            }
            else
            {
                MessageBox.Show("Erro ao excluir!");
            }
        }
    }
}