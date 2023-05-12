using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    static class Simulateur
    {
        private static Random rand = new Random();
        private static Concessionnaire monConcessionnaire = new Concessionnaire("JF's garage", 0);


        public static void Simuler()
        {
            Console.WriteLine("*******Information Facture*******\n\n");
            monConcessionnaire.RemplirInventaire();
            List<Client> listClients = GenererListClient();
            for (int i = 0; i < listClients.Count; i++)
            {
                int random1 = rand.Next(0, monConcessionnaire.Vehicules.Count());
                int random2 = rand.Next(0, monConcessionnaire.Vehicules.Count());
                do
                {
                    random2 = rand.Next(0, monConcessionnaire.Vehicules.Count());
                } while (random1 != random2);

                if (monConcessionnaire.Vehicules[random1].MoteurVehicule < monConcessionnaire.Vehicules[random2].MoteurVehicule)
                {
                    SimulerTransaction(listClients, monConcessionnaire.Vehicules[random2], i);
                }
                else
                {
                    SimulerTransaction(listClients, monConcessionnaire.Vehicules[random1], i);
                }
            }
            Console.WriteLine(monConcessionnaire);
        }

        public static List<Client> GenererListClient()
        {
            List<Client> clientList = new List<Client>();
            for (int i = 0; i < 3; i++)
            {
                clientList.Add(Factory.CreerClient());
            }
            return clientList;
        }

        public static void SimulerTransaction(List<Client> clients, VehiculeMotorise vehicule, int i)
        {
            try
            {
                if (clients[i].MontantArgent < vehicule.Prix)
                {
                    throw new Exception($"Le client {clients[i].Nom} n'a pas les moyen");
                }
                else
                {
                    monConcessionnaire.MontantArgent += vehicule.Prix;
                    monConcessionnaire.AjouterFacture(new Facture(clients[i], DateTime.Now, vehicule));
                    monConcessionnaire.VendreVehicule(vehicule);
                    monConcessionnaire.AfficherFacture();
                    
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
        public static bool InventaireVide()
        {
            bool valide = false;
            try
            {
                if (monConcessionnaire.Vehicules.Count > 2)
                {
                    valide = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


            return valide;
        }
    }
}
