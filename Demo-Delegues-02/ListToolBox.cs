using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegues_02
{
    delegate bool CheckFunction(double valeurAVerifier);
    internal static class ListToolBox
    {
        public static List<double> Filtre(List<double> liste, CheckFunction predicate)
        {
            if(predicate is null) throw new ArgumentNullException(nameof(predicate));
            List<double> result = new List<double>();
            foreach (double nb in liste)
            {
                if (predicate(nb)) result.Add(nb);
            }
            return result;
        }

        public static bool PredicatePair(double valeur)
        {
            return valeur %2 == 0;
        }
        public static bool PredicateImpair(double valeur)
        {
            return valeur % 2 != 0;
        }
        public static bool PredicatePlusGrandQueDix(double valeur)
        {
            return valeur > 10;
        }
        public static bool PredicatePlusPetitQueDix(double valeur)
        {
            return valeur < 10;
        }


        /*-----------A NE PLUS UTILISER!!!!-----------*/
        public static List<double> FiltrePair( List<double> liste)
        {
            List<double> result = new List<double>();
            foreach (double nb in liste)
            {
                if(nb%2 == 0) result.Add(nb);
            }
            return result;
        }

        public static List<double> FiltreImpair(List<double> liste)
        {
            List<double> result = new List<double>();
            foreach (double nb in liste)
            {
                if (nb % 2 != 0) result.Add(nb);
            }
            return result;
        }

        public static List<double> FiltrePlusPetitQueDix(List<double> liste)
        {
            List<double> result = new List<double>();
            foreach (double nb in liste)
            {
                if (nb < 10) result.Add(nb);
            }
            return result;
        }
    }
}
