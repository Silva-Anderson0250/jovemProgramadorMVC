using Microsoft.AspNetCore.Mvc;

namespace jovemProgramadorMVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
