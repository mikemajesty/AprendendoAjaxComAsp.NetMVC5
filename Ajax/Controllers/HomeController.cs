using Aprendendo.Models;
using System.Web.Mvc;
using System.Linq;
namespace Aprendendo.Controllers
{
    public class HomeController : Controller
    {
        private DataContext Banco { get; set; }
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
        [HttpGet]
        public ActionResult Lista()
        {

            Banco = new DataContext();
            return View(Banco.Cliente.ToList());
        }
        [HttpGet]
        public ActionResult Salvar() => View();
        [HttpPost]
        public ActionResult Salvar(Cliente cli)
        {
            using (Banco = new DataContext())
            {
                Banco.Entry<Cliente>(cli).State = System.Data.Entity.EntityState.Added;
                if (true)
                {

                }
                return View();
            }
            
        }
    }
}