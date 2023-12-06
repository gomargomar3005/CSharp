using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque
{
    internal class Courant : Compte
    {
        private double _ligneDeCredit;

        public double LigneDeCredit
        {
            get { 
                return _ligneDeCredit;
            }
            set {
                _ligneDeCredit = (value >= 0) ? value : _ligneDeCredit;
            }
        }


        public override void Retrait(double montant)
        {
            Retrait(montant, LigneDeCredit);
        }

        protected override double CalculInteret()
        {
            return (Solde > 0) ? Solde * 0.03 : Solde * 0.0975;
        }
    }
}
