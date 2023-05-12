using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Motomarine : VehiculeMotorise
    {
        public string Type { get; set; }


        public Motomarine(string type, string nom, string marque, int prix, Moteur moteurVehicule) : base(nom, marque, prix, moteurVehicule)
        {
            Type = type;
            Nom = nom;
            Marque = marque;
            Prix = prix;
            MoteurVehicule = moteurVehicule;
        }

        public Motomarine(string nom, string marque, int prix, Moteur moteurVehicule) : base(nom, marque, prix, moteurVehicule)
        {
            Type = "SeaDoo";
            Nom = nom;
            Marque = marque;
            Prix = prix;
            MoteurVehicule = moteurVehicule;
        }

        public override string ToString()
        {
            string info = $" Le véhicule est une Motomarine\n Type :{Type}\n" +
                          $" Nom : {Nom} / Prix : {Prix}\n Information sur le moteur\n Marque : {MoteurVehicule.Marque} / HP : {MoteurVehicule.Force} / Refroidissement : {MoteurVehicule.TypeRefroidissement}";

            return info;
        }
    }
}
