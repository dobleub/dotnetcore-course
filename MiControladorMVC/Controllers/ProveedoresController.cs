using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MiControladorMVC.Controllers
{
    public class ProveedoresController : Controller
    {
        public IActionResult TodosLosProveedores() {
            var html = @"<ul>
                <li>Prov 1</li>
                <li>Prov 2</li>
                <li>Prov 3</li>
                <li>Prov 4</li>
                <li>Prov 5</li>
            </ul>";
            var list = HtmlEncoder.Default.Encode(html);
            
            return Content(list);
        }
    }
}