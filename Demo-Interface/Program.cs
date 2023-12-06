namespace Demo_Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VoitureAmphibie v1 = new VoitureAmphibie();
            v1.Plaque = "1-ABC-123";
            v1.Couleur = "Bleue";
            v1.NbPlace = 4;
            v1.NbRoues = 5;
            v1.Motorisation = "Électrique";
            v1.Longueur = 10;

            List<IVoiture> voitures = new List<IVoiture> { v1, new Voiture(), new VoitureUtilitaire() };
            List<IBateau> embarquations = new List<IBateau> { v1, new Bateau() };

            foreach (IVoiture v in voitures)
            {
                v.Rouler();
            }

            foreach (IBateau b in embarquations)
            {
                b.Naviguer();
            }
        }
    }
}