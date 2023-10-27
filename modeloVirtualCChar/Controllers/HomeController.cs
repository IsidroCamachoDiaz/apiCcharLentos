using DB;
using Microsoft.AspNetCore.Mvc;
using modeloVirtualCChar.Models;
using System.Diagnostics;

namespace modeloVirtualCChar.Controllers
{
    public class HomeController : Controller
    {
        private readonly gestorBibliotecaContext contexto;

        public HomeController(gestorBibliotecaContext contexto)
        {
            this.contexto = contexto;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}