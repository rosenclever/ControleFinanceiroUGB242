using Microsoft.AspNetCore.Mvc;

namespace Apoio.Controllers
{
    public class ApoioController : Controller
    {
        public IActionResult Empresa()
        {
            return View();
        }
    }
}
