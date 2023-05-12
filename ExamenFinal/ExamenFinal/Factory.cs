using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    static class Factory
    {

        public static Client CreerClient()
        {
            Random rnd = new Random();
            string[] noms = {"Bertrand", "Girard", "Patrice", "Vicent", "Rebeka", "Nicholas", "Idrisse", "Olivier", "Lucas", "JeanFélix", "Mbappé" };
            Client nouveauClient = new Client(noms[rnd.Next(0, noms.Length)], rnd.Next(5000, 50000));

            return nouveauClient;
        }
    }
}
