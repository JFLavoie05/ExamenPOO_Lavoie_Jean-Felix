using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class VehiculeMotorise
    {
        public string Nom { get; set; }
        public string Marque { get; set; }
        public int Prix { get; set; }
        public Moteur MoteurVehicule { get; set; }


        public VehiculeMotorise(string nom, string marque, int prix, Moteur moteurVehicule)
        {
            Nom = nom;
            Marque = marque;
            Prix = prix;
            MoteurVehicule = moteurVehicule;
        }
    }
}
