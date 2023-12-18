namespace Exo_Delegue01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carwash cw = new Carwash();
            Voiture v1 = new Voiture("1-ABC-123");
            Voiture v2 = new Voiture("1-DEF-456");
            Voiture v3 = new Voiture("1-HIJ-789");

            cw.Traiter(v1);
            cw.Traiter(v2);
            //cw.LavageAvecCire();
            cw.Traiter(v3);

        }
    }
}
