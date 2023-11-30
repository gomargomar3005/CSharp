namespace Demo_Indexeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paquet paquet = new Paquet();
            paquet.ResetDeck();

            Console.WriteLine("Quelle couleur voulez-vous choisir ?");
            foreach (string c in Enum.GetNames<CouleurCarte>())
            {
                Console.WriteLine(c);
            }
            CouleurCarte couleur = Enum.Parse<CouleurCarte>(Console.ReadLine());


            Console.WriteLine("Quelle valeur voulez-vous choisir ?");
            foreach (string v in Enum.GetNames<ValeurCarte>())
            {
                Console.WriteLine(v);
            }
            ValeurCarte valeur = Enum.Parse<ValeurCarte>(Console.ReadLine());

            Carte c1 = paquet[couleur, valeur];

            //ATTENTION : _paquet est la vraie liste de carte, qui est privée, donc on ne peut modifier la liste.
            //MAIS : Grâce à l'indexeur, je peux récupérer une carte du paquet, qui elle est public, donc modifiable...

            //paquet._paquet.Add(new Carte() { Couleur = CouleurCarte.Trefle, Valeur = ValeurCarte.Trois });

            c1.Couleur = CouleurCarte.Trefle;

            Carte nouvelleCarte = new Carte() { Couleur = CouleurCarte.Trefle, Valeur = ValeurCarte.Trois};
            paquet[0] = nouvelleCarte;
        }
    }
}