using AbovePremiereWeb.Models;
using AboveWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AboveWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Registrarse()
        {
            return View();
        }
        public IActionResult RegistroDeUsuario()
        {
            string nombre = Request.Form["nombre"];
            string apellido = Request.Form["apellido"];
            string userName = Request.Form["usuario"];
            string pwd = Request.Form["password"];
            string email = Request.Form["email"];
            string licencia = Request.Form["licencia"];
            Usuario user = new Usuario(nombre, apellido, userName, pwd, email, licencia);
            UsuariosRegistrados.agregarUsuarios(user);
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
