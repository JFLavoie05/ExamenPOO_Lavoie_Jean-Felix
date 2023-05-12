using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinal
{
    class Client
    {
        public string Nom { get; set; }
        public int MontantArgent { get; set; }


        public Client(string nom, int montantArgent)
        {
            Nom = nom;
            MontantArgent = montantArgent;
        }
    }
}
