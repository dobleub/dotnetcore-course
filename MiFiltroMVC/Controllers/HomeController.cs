using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MiFiltroMVC.Models;

namespace MiFiltroMVC.Controllers
{
    public class HomeController : Controller
    {
        // [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // [Authorize(Roles="Admin")]
        // [ResponseCache(Duration = 10)]
        [ResponseCache(CacheProfileName="default")]
        [ActionName("Hora")]
        public string HoraActual() {
            return StringHora();
        }

        [NonAction] // No se puede acceder por uri
        public string StringHora() {
            return DateTime.Now.ToString("T");
        }
    }
}
