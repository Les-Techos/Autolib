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
            if(ServiceClient.instance == null)
            {
                ServiceClient.instance = new ServiceClient();
                ServiceClient.context = new autolibContext();
            }

            return ServiceClient.instance;
        }

        public Client GetClient(String id)
        {
            Client vec = null;

            try
            {
                vec = (from v in context.Client
                              where v.Login == id
                              select v).FirstOrDefault();
                return vec;
            }catch(Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
