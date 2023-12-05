using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque
{
    internal class Compte
    {
        public string Numero { get; set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; }

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
    }
}
