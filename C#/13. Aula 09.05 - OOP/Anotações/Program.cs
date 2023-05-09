namespace Anotações
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Ricardo";
            p1.Email = "dkasçakd@gmail.com";
            p1.End = new Endereco();
            p1.End.Rua = "Rua Caracas";
            p1.End.Num = 327;
            p1.End.Complemento = "Gleba Palhano";
            Pessoa p2 = new Pessoa();
            p2.Nome = "Daniela";
            p2.Email = "dkasçakd@gmail.com";
            p2.End = new Endereco();
            p2.End.Rua = "Rua Caracas";
            p2.End.Num = 327;
            p2.End.Complemento = "Gleba Palhano";
            Pessoa p3 = new Pessoa();
            p3.Nome = "Fabricio";
            p3.Email = "dkasçakd@gmail.com";
            p3.End = new Endereco();
            p3.End.Rua = "Rua Caracas";
            p3.End.Num = 327;
            p3.End.Complemento = "Gleba Palhano";



            //Console.WriteLine("Nome: "+p.Nome);
            //Console.WriteLine("Email: "+p.Email);

            //Console.WriteLine("Endereço: \nRua: "+p.End.Rua);
            //Console.WriteLine("Número: "+p.End.Num);
            //Console.WriteLine("Complemento: "+p.End.Complemento);

            List<Pessoa> listaPessoas = new List<Pessoa>();
            listaPessoas.Add(p1);
            listaPessoas.Add(p2);
            listaPessoas.Add(p3);

            foreach(Pessoa pessoa in listaPessoas)
            {
                Console.WriteLine("Nome: "+pessoa.Nome);
                Console.WriteLine("Email: "+pessoa.Email);
                Console.WriteLine("Rua: "+pessoa.End.Rua);
                Console.WriteLine("Número: "+pessoa.End.Rua);
                Console.WriteLine("Complemento: "+pessoa.End.Complemento);
            }



        }
    }
}