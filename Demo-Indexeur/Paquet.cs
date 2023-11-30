using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Indexeur
{
    internal class Paquet
    {
        private List<Carte> _paquet;

        public Carte this[CouleurCarte couleur, ValeurCarte valeur]
        {
            get
            {
                foreach (Carte carte in _paquet)
                {
                    if (carte.Couleur == couleur && carte.Valeur == valeur) return carte;
                }
                return null;
            }
        }

        public Carte this[int index]
        {
            get
            {
                return _paquet[index];
            }

            set
            {
                _paquet[index] = value;
            }
        }

        public void ResetDeck()
        {
            _paquet = new List<Carte>();
            foreach (CouleurCarte couleur in Enum.GetValues<CouleurCarte>())
            {
                foreach (ValeurCarte valeur in Enum.GetValues<ValeurCarte>())
                {
                    Carte c = new Carte();
                    c.Couleur = couleur;
                    c.Valeur = valeur;
                    _paquet.Add(c);
                }
            }
        }
    }
}
