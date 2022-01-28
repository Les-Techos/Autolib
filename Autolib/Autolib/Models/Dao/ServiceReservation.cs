using Autolib.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autolib.Models.Dao
{
    public class ServiceReservation
    {
        private static ServiceReservation instance;
        private static autolibContext context;

        public static ServiceReservation getInstance()
        {
            if(ServiceReservation.instance == null)
            {
                ServiceReservation.instance = new ServiceReservation();
                ServiceReservation.context = new autolibContext();
            }

            return ServiceReservation.instance;
        }

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

        public void annule_resa(Reservation r)
        {
            if(r != null)
            {
                context.Reservation.Remove(r);
                save();
            }
        }

        //Récupère les réservations faîte par c
        public List<Reservation> getReservations(Client c)
        {
            return (from resa in context.Reservation
                    where (resa.Client == c.IdClient)
                    select resa).ToList<Reservation>();
        }

        //Récupère les réservations faîte par v
        public List<Reservation> getReservations(Vehicule v)
        {
            return (from resa in context.Reservation
                    where (resa.Vehicule == v.IdVehicule)
                    select resa).ToList<Reservation>();
        }

        //Récupère les réservations faîtes pour v comprises dans [debut; fin]
        public List<Reservation> getReservations(Vehicule v, DateTime debut, DateTime fin)
        {
            return (from resa in context.Reservation
                    where (resa.Vehicule == v.IdVehicule) && ((resa.DateReservation <= debut && resa.DateEcheance >= debut) || (resa.DateReservation <= fin && resa.DateEcheance >= fin) || (resa.DateReservation <= debut && resa.DateEcheance >= fin))
                    select resa).ToList<Reservation>();
        }

        public List<Reservation> getReservations(Client c, DateTime debut, DateTime fin)
        {
            return (from resa in context.Reservation
                    where (resa.Client == c.IdClient) && ((resa.DateReservation <= debut && resa.DateEcheance >= debut) || (resa.DateReservation <= fin && resa.DateEcheance >= fin) || (resa.DateReservation <= debut && resa.DateEcheance >= fin))
                    select resa).ToList<Reservation>();
        }

        //Réserve v pour c entre debut et fin
        public int reserve(Client c, Vehicule v, DateTime debut, DateTime fin)
        {
            int res = -1;

            //Check si la voiture est déjà réservée
            List<Reservation> reservations_c = getReservations(c, debut, fin); //Regarde si c a déjà réservé un autre véhicule sur debut fin
            List<Reservation> reservations_v = getReservations(v, debut, fin); //Regarde si v est déjà réservée sur debut fin

            if (reservations_v.Count() == 0 && reservations_c.Count() == 0) //Si aucune réservation n'est faite
            {
                Reservation r = new Reservation();
                r.Client = c.IdClient;
                r.Vehicule = v.IdVehicule;
                r.DateReservation = debut;
                r.DateEcheance = fin;

                context.Reservation.Add(r);
                save();
                res = 0;
            }else if (reservations_c.Count == 1 && reservations_c[0].Vehicule == v.IdVehicule)
            {// Ce véhicule est déjà réservé par c
                res = 1;
            }
            else //Une réservation existe déjà pour c
                res = -2;

            return res;
        }
   
    }
}
