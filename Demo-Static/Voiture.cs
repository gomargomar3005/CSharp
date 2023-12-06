using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Static
{
    internal class Voiture
    {
        public string Couleur { get; set; }
        public string Modele { get; set; }
        public int NbPlace { get; set; }
        public static int NbRoues { get; set; }
    }
}
