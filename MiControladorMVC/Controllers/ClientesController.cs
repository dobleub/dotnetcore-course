using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MiControladorMVC.Controllers
{
    public class ClientesController : Controller
    {
        public IActionResult Buscar(string name)
        {
            // return View();
            var input = HtmlEncoder.Default.Encode(name);
            return Content(input);
        }

        [HttpGet]
        public IActionResult Buscar() {
            var input = HtmlEncoder.Default.Encode("Selector HTTP GET");
            return Content(input);
        }
    }
}