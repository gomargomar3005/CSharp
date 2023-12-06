using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Static
{
    internal class Eleve
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public static bool EstEnPause { get; set; }

        public static void SonnerLaPause()
        {
            if(Eleve.EstEnPause)
            {
                //Console.WriteLine($"La pause commence {Nom} {Prenom}!"); //Impossible d'utiliser les variables d'instances...
                Console.WriteLine($"La pause commence!");
            }
            else
            {
                Console.WriteLine("La pause est finie...");
            }
        }
    }
}
