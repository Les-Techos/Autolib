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
            if (ServiceReservation.instance == null)
            {
                ServiceReservation.instance = new ServiceReservation();
                ServiceReservation.context = new autolibContext();
            }

            return ServiceReservation.instance;
        }

        //Retourne la réservation faite par c pour v au moment dateplot
        public Reservation GetReservation(Vehicule v, Client c, DateTime dateplot)
        {
            Reservation vec = null;

            try
            {
                vec = (from r in context.Reservations
                       where r.Client == c.IdClient && r.Vehicule == v.IdVehicule && r.DateReservation <= dateplot && r.DateEcheance >= dateplot
                       select r).FirstOrDefault();

                return vec;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
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

    }
}
