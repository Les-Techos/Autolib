using Autolib.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autolib.Models.Dao
{
    public class ServiceVehicule
    {
        private static ServiceVehicule instance;
        private static autolibContext context;

        public static ServiceVehicule getInstance()
        {
            if(ServiceVehicule.instance == null)
            {
                ServiceVehicule.instance = new ServiceVehicule();
                ServiceVehicule.context = new autolibContext();
            }

            return ServiceVehicule.instance;
        }

        public Vehicule GetVehicule(int id)
        {
            Vehicule vec = null;

            try
            {
                vec = (from v in context.Vehicule
                              where v.IdVehicule == id
                              select v).FirstOrDefault();
                return vec;
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
