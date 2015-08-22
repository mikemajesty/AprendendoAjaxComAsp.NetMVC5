using Aprendendo.Models;
using System.Web.Mvc;

namespace Aprendendo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "Nome,Sobrenome,Idade")] Cliente cli)
        {
            return PartialView("Tabela", cli);
        }
    }
}