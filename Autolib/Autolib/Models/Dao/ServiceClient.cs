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
                ServiceClient.context = new autolibContext();
            }

            return ServiceClient.instance;
        }

        public Client GetClient(int id)
        {
            Client vec = null;

            try
            {
                vec = (from v in context.Clients
                       where v.IdClient == id
                       select v).FirstOrDefault();

                return vec;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Client GetClient(string login)
        {
            Client vec = null;

            try
            {
                vec = (from v in context.Clients
                       where v.Login == login
                       select v).FirstOrDefault();
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

        public void UpdateClient(Client c)
        {
            // Query the database for the row to be updated.
            Client clientDB = GetClient(c.IdClient);

            // Execute the query, and change the column values
            // you want to change.
            clientDB = c;

            // Submit the changes to the database.
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

        public void InsertClient(Client c)
        {
            context.Clients.Add(c);
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

        public void RemoveClient(Client c)
        {

            context.Clients.Remove(c);
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
