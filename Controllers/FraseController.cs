
using Microsoft.AspNetCore.Mvc;
using System;

namespace ActividadUnidad1.Controllers
{
    public class FraseController : Controller
    {
        public IActionResult ContarPalabras(string frase)
        {
            if (string.IsNullOrWhiteSpace(frase))
            {
                ViewData["Resultado"] = "Por favor, proporciona una frase en la URL.";
                return View();
            }

            string[] palabras = frase.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int cantidad = palabras.Length;

            ViewData["Resultado"] = $"La frase '{frase}' contiene {cantidad} palabras.";

            return View();
        }
    }
}
