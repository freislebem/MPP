using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DiarioDePesca.Services;

namespace DiarioDePesca.Controllers
{
    public class CorAguaController : Controller
    {

        private readonly CorAguaService _corAguaController;

        public CorAguaController(CorAguaService corAguaController)
        {
            _corAguaController = corAguaController;
        }

        public IActionResult Index()
        {
            var list = _corAguaController.FindAll();
            return View(list);
        }
    }
}