using BibliotecaFinalParadigmas.Clases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Taller_Web.Servicios;

namespace Taller_Web.Controllers
{
    public class CarroController : Controller
    {
        public static List<Carro> lista_carros = new List<Carro>();

        public IActionResult Index()
        {
            return View(lista_carros);
        }
        public IActionResult Crear()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(string placa, string marca, string modelo, ushort agno)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(placa) || string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(modelo))
                {
                    ViewBag.Error = "Todos los campos son obligatorios.";
                    return View();
                }

                var nuevoCarro = new Carro(placa, marca, modelo, agno)
                {
                    Placa = placa,
                    Marca = marca,
                    Modelo = modelo,
                    Agno = agno
                };

                lista_carros.Add(nuevoCarro);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["Error"] = ex.Message;
                return RedirectToAction("Crear");
            }
        }
    }
}
