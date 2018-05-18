using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace MiSeguridadMVC.Controllers
{
    [Authorize (Policy = "TestUser")]
    public class AccesoController : Controller
    {
        public ContentResult Privado() {
            return Content("Private ActionController");
        }

        [AllowAnonymous]
        public ContentResult Publico() {
            return Content("Public ActionController");
        }
    }
}