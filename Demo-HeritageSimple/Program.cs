namespace Demo_HeritageSimple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Forme f = new Forme();
            f.Couleur = "Jaune";

            Rectangle r = new Rectangle();
            r.Couleur = "Rouge";
            r.Initialisation(5, 3);

            Console.WriteLine($"Le rectangle est de longueur : {r.Longueur} et de largeur : {r.Largeur}");

            Carre c = new Carre();
            c.Couleur = "Vert";
            c.Initialisation(5);
            c.Initialisation(8, 3);

            Console.WriteLine($"Le carré a des côtés de mesure : {c.Cote}");
        }
    }
}