using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Autolib.Models.ViewModel
{
    
    

    public class ReservationEtape23Model
    {
        public int numVehc;
        public String typeVehc;
        public DateTime debut;
        public DateTime fin;
        public int etatRes;

        public ReservationEtape23Model(int numVehc, String typeVehc, DateTime debut=new DateTime(), DateTime fin=new DateTime(), int etatRes = -1)
        {
            this.numVehc = numVehc;
            this.typeVehc = typeVehc;
            this.debut = debut;
            this.fin = fin;
            this.etatRes = etatRes;
        }
    }
}
