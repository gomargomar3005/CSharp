using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque
{
    internal class Personne
    {
        /* Equivalant à l'auto-propriété
        private string _nom;

        public string Nom { 
            get { return _nom; } 
            set { _nom = value; } 
        }
        */
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public DateTime DateNaiss { get; set; }
    }
}
