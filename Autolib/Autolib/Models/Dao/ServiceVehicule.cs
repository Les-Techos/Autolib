using Autolib.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autolib.Models.Dao
{
    public class ServiceVehicule
    {
        //private ServiceReservation s_resa = ServiceReservation.getInstance();
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
                vec = (from v in context.Vehicules
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

        //Récupère les réservations faîte par c
        public List<Reservation> getReservations(Client c)
        {
            return (from resa in context.Reservations
                    where (resa.Client == c.IdClient)
                    select resa).ToList<Reservation>();
        }

        //Récupère les réservations faîte par v
        public List<Reservation> getReservations(Vehicule v)
        {
            return (from resa in context.Reservations
                    where (resa.Vehicule == v.IdVehicule)
                    select resa).ToList<Reservation>();
        }

        //Récupère les réservations faîtes pour v comprises dans [debut; fin]
        public List<Reservation> getReservations(Vehicule v, DateTime debut, DateTime fin)
        {
            return (from resa in context.Reservations
                    where (resa.Vehicule == v.IdVehicule) && ((resa.DateReservation <= debut && resa.DateEcheance >= debut) || (resa.DateReservation <= fin && resa.DateEcheance >= fin))
                    select resa).ToList<Reservation>();
        }

        //Réserve v pour c entre debut et fin
        public int reserve(Client c, Vehicule v, DateTime debut, DateTime fin)
        {
            int res = -1;

            //Check si la voiture est déjà réservée

            List<Reservation> reservations = getReservations(v,debut,fin); //Regarde si v est déjà réservée sur debut fin

            if (reservations.Count() == 0) //Si aucune réservation n'est faite
            {
                Reservation r = new Reservation();
                r.Client = c.IdClient;
                r.Vehicule = v.IdVehicule;
                r.DateReservation = debut;
                r.DateEcheance = fin;

                context.Reservations.Add(r);
                save();
                res = 0;
            }
            else //Une réservation existe déjà
                res = -2;

            return res;
        }

        //c utilise v entre depart et arrivee
        public int utilise(Client c, Vehicule v, DateTime fin, Station depart, Station arrivee)
        {
            int res = -1;

            if (v.Disponibilite == "LIBRE")
            { //Vehicule actuellement libre

                DateTime now = DateTime.Now;
                List<Reservation> resa_v = getReservations(v, now, fin);
                if(resa_v.Count == 0)
                {//Aucune réservation de faîte jusqu'à la fin
                    Reservation resa = new Reservation();
                    resa.Client = c.IdClient;
                    resa.Vehicule = v.IdVehicule;
                    resa.DateReservation = now;
                    resa.DateEcheance = fin;

                    context.Add(resa);
                    res = 0;
                }
                else if(resa_v[0].Client == c.IdClient)
                {//Réservation mais faîte par c
                    
                    res = 0;
                }

                if(res == 0)
                {
                    v.Disponibilite = "INDISPONIBLE";
                    Utilise u = new Utilise();
                    u.Vehicule = v.IdVehicule;
                    u.Client = c.IdClient;
                    u.Date = fin;
                    u.BorneDepart = depart.IdStation;
                    u.BorneArrivee = arrivee.IdStation;
                    context.Utilises.Add(u);
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
                List<Reservation> resa = getReservations(v, DateTime.Now, DateTime.Now);
                if (resa.Count() > 1) res = -2;
                else
                {//Si n'y a qu'une seul réservation
                    if (resa[0].Client == c.IdClient)
                    {//Et que c'est bien c qui l'a réservé
                        v.Disponibilite = "LIBRE";
                        Utilise u = s_utilise.GetUtilise(v, c);
                        context.Utilises.Remove(u);
                        save();
                    }
                }
            }
            return res;
        }
    }
}
