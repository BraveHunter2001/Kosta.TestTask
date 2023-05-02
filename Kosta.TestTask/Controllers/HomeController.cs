using Microsoft.AspNetCore.Mvc;

namespace Kosta.TestTask.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
