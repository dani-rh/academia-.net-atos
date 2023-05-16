namespace Anotações
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Veiculo v = new Veiculo();
            v._potencia = 500;
            v._modelo = "Gol";
            v.Ligar();


            VeiculoEletrico ve = new VeiculoEletrico();
            ve._potencia = 100;
            ve._modelo = "Tesla";
            ve._autonomia = 10;
            ve.Ligar();
            ve.Carregar();

            Motocicleta m = new Motocicleta();
            m.Ligar();


        }
    }
}