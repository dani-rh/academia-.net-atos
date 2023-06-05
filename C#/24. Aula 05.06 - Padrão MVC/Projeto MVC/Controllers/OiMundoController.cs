using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Projeto_MVC.Controllers
{
    public class OiMundoController : Controller
    {
        public IActionResult Index()
        //public string Index()
        {
            return View();
            //return "Apresente esta mensagem";
        }

        public string Welcome(string nome, int ID = 1)
        {
            //return "Estou no método Welcome do OiMundoController";
            //return HtmlEncoder.Default.Encode($"Oi {nome}, vezes: {vezes}");
            return HtmlEncoder.Default.Encode($"Oi {nome}, ID: {ID}");
        }

        public string Oi()
        {
            return "oi";
        }
    }
}
