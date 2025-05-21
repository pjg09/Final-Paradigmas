using Microsoft.AspNetCore.Mvc;

namespace Taller_Web.Controllers
{
    public class MantenimientoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Crear()
        {
            return View(); // Esto mostrará la vista Crear.cshtml
        }
    }
}
