using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeur
{
    internal class Etudiant
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }

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

        private Etudiant() 
        { 
            _notes = new List<int>();
        }
        private Etudiant(int[] notes)
        {
            _notes = new List<int>(notes);
        }

        public Etudiant(string nom, string prenom) : this() 
        {
            Nom = nom;
            Prenom = prenom;
        }

        public Etudiant(string nom, string prenom, int[] notes) : this(notes)
        {
            Nom = nom;
            Prenom = prenom;
        }
        //Un constructeur peut utiliser, tout comme les méthodes, des mots-clé à ses paramètres
        //public Etudiant(string nom, string prenom, params int[] notes) : this(notes)
        //{
        //    Nom = nom;
        //    Prenom = prenom;
        //}
    }
}
