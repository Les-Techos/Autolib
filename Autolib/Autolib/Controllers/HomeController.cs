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
            ServiceClient sc = ServiceClient.getInstance();
            ServiceVehicule sv = ServiceVehicule.getInstance();
            ServiceStation st = ServiceStation.getInstance();
            try
            {
                //int success = sv.utilise(sc.GetClient(3), sv.GetVehicule(2), new DateTime(2022, 01, 28), st.GetStation(1), st.GetStation(2));
                sv.rend(sc.GetClient(3), sv.GetVehicule(2));
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                ModelState.AddModelError("Erreur", "Echec de la récupération d'un vehicule" + e.Message);
            }

            return View(); // View(stations);
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
