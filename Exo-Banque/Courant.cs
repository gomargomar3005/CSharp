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

        public static double operator +(Courant left, Courant right)
        {
            double leftSolde = (left.Solde < 0)? 0 : left.Solde;
            double rightSolde = (right.Solde < 0)? 0 : right.Solde;
            return leftSolde + rightSolde;
        }

        public static double operator +(double left, Courant right)
        {
            left = Math.Max(0, left);
            double rightSolde = Math.Max(0, right.Solde);
            return left + rightSolde;
        }
    }
}
