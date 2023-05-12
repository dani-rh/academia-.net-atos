namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();

            Persistencia.popularArquivoLista("./dados.dat", listaPessoas);

            Persistencia.exibirLista(listaPessoas);
        }
    }
}