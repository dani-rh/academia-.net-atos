using Newtonsoft.Json;
using System.Net.Http.Json;
using System.Text.Json.Serialization;

namespace ConsumirAPI
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Consumindo a API desenvolvida");
            int op;
            string BaseUrl = "http://localhost:5177/";

            do
            {
                Console.WriteLine("Informe a opção desejada: ");
                Console.WriteLine("1 - consultar pessoas");
                Console.WriteLine("2 - cadastrar pessoas");
                Console.WriteLine("3 - alterar pessoas");
                Console.WriteLine("4 - excluir pessoas");
                Console.WriteLine("0 - sair");

                op = int.Parse(Console.ReadLine());

                switch(op)
                {
                    case 0:
                        break;
                    case 1:
                        List<Pessoa>pessoas = new List<Pessoa>(); //receber o que eu tenho armazenado no sistema
                        HttpClient client = new HttpClient(); //instanciando um objeto para fazer o acesso via http na API
                        client.BaseAddress = new Uri(BaseUrl);//definindo o endereço da api
                        client.DefaultRequestHeaders.Clear();
                        client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));//definindo a forma de comunicação com a API (nesse caso via json)

                        HttpResponseMessage response = await client.GetAsync("pessoas");//acessando o endpoint da API

                        if(response.IsSuccessStatusCode) //obtive sucesso na resposta, entro no if
                        {
                            var retorno = response.Content.ReadAsStringAsync().Result;//obtenho o retorno de uma consulta a API
                            pessoas = JsonConvert.DeserializeObject<List<Pessoa>>(retorno);//pegando o retorno e desserializando e armazenando na lista
                        }
                        else
                        {
                            Console.WriteLine("Erro: " + response.StatusCode.ToString());
                        }
                        foreach (Pessoa p in pessoas)
                        {
                            Console.WriteLine("ID: " + p.id +"\nNome: " + p.nome);
                        }
                        break;
                    case 2:
                        Pessoa pessoa = new Pessoa();
                        Console.WriteLine("Digite o nome da pessoa: ");
                        pessoa.nome = Console.ReadLine();

                        HttpClient cliente = new HttpClient();
                        HttpResponseMessage responsePost = await cliente.PostAsJsonAsync(BaseUrl + "pessoas", pessoa);
                        
                        Console.WriteLine("Retorno: " + responsePost.StatusCode);

                        break;
                    case 3:
                        Pessoa palt = new Pessoa();
                        Console.WriteLine("Digite o id da pessoa que deseja alterar: ");
                        palt.id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite o novo nome da pessoa: ");
                        palt.nome = Console.ReadLine();


                        HttpClient clientealt = new HttpClient();
                        HttpResponseMessage responsePut = await clientealt.PutAsJsonAsync(BaseUrl + "pessoas/{id}", palt);

                        Console.WriteLine("Retorno: " + responsePut.StatusCode);


                        break;
                    case 4:
                        break;

                }


            } while (op != 0);

        }
    }
}