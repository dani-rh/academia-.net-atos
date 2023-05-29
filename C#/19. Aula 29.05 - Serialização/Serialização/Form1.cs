using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using Newtonsoft.Json;


namespace Serialização
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string serializar = textBox1.Text;
            FileStream fs = new FileStream(@"C:\Users\usuario\Documents\GitHub\academia-.net-atos\C#\19. Aula 29.05 - Serialização\Serialização.data", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, serializar);
            fs.Close();
            MessageBox.Show("Serializado com sucesso!!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\usuario\Documents\GitHub\academia-.net-atos\C#\19. Aula 29.05 - Serialização\Serialização.data", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            string msgDesserializada;
            msgDesserializada = (string)bf.Deserialize(fs);
            MessageBox.Show(msgDesserializada);
            label1.Text = msgDesserializada;
        }


        private void btnSerializaXML_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txbNome.Text;
            p.idade = int.Parse(txbIdade.Text);
            p.salario = double.Parse(txbSalario.Text);

            FileStream fs = new FileStream(@"C:\Users\usuario\Documents\GitHub\academia-.net-atos\C#\19. Aula 29.05 - Serialização\pessoal.xml", FileMode.OpenOrCreate);
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));

            xml.Serialize(fs, p);

            MessageBox.Show("Serializado em XML");
            fs.Close();

        }

        private void btnDesserializa_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Pessoa));
            StreamReader reader = new StreamReader(@"C:\Users\usuario\Documents\GitHub\academia-.net-atos\C#\19. Aula 29.05 - Serialização\pessoal.xml");

            Pessoa pDes;
            pDes = (Pessoa)xml.Deserialize(reader);

            labelNome.Text = pDes.nome;
            labelIdade.Text = pDes.idade.ToString();
            labelSalario.Text = pDes.salario.ToString();

            reader.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txbNome.Text;
            p.idade = int.Parse(txbIdade.Text);
            p.salario = double.Parse(txbSalario.Text);

            JsonSerializer serializer = new JsonSerializer();
            StreamWriter sw = new StreamWriter(@"C:\Users\usuario\Documents\GitHub\academia-.net-atos\C#\19. Aula 29.05 - Serialização\pessoas.json");
            JsonWriter writer = new JsonTextWriter(sw);
            serializer.Serialize(writer, p);
            MessageBox.Show("Serializado em Json");
            sw.Close();
            writer.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string json = File.ReadAllText(@"C:\Users\usuario\Documents\GitHub\academia-.net-atos\C#\19. Aula 29.05 - Serialização\pessoas.json");

            Pessoa pDes = JsonConvert.DeserializeObject<Pessoa>(json);
            labelNome.Text = pDes.nome;
            labelIdade.Text = pDes.idade.ToString();
            labelSalario.Text = pDes.salario.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Pessoa p = new Pessoa();
            p.nome = txbNome.Text;
            p.idade = int.Parse(txbIdade.Text);
            p.salario = double.Parse(txbSalario.Text);

            FileStream stream = new FileStream(@"C:\Users\usuario\Documents\GitHub\academia-.net-atos\C#\19. Aula 29.05 - Serialização\pessoas.data", FileMode.Create);
            SoapFormatter soap = new SoapFormatter();
            MessageBox.Show("Serializado SOAP");
            soap.Serialize(stream, p);
            stream.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FileStream stream = new FileStream(@"C:\Users\usuario\Documents\GitHub\academia-.net-atos\C#\19. Aula 29.05 - Serialização\pessoas.data", FileMode.Open);
            SoapFormatter soap = new SoapFormatter();
            Pessoa pDes = new Pessoa();
            pDes = (Pessoa)soap.Deserialize(stream);
            labelNome.Text = pDes.nome;
            labelIdade.Text = pDes.idade.ToString();
            labelSalario.Text = pDes.salario.ToString();
        }
    }
}