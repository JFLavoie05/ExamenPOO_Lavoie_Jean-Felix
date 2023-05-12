using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Roue roue = new Roue("Volvo", 10);
            Moteur moteur = new Moteur();
            VTT vtt = new VTT(roue, "CruzControl", "DELL", 10000, moteur);
            Motomarine motomarine = new Motomarine("BELLA", "Toyota", 5000, moteur);

            Simulateur.Simuler();
        }
    }
}
