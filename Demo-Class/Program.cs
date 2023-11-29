namespace Demo_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture maFerrari = new Voiture();  //Création d'une instance grâce au mot-clé 'new'
                                                //Affectation à une variable : maFerrari fait un lien avec l'instance.
            maFerrari.plaque = "2-ABC-123";     //Affectation de valeur à une variable membre/champs/attributs de maFerrari
            maFerrari.couleur = "Rouge";
            maFerrari.modele = "Twingo";
            maFerrari.nbRoues = 4;

            Voiture collegueVoiture = new Voiture() //Nouvelle instance, rien à voir avec maFerrari, nouvel élément en mémoire
            {
                plaque = "2-XYZ-123",
                couleur = "Orange",
                modele = "Lamborgini",
                nbRoues = 4
            };

            Voiture laFraise = maFerrari;   //Nouveau lien entre l'instance de maFerrari avec la variable laFraise

            Console.WriteLine($"Je roule tranquille avec 'ma ferrari' sur le R0, avec ses {maFerrari.nbRoues} roues.");
            Console.WriteLine($"Paf! Bardaf! C'est l'embardée! Crash de 'ma ferrari', elle perd une roue...");
            maFerrari.nbRoues--;
            Console.WriteLine($"Je n'ai plus que {maFerrari.nbRoues} roues sur 'ma ferrari'...");
            Console.WriteLine($"COMMENT CA! TU AS CASSÉ LA FRAISE! ELLE N'A PLUS QUE {laFraise.nbRoues} ROUES!");
        }
    }
}