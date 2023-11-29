using Demo_Namespace.Enums;
using Demo_Namespace.Structs;

namespace Demo_Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carte asDeCoeur = new Carte();
            asDeCoeur.couleur = CouleurCarte.Coeur;
            asDeCoeur.valeur = ValeurCarte.AS;
        }
    }
}