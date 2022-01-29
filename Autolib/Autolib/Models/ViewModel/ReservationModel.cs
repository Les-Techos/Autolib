using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autolib.Models.Domain;



namespace Autolib.Models.ViewModel
{
    public class ReservationModel
    {
        public List<Vehicule> voitures;
        public List<Borne> bornes;
        public List<TypeVehicule> types;

        public ReservationModel(List<Vehicule> vehc, List<Borne> bornes, List<TypeVehicule> types)
        {
            this.voitures = vehc;
            this.bornes = bornes;
            this.types = types;
        }
    }
}
