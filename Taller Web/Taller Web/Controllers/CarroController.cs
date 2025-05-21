using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taller_Web.Servicios;
using BibliotecaFinalParadigmas.Clases;

namespace Taller_Web.Controllers
{
    public class CarroController : Controller
    {
        private readonly CarroService _servicios;

        public CarroController(CarroService servicio)
        {
            _servicios = servicio;
        }

        public IActionResult Index()
        {
            return View(_servicios.ObtenerTodos());
        }

        public IActionResult Crear()
        {
            return View();
        }

        // [HttpPost]

        /*
        public IActionResult Crear(string placa, string)
        {
            var nuevo = new Carro();
        } */
    }
}
