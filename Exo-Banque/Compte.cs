using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque
{
    internal abstract class Compte : IBanker //,ICustomer //Pas exclus de mettre les deux interfaces
    {

        public string Numero { get; private set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; private set; }

        public Compte(string numero, Personne titulaire)
        {
            Numero = numero;
            Titulaire = titulaire;
        }

        public Compte(string numero, Personne titulaire, double solde) : this(numero, titulaire)
        {
            Solde = solde;
        }

        
        public void Depot(double montant)
        {
            if (montant <= 0) return;
            Solde += montant;
        }

        public virtual void Retrait(double montant)
        {
            Retrait(montant, 0);
        }

        protected void Retrait(double montant, double limite)
        {
            if (montant <= 0) return; //Exception
            if (montant > Solde + limite) return; //Exception
            Solde -= montant;
        }
        protected abstract double CalculInteret();

        public void AppliquerInteret()
        {
            Solde += CalculInteret();
        }

        public static double operator +(Compte left, Compte right)
        {
            double leftSolde = (left.Solde < 0) ? 0 : left.Solde;
            double rightSolde = (right.Solde < 0) ? 0 : right.Solde;
            return leftSolde + rightSolde;
        }

        public static double operator +(double left, Compte right)
        {
            left = Math.Max(0, left);
            double rightSolde = Math.Max(0, right.Solde);
            return left + rightSolde;
        }
    }
}
