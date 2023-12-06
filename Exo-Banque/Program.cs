namespace Exo_Banque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            Personne p1 = new Personne();
            p1.Nom = "Legrain";
            p1.Prenom = "Samuel";
            p1.DateNaiss = new DateTime(1987, 9, 27);

            Courant compte1 = new Courant();
            compte1.Numero = "BE55 1234 1234 1234";
            compte1.LigneDeCredit = 100;
            compte1.Titulaire = p1;

            compte1.Retrait(50);
            Console.WriteLine($"Sur le compte {compte1.Numero}, le solde est de : {compte1.Solde} €");

            Courant compte2 = new Courant();
            compte2.Numero = "BE54 1234 1234 1234";
            compte2.LigneDeCredit = 200;
            compte2.Titulaire = p1;

            compte2.Depot(50_000);
            Console.WriteLine($"Sur le compte {compte2.Numero}, le solde est de : {compte2.Solde} €");

            Banque banque1 = new Banque();
            banque1.Nom = "LeBonIntérêt!";
            banque1.Ajouter(compte1);
            banque1.Ajouter(compte2);

            //Personne user = new Personne() { Nom = "Legrain", Prenom = "Samuel", DateNaiss = new DateTime(1987,9,27)};

            Console.WriteLine($"Le titulaire {p1.Nom} {p1.Prenom} à comme avoirs : {banque1.AvoirDesComptes(p1)} €");

            Epargne compte3 = new Epargne();
            compte3.Titulaire = p1;
            compte3.Numero = "BE75 1234 1234 1234";
            compte3.Depot(10_000);
            Console.WriteLine($"Sur le compte {compte3.Numero}, le solde est de : {compte3.Solde} €");
            compte3.Retrait(500);
            Console.WriteLine($"Sur le compte {compte3.Numero}, le solde est de : {compte3.Solde} €.\nLe dernier retrait a été effectué le {compte3.DateDernierRetrait}");

            banque1.Ajouter(compte3);

            Compte compteExemple = banque1["BE55 1234 1234 1234"];

            Console.WriteLine($"Le titulaire {compteExemple.Titulaire.Nom} {compteExemple.Titulaire.Prenom} à comme avoirs : {banque1.AvoirDesComptes(compteExemple.Titulaire)} €");

            compte1.AppliquerInteret();
            Console.WriteLine($"Sur le compte {compte1.Numero}, le solde est de : {compte1.Solde} €");
            compte2.AppliquerInteret();
            Console.WriteLine($"Sur le compte {compte2.Numero}, le solde est de : {compte2.Solde} €");
            compte3.AppliquerInteret();
            Console.WriteLine($"Sur le compte {compte3.Numero}, le solde est de : {compte3.Solde} €");
        }
    }
}