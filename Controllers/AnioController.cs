
using Microsoft.AspNetCore.Mvc;
using System;

namespace ActividadUnidad1.Controllers
{
    public class AnioController : Controller
    {
        public IActionResult Bisiesto(int anio)
        {
            if (DateTime.IsLeapYear(anio))
            {
                ViewData["Resultado"] = $"El año {anio} SÍ es bisiesto.";
            }
            else
            {
                ViewData["Resultado"] = $"El año {anio} NO es bisiesto.";
            }

            return View();
        }
    }
}
