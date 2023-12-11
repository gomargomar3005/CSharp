namespace Demo_Constructeur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Etudiant e1 = new Etudiant("Morre","Thierry");
            //Etudiant e2 = new Etudiant("Legrain","Samuel", 12, 11, 0, 3, 5 ); //Avec l'utilisation du mot-clé params
            Etudiant e2 = new Etudiant("Legrain","Samuel", new int[] { 12, 11, 0, 3, 5 } );
            e2.Notes[2]=100;
            Console.WriteLine($"La moyenne de {e2.Nom} {e2.Prenom} est de {e2.Moyenne}.");
        }
    }
}
