using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque
{
    internal class Epargne : Compte
    {
        #region Champs

        #endregion

        #region Propriétés
        public DateTime? DateDernierRetrait { get; set; }   //Modification par rapport à l'énoncé, plus judicieux d'avoir un null au début
        #endregion

        #region Méthodes
        public override void Retrait(double montant)
        {
            base.Retrait(montant);
            DateDernierRetrait = DateTime.Now;
        }

        protected override double CalculInteret()
        {
            return Solde * 0.045;
        }
        #endregion
    }
}
