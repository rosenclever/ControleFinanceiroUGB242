using Microsoft.AspNetCore.Mvc;

namespace Apoio.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
