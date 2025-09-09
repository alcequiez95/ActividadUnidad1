
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ActividadUnidad1.Controllers
{
    public class ClaveController : Controller
    {
        public IActionResult Segura(string clave)
        {
            if (string.IsNullOrEmpty(clave))
            {
                ViewData["Resultado"] = "Por favor, proporciona una clave en la URL.";
                return View();
            }

            bool tieneMinimo8Caracteres = clave.Length >= 8;
            bool tieneMayuscula = clave.Any(char.IsUpper);
            bool tieneNumero = clave.Any(char.IsDigit);

            if (tieneMinimo8Caracteres && tieneMayuscula && tieneNumero)
            {
                ViewData["Resultado"] = "La contraseña SÍ es segura.";
            }
            else
            {
                ViewData["Resultado"] = "La contraseña NO es segura. Debe tener al menos 8 caracteres, una mayúscula y un número.";
            }

            return View();
        }
    }
}
