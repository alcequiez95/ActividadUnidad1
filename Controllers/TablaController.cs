
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ActividadUnidad1.Controllers
{
    public class TablaController : Controller
    {
        public IActionResult Multiplicar(int numero)
        {
            List<string> tabla = new List<string>();
            for (int i = 1; i <= 10; i++)
            {
                tabla.Add($"{numero} x {i} = {numero * i}");
            }

            ViewBag.Tabla = tabla;
            ViewBag.Numero = numero;
            return View();
        }
    }
}
