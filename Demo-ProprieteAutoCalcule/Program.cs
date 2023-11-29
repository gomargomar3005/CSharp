namespace Demo_ProprieteAutoCalcule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Personne user = new Personne();
            user.DateNaissance = new DateTime(1987,9,27);
            Console.WriteLine($"Vous avez {user.Age} ans...");
        }
    }
}