using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autolib.Models.Domain;

namespace Autolib.Models.ViewModel
{
    

    public class ClientsModel
    {
        public Client clientActuel = null;
        public List<Reservation> resaClient = null;

        public ClientsModel(Client clientActuel, List<Reservation> resaClient)
        {
            this.clientActuel = clientActuel;
            this.resaClient = resaClient;
        }
    }
}
