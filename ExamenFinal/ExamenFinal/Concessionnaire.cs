using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Concessionnaire
    {
        public string Nom { get; set; }
        public double MontantArgent { get; set; }
        public List<Facture> Factures;
        public List<VehiculeMotorise> Vehicules;

        public Concessionnaire(string nom, double montantArgent)
        {
            Nom = nom;
            MontantArgent = montantArgent;
            Vehicules = new List<VehiculeMotorise>();
            Factures = new List<Facture>();
        }

        public void AjouterFacture(Facture facture)
        {
            Factures.Add(facture);
        }

        public void AjouterVehicule(VehiculeMotorise vehicule)
        {
            Vehicules.Add(vehicule);
        }

        public void VendreVehicule(VehiculeMotorise vehicule)
        {
            Vehicules.Remove(vehicule);
        }

        public void RemplirInventaire()
        {
            //MOTOMARINE
            Vehicules.Add(new Motomarine("BELLA", "Toyota", 6000, new Moteur()));
            Vehicules.Add(new Motomarine("Boumba", "Hyundai", 7000, new Moteur()));
            Vehicules.Add(new Motomarine("FinancialMistake", "Saturne", 15000, new Moteur()));
            Vehicules.Add(new Motomarine("Yes", "Citroen", 2000, new Moteur()));
            Vehicules.Add(new Motomarine("No", "Mazda", 1000, new Moteur()));
            Vehicules.Add(new Motomarine("Messi", "Benz", 12000, new Moteur()));


            //VTT
            Roue roue = new Roue("Volvo", 10);
            Vehicules.Add( new VTT(roue, "CruzControl", "DELL", 10000, new Moteur()));
            Vehicules.Add(new VTT(roue, "Donda", "BMW", 65000, new Moteur()));
            Vehicules.Add(new VTT(roue, "Bouba", "Toyota", 43000, new Moteur()));
            Vehicules.Add(new VTT(roue, "Pablo", "Honda", 23000, new Moteur()));
            Vehicules.Add(new VTT(roue, "Karris", "Toyota", 53000, new Moteur()));
            Vehicules.Add(new VTT(roue, "Pogba", "Benz", 14000, new Moteur()));
        }

        public void AfficherFacture()
        {
            
            foreach (Facture item in Factures)
            {
                Console.WriteLine($"Nom Client : {item.Client.Nom}, date : {item.Date}, vehicule : {item.Vehicule}\n\n");
            }
        }

        public override string ToString()
        {
            string info = $" Le concessionnaire s'appel : {Nom} / Argent : {MontantArgent} $";

            return info;
        }
    }
}
