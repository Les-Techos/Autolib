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

        public Station GetStation(int id)
        {
            Station vec = null;

            try
            {
                vec = (from v in context.Station
                              where v.IdStation == id
                              select v).FirstOrDefault();
                return vec;
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    
        public int getPlacesDisponibles(Station s)
        {
            int res = 0;

            try
            {
                res = (from borne in context.Borne
                 where borne.Station == s.IdStation && borne.EtatBorne == true
                 select borne).ToList<Borne>().Count();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return res;
        }

        public List<Borne> getPlacesAvecVehc(Station s)
        {
            List<Borne> res = null;

            try
            {
                res = (from borne in context.Borne
                       where borne.Station == s.IdStation && borne.EtatBorne == false
                       select borne).ToList<Borne>();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return res;
        }

        public List<Vehicule> getVehiculesLibre(Station s)
        {
            List<Vehicule> res = null;

            try
            {
                res = (from vec in context.Vehicule
                             join borne in context.Borne on vec.IdVehicule equals borne.IdVehicule
                             where vec.Disponibilite == "LIBRE" && borne.Station == s.IdStation
                             select vec).ToList<Vehicule>();

                var temp2 = (from vec in context.Vehicule
                             join resa in context.Reservation on vec.IdVehicule equals resa.Vehicule
                             where resa.DateReservation < DateTime.Now && resa.DateEcheance > DateTime.Now
                             select vec).ToList<Vehicule>();

                foreach(Vehicule v in temp2){
                    res.Remove(v);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return res;
        }

        public Dictionary<Station, List<Vehicule>> getVehiculesLibresStations()
        {
            Dictionary<Station, List<Vehicule>> res = new Dictionary<Station, List<Vehicule>>();

            List<Station> stations = GetStations();

            foreach (Station s in stations)
            {
                res.Add(s, getVehiculesLibre(s));
            }

            return res;
        }

        public Dictionary<Station, int> getNombreDeBornesDispoStations()
        {
            Dictionary<Station, int> res = new Dictionary<Station, int>();

            List<Station> stations = GetStations();

            foreach (Station s in stations)
            {
                res.Add(s, getPlacesDisponibles(s));
            }

            return res;
        }
        
        public List<TypeVehicule> getTypesVehiculesStations()
        {
            List<TypeVehicule> res = null;

            try
            {
                res = (from TypeVehicule in context.TypeVehicule
                 select TypeVehicule).ToList<TypeVehicule>();
                
            }catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return res;
        }
    }
}
