using Autolib.Models.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMangaEntity.Models.Utilitaires;

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
                vec = (from v in context.Client
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
                vec = (from v in context.Client
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
            Byte[] selmdp = MonMotPassHash.GenerateSalt();
            Byte[] mdpByte = MonMotPassHash.PasswordHashe(c.Paswd, selmdp);
            c.Paswd = MonMotPassHash.BytesToString(mdpByte);
            c.Salt = MonMotPassHash.BytesToString(selmdp);

            context.Client.Add(c);
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

        public bool CheckClient(String login, String pwd)
        {
            bool res = false;
            Client c = GetClient(login);
            // on récupère le sel 
            Byte[] salt = MonMotPassHash.transformeEnBytes(c.Salt);
            // on génère le mot de passe 
            Byte[] tempo = MonMotPassHash.transformeEnBytes(c.Paswd);

            if (MonMotPassHash.VerifyPassword(salt, pwd, tempo))
            {
                res = true;
            }

            return res;
        }

        public void RemoveClient(Client c)
        {

            context.Client.Remove(c);
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
