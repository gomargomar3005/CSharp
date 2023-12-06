namespace Demo_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(Math.PI);
            //Console.WriteLine(Math.Pow(2,2));

            //Voiture v1 = new Voiture();
            //v1.Couleur = "Rouge";
            //v1.Modele = "Twingo";
            //v1.NbPlace = 4;
            //Voiture.NbRoues = 4;

            //Voiture v2 = new Voiture();
            //v2.Couleur = "Orange";
            //v2.Modele = "Lamborgini";
            //v2.NbPlace = 2;
            //Voiture.NbRoues = 5;

            //Console.WriteLine($"Ma voiture est une {v1.Modele} {v1.Couleur} avec {v1.NbPlace} place(s), qui a {Voiture.NbRoues} roue(s).");
            //Console.WriteLine($"Ma voiture est une {v2.Modele} {v2.Couleur} avec {v2.NbPlace} place(s), qui a {Voiture.NbRoues} roue(s).");

            //Eleve e1 = new Eleve() { Nom = "Cardu", Prenom = "Emanuela"};
            //Eleve e2 = new Eleve() { Nom = "Tsai", Prenom = "Hsin-I"};
            //Eleve e3 = new Eleve() { Nom = "Delforge", Prenom = "Laurence"};
            Eleve.EstEnPause = true;

            Eleve.SonnerLaPause();
        }
    }
}