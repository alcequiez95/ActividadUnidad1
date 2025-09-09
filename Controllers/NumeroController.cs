
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class NumeroController : Controller
    {
        public IActionResult ParImpar(int numero)
        {
            if (numero % 2 == 0)
            {
                ViewData["Resultado"] = $"El número {numero} es PAR.";
            }
            else
            {
                ViewData["Resultado"] = $"El número {numero} es IMPAR.";
            }

            return View();
        }
    }
}
