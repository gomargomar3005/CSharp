using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_HeritageSimple
{
    internal class Rectangle : Forme
    {
        protected int _longueur;

        protected int _largeur;

        public int Longueur { 
            get { return _longueur; }
        }
        public int Largeur { 
            get { return _largeur; }
        }

        public virtual void Initialisation(int longueur, int largeur)
        {
            if (longueur > largeur)
            {
                _longueur = longueur;
                _largeur = largeur;
            }
            else
            {
                _largeur = longueur;
                _longueur = largeur;
            }
        }

        public virtual int Perimetre()
        {
            return (Longueur + Largeur) * 2;
        }
    }
}
