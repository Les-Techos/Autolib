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
            ServiceReservation sr = ServiceReservation.getInstance();
            try
            {
                //sv.rend(sc.GetClient(6), sv.GetVehicule(4));

                var resas = sr.getReservations(sc.GetClient(6), DateTime.Now, DateTime.Now); if(resas.Count == 1) sr.annule_resa(resas[0]);
                int res = 0;
                //res = sv.utilise(sc.GetClient(7), sv.GetVehicule(3), new DateTime(2022, 02, 28, 18, 36, 0, 0), st.GetStation(1), st.GetStation(2));
                //res = st.getPlacesDisponibles(st.GetStation(2));
                var bugg = st.getVehiculesLibre(st.GetStation(2));
                //res = sr.reserve(sc.GetClient(4), sv.GetVehicule(6), new DateTime(2022, 02, 23), new DateTime(2022, 02, 25));

                

                res = res;
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
