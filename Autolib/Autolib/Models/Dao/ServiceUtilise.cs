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

        public Utilise GetUtilise(Vehicule v, Client c)
        {
            Utilise vec = null;

            try
            {
                vec = (from u in context.Utilise
                       where u.Client == c.IdClient && u.Vehicule == v.IdVehicule
                       select u).FirstOrDefault();
                return vec;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Utilise> getUtilises(Client c)
        {
            List<Utilise> vec = null;

            try
            {
                vec = (from u in context.Utilise
                       where u.Client == c.IdClient
                       select u).ToList<Utilise>();
                return vec;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
