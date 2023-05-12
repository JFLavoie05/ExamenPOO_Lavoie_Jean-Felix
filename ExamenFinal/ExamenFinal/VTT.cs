using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class VTT : VehiculeMotorise
    {
        public Roue RoueVTT { get; set; }

        public VTT(Roue roue, string nom, string marque, int prix, Moteur moteurVehicule) : base(nom, marque, prix, moteurVehicule)
        {
            RoueVTT = roue;
            Nom = nom;
            Marque = marque;
            Prix = prix;
            MoteurVehicule = moteurVehicule;
        }

        public VTT(string nom, string marque, int prix, Moteur moteurVehicule) : base(nom, marque, prix, moteurVehicule)
        {
            RoueVTT.MarqueRoue = "Volvo";
            RoueVTT.GrandeurRoue = 40;
            Nom = nom;
            Marque = marque;
            Prix = prix;
            MoteurVehicule = moteurVehicule;
        }

        public override string ToString()
        {
            string info = $" Le véhicule est un VTT\n Marque de roue :{RoueVTT.MarqueRoue}\n Grandeur de roue :{RoueVTT.GrandeurRoue}\n" +
                          $" Nom : {Nom} / Prix : {Prix}\n Information sur le moteur\n Marque : {MoteurVehicule.Marque} / HP : {MoteurVehicule.Force} / Refroidissement : {MoteurVehicule.TypeRefroidissement}";

            return info;
        }
    }
}
