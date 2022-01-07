using Autolib.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autolib.Models.Dao
{
    public class ServiceClient
    {
        private static ServiceClient instance;
        private static autolibContext context;

        public static ServiceClient getInstance()
        {
            if (ServiceClient.instance == null)
            {
                ServiceClient.instance = new ServiceClient();
                // on définit un contexte commun à toutes les requêtes
                context = new autolibContext();
            }
            return ServiceClient.instance;
        }

        public Client GetUnUtilisateur(String login)
        {
            Client unUtilisateur = null;

            try
            {
                unUtilisateur = (from u in context.Client
                                 where u.Login == login
                                 select u)
                           .FirstOrDefault();

                return unUtilisateur;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
