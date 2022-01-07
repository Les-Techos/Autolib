using Autolib.Models;
using Autolib.Models.Dao;
using Autolib.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Autolib.Controllers
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
            Vehicule monVehicule = null;

            try
            {
                monVehicule = ServiceVehicule.getInstance().GetVehicule(5);
            }catch(Exception e)
            {
                ModelState.AddModelError("Erreur", "Echec de la récupération d'un vehicule" + e.Message);
            }
            return View(monVehicule);
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
