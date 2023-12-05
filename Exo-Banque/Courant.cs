using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque
{
    internal class Courant
    {
        private double _ligneDeCredit;
        public string Numero { get; set; }
        public double Solde { get; private set; }


        public double LigneDeCredit
        {
            get { 
                return _ligneDeCredit;
            }
            set {
                _ligneDeCredit = (value >= 0) ? value : _ligneDeCredit;
            }
        }

        public Personne Titulaire { get; set; }

        public void Retrait(double montant)
        {
            if (montant <= 0) return;
            if (montant > Solde + LigneDeCredit) return;
            Solde -= montant;
        }

        public void Depot(double montant)
        {
            if(montant <= 0) return;
            Solde += montant;
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
