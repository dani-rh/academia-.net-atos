using Microsoft.AspNetCore.Mvc;

namespace Projeto_MVC.Views.OiMundo
{
    public class Welcome : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
