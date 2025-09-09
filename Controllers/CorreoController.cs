
using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CorreoController : Controller
    {
        public IActionResult Dominio(string email)
        {
            if (string.IsNullOrEmpty(email) || !email.Contains('@'))
            {
                ViewData["Resultado"] = "Por favor, proporciona una dirección de correo válida.";
            }
            else
            {
                string dominio = email.Split('@')[1];
                ViewData["Resultado"] = $"El dominio de '{email}' es: {dominio}";
            }

            return View();
        }
    }
}
