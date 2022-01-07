using System;
using System.Collections.Generic;

namespace Autolib.Models.Domain
{
    public partial class Client
    {
        public Client()
        {
            Reservation = new HashSet<Reservation>();
            Utilise = new HashSet<Utilise>();
        }

        public int IdClient { get; set; }
        public string Login { get; set; }
        public string Paswd { get; set; }
        public string Salt { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime? DateNaissance { get; set; }

        public virtual ICollection<Reservation> Reservation { get; set; }
        public virtual ICollection<Utilise> Utilise { get; set; }
    }
}
