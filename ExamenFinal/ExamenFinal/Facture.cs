using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Facture
    {
        public Client Client { get; set; }
        public DateTime Date { get; set; }
        public VehiculeMotorise Vehicule { get; set; }

        public Facture(Client client, DateTime date, VehiculeMotorise vehicule)
        {
            Client = client;
            Date = date;
            Vehicule = vehicule;
        }
    }
}
