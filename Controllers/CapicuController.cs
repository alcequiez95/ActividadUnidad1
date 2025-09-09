
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ActividadUnidad1.Controllers
{
    public class CapicuController : Controller
    {
        public IActionResult Verificar(int numero)
        {
            string numeroStr = numero.ToString();
            string numeroInvertido = new string(numeroStr.Reverse().ToArray());

            if (numeroStr == numeroInvertido)
            {
                ViewData["Resultado"] = $"El número {numero} SÍ es capicúa.";
            }
            else
            {
                ViewData["Resultado"] = $"El número {numero} NO es capicúa.";
            }

            return View();
        }
    }
}
