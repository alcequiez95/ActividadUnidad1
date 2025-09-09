
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ActividadUnidad1.Controllers
{
    public class PalindromaController : Controller
    {
        public IActionResult Palabra(string palabra)
        {
            if (string.IsNullOrEmpty(palabra))
            {
                ViewData["Resultado"] = "Por favor, proporciona una palabra en la URL.";
                return View();
            }

            var palabraNormalizada = new string(palabra.Where(char.IsLetterOrDigit).ToArray()).ToLower();
            var palabraInvertida = new string(palabraNormalizada.Reverse().ToArray());

            if (palabraNormalizada == palabraInvertida)
            {
                ViewData["Resultado"] = $"La palabra '{palabra}' SÍ es un palíndromo.";
            }
            else
            {
                ViewData["Resultado"] = $"La palabra '{palabra}' NO es un palíndromo.";
            }

            return View();
        }
    }
}
