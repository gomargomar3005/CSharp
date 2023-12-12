namespace Demo_Delegues_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<double> mesNombres = new List<double>() { 3, 1 , 5 , 4, 8, 9.6, 52, 11};

            //mesNombres = ListToolBox.FiltreImpair(mesNombres);

            CheckFunction predicate = delegate (double val)
            {
                return val % 3 == 0;
            };

            mesNombres = ListToolBox.Filtre(mesNombres, ListToolBox.PredicatePlusPetitQueDix);
            mesNombres = ListToolBox.Filtre(mesNombres, PredicateEgaleZero);
            mesNombres = ListToolBox.Filtre(mesNombres, predicate);

            mesNombres = ListToolBox.Filtre(mesNombres, delegate (double nb) { return nb == Math.PI; });
        }

        static bool PredicateEgaleZero (double valeur)
        {
            return valeur == 0;
        }
    }
}
