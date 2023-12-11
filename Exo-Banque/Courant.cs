using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque
{
    internal class Courant : Compte, IBanker
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
        public Courant(string numero, Personne titulaire) : base(numero, titulaire)
        {
        }

        public Courant(string numero, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {
        }
        public Courant(string numero, double ligneDeCredit, Personne titulaire) : base(numero, titulaire)
        {
            LigneDeCredit = ligneDeCredit;
        }
        public Courant(string numero, double ligneDeCredit, Personne titulaire, double solde) : base(numero, titulaire, solde)
        {
            LigneDeCredit = ligneDeCredit;
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
