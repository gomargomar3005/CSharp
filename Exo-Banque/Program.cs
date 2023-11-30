namespace Exo_Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Personne p1 = new Personne();
            p1.Nom = "Legrain";
            p1.Prenom = "Samuel";
            p1.DateNaiss = new DateTime(1987, 9, 27);

            Courant compte1 = new Courant();
            compte1.Numero = "BE55 1234 1234 1234";
            compte1.LigneDeCredit = 100;
            compte1.Titulaire = p1;

            Console.WriteLine($"Votre solde est de : {compte1.Solde} €");
            compte1.Retrait(50);
            Console.WriteLine($"Votre solde est de : {compte1.Solde} €");
            compte1.Depot(1_000_000);
            Console.WriteLine($"Votre solde est de : {compte1.Solde} €");
        }
    }
}