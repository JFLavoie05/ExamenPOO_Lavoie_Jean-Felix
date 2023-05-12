using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Moteur
    {
        public string Marque { get; set; }
        public int Force { get; set; }
        public string TypeRefroidissement { get; set; }

        public Moteur()
        {
            Marque = "Yamaha";
            Force = 50;
            TypeRefroidissement = "Air";
        }

        public static bool operator >(Moteur moteur1, Moteur moteur2)
        {
            return moteur1.Force > moteur2.Force;
        }
        public static bool operator <(Moteur moteur1, Moteur moteur2)
        {
            return moteur1.Force < moteur2.Force;
        }
    }
}
