using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeur
{
    internal class Etudiant : Personne
    {

        private List<int> _notes;
        public int[] Notes
        {
            get { return _notes.ToArray(); }
        }

        public double Moyenne
        {
            get
            {
                double result = 0;
                foreach (int note in _notes)
                {
                    result += note;
                }
                return result/_notes.Count;
            }
        }

        public Etudiant(string nom, string prenom) : base(nom, prenom)
        {
            _notes = new List<int>();
        }

        public Etudiant(string nom, string prenom, int[] notes) : base(nom, prenom)
        {
            _notes = new List<int>(notes);
        }

        //Un constructeur peut utiliser, tout comme les méthodes, des mots-clé à ses paramètres
        //public Etudiant(string nom, string prenom, params int[] notes) : this(notes)
        //{
        //    Nom = nom;
        //    Prenom = prenom;
        //}
    }
}
