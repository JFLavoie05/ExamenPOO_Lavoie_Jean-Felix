using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Roue
    {
        public string MarqueRoue { get; set; }
        public int GrandeurRoue { get; set; }
        

        public Roue(string marqueRoue, int grandeurRoue)
        {
            MarqueRoue = marqueRoue;
            GrandeurRoue = grandeurRoue;
        }
    }
}
