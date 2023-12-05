using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_HeritageSimple
{
    internal class Carre : Rectangle
    {
        public int Cote { get { return _longueur; } }

        public void Initialisation(int cote)
        {
            _longueur = Math.Abs(cote);
            _largeur = Math.Abs(cote);
        }

        public override void Initialisation(int longueur, int largeur)
        {
            if (longueur != largeur) return; //Exception
            Initialisation(longueur);
        }

        public override int Perimetre()
        {
            return Cote * 4;
        }
    }
}
