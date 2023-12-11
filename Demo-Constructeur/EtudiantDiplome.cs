using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Constructeur
{
    internal class EtudiantDiplome : Etudiant
    {
        public DateOnly DateDiplome { get; set; }
        public string IntituleDiplome { get; set; }
        public EtudiantDiplome(
            string nom,
            string prenom, 
            DateOnly dateDiplome, 
            string intituleDiplome
            ) : base(nom, prenom)
        {
            DateDiplome = dateDiplome;
            IntituleDiplome = intituleDiplome;
        }

        public EtudiantDiplome(
            string nom,
            string prenom,
            int[] notes,
            DateOnly dateDiplome,
            string intituleDiplome
            ) : base(nom, prenom, notes)
        {
            DateDiplome = dateDiplome;
            IntituleDiplome = intituleDiplome;
        }
    }
}
