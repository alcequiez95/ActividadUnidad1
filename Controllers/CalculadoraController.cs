
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CalculadoraController : Controller
    {
        public IActionResult Sumar(int num1, int num2)
        {
            int resultado = num1 + num2;
            ViewData["Resultado"] = $"{num1} + {num2} = {resultado}";
            return View("Resultado");
        }

        public IActionResult Restar(int num1, int num2)
        {
            int resultado = num1 - num2;
            ViewData["Resultado"] = $"{num1} - {num2} = {resultado}";
            return View("Resultado");
        }

        public IActionResult Multiplicar(int num1, int num2)
        {
            int resultado = num1 * num2;
            ViewData["Resultado"] = $"{num1} * {num2} = {resultado}";
            return View("Resultado");
        }

        public IActionResult Dividir(double num1, double num2)
        {
            if (num2 != 0)
            {
                double resultado = num1 / num2;
                ViewData["Resultado"] = $"{num1} / {num2} = {resultado}";
            }
            else
            {
                ViewData["Resultado"] = "Error: No se puede dividir por cero.";
            }
            return View("Resultado");
        }
    }
}
