using Autolib.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autolib.Models.Dao
{
    public class ServiceUtilise
    {
        private static ServiceUtilise instance;
        private static autolibContext context;

        public static ServiceUtilise getInstance()
        {
            if (ServiceUtilise.instance == null)
            {
                ServiceUtilise.instance = new ServiceUtilise();
                ServiceUtilise.context = new autolibContext();
            }

            return ServiceUtilise.instance;
        }

        //Retourne la réservation faite par c pour v au moment dateplot
        public Utilise GetUtilise(Vehicule v, Client c)
        {
            Utilise vec = null;

            try
            {
                vec = (from r in context.Utilises
                       where r.Client == c.IdClient && r.Vehicule == v.IdVehicule
                       select r).FirstOrDefault();

                return vec;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
