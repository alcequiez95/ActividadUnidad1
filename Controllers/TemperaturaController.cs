
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class TemperaturaController : Controller
    {
        public IActionResult Convertir(double celsius)
        {
            double fahrenheit = (celsius * 9 / 5) + 32;

            ViewData["Celsius"] = celsius;
            ViewData["Fahrenheit"] = fahrenheit;

            return View();
        }
    }
}
