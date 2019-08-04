using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiarioDePesca.Models.ViewModels;

namespace DiarioDePesca.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Diário de Pesca - MPP";
            ViewData["Message"] = "Diário de Pesca - MPP";
            return View();
        }

        public IActionResult Privacy()
        {
            ViewData["Title"] = "Política de Privacidade";
            ViewData["Message"] = "Detalhes sobre Política de Privacidade do Diário";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
