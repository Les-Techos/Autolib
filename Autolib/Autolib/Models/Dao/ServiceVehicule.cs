using Autolib.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autolib.Models.Dao
{
    public class ServiceVehicule
    {
        private ServiceReservation s_resa = ServiceReservation.getInstance();
        private ServiceUtilise s_utilise = ServiceUtilise.getInstance();
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

        //Save modifications
        public void save()
        {
            try
            {
                context.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                // Provide for exceptions.
            }
        }

        //c utilise v entre depart et arrivee
        public int utilise(Client c, Vehicule v, DateTime fin, Station depart, Station arrivee)
        {
            int res = -1;

            if (v.Disponibilite == "LIBRE")
            { //Vehicule actuellement libre

                DateTime now = DateTime.Now;

                res = s_resa.reserve(c, v, now, fin);
                
                if(res == 0)
                {
                    v.Disponibilite = "INDISPONIBLE";
                    Utilise u = new Utilise();
                    u.Vehicule = v.IdVehicule;
                    u.Client = c.IdClient;
                    u.Date = fin;
                    u.BorneDepart = depart.IdStation;
                    u.BorneArrivee = arrivee.IdStation;
                    context.Utilise.Add(u);
                    save();
                }
            }
            
           return res;
        }

        //TODO Gérer les retards
        public int rend(Client c, Vehicule v)
        {
            int res = -1;
            if (v.Disponibilite == "INDISPONIBLE")
            {//Si la voiture est bien utilisee
                Utilise u = s_utilise.GetUtilise(v, c);
                if(u != null)
                {//Si n'y a qu'une seul réservation
                    if (u.Client == c.IdClient)
                    {//Et que c'est bien c qui l'a réservé
                        v.Disponibilite = "LIBRE";
                        context.Utilise.Remove(u);
                        save();
                    }
                }
            }
            return res;
        }
    }
}
