
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using DiarioDePesca.Models;

namespace DiarioDePesca.Controllers
{
    public class EspeciesController : Controller
    {
        public IActionResult Index()
        {
            List<Especie> list = new List<Especie>();
            list.Add(new Especie { Id = 1, Nome = "Papa-Terra", NomeB = "Betara", NomeCientifico = "Menticirrhus" });
            list.Add(new Especie { Id = 2, Nome = "Pampo", NomeB = "Sernambiguara", NomeCientifico = "Trachinotus falcatus" });

            ViewData["Message"] = "Lista de Espécies";
            ViewData["Title"] = "Lista de Espécies";
            return View(list);
        }
    }
}