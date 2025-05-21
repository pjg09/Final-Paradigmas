using Microsoft.AspNetCore.Mvc;

namespace Taller_Web.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
