namespace Exercicio_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //trazer os dados do arquivo para a lista, toda a vez que o programa é executado

            StreamReader leitor = new StreamReader("Jogadores.dat");
            String linha;
            String[] vetorDados;
            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(";");
                listaJogadores.Add(new Jogador(vetorDados[0], vetorDados[1]));

                //Popular o textbox da lista de jogadores
                textBox_listaJogadores.AppendText(vetorDados[0] + " - " + vetorDados[1] + Environment.NewLine);
            }while ( leitor.EndOfStream );
            leitor.Close();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox_nomeJogador.Text.Equals(""))
            {
                MessageBox.Show("É preciso digitar um nome completo", "Alerta!");
            }

            //transformar o nome para maiusculo
            textBox_nomeJogador.Text = textBox_nomeJogador.Text.ToUpper();

            string email;

            //gravar numa lista que não esteja na lista
            if (Jogador.jaCadastrado(textBox_nomeJogador.Text, listaJogadores))
            {
                MessageBox.Show("Jogador já cadastrado.", "Alerta!");
            }
            else
            {
                string[] vetorNomes = textBox_nomeJogador.Text.ToLower().Split(" ");

                if (vetorNomes.Length > 1)
                {
                    email = vetorNomes[vetorNomes.Length - 1] + "." + vetorNomes[0] + "@ufn.edu.br";
                }
                else if (vetorNomes.Length < 1)
                {
                    MessageBox.Show("É preciso digitar um nome", "Alerta!");
                    return;//Retorna imediatamente se o email estiver em branco
                }
                else
                {
                    email = vetorNomes[0] + "@ufn.edu.br";
                }

                listaJogadores.Add(new Jogador(textBox_nomeJogador.Text, email));
                textBox_listaJogadores.AppendText(textBox_nomeJogador.Text + " - " + email + Environment.NewLine);

                //Persistir dados em arquivo texto
                StreamWriter escritor = new StreamWriter("Jogadores.dat",true);//caso o arquivo já exista, o parametro true permite que o jogador seja adicionado ao final do arquivo

                escritor.WriteLine(textBox_nomeJogador.Text + ";" + email);
                 
                escritor.Close();
            }
            textBox_nomeJogador.Text = "";

        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_nomeJogador.Text = "";
            textBox_listaJogadores.Text = "";
            listaJogadores.Clear();
        }

        List<Jogador> listaJogadores = new List<Jogador>();


    }
}