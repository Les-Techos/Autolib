using Autolib.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autolib.Models.ViewModel
{
    public class HomeModel
    {
        public List<Station> stations = null;
        public Dictionary<Station, List<Vehicule>> nbVechDispo = null;
        public Dictionary<Station, int> nbBornesDispo = null;

        public HomeModel(List<Station> stations, Dictionary<Station, List<Vehicule>> nbVechDispo, Dictionary<Station, int> nbBornesDispo)
        {
            this.stations = stations;
            this.nbVechDispo = nbVechDispo;
            this.nbBornesDispo = nbBornesDispo;
        }
    }
}
