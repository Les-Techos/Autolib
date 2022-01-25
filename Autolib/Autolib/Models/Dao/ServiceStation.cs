using Autolib.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autolib.Models.Dao
{
    public class ServiceStation
    {
        private static ServiceStation instance;
        private static autolibContext context;

        public static ServiceStation getInstance()
        {
            if(ServiceStation.instance == null)
            {
                ServiceStation.instance = new ServiceStation();
                ServiceStation.context = new autolibContext();
            }

            return ServiceStation.instance;
        }

        public List<Station> GetStations()
        {
            try
            {
                var stations = (from station in context.Station
                       select station);
                return stations.ToList<Station>();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Vehicule GetStation(int id)
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
