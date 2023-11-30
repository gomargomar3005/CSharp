namespace Demo_Operateurs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit f1 = new Fruit() { Nom = "Fraise"};
            Fruit f2 = new Fruit() { Nom = "Fraise"};
            Fruit f3 = new Fruit() { Nom = "Pomme"};
            Fruit f4 = new Fruit() { Nom = "Pomme" };
            Fruit f5 = new Fruit() { Nom = "Pomme" };
            Fruit f6 = new Fruit() { Nom = "Orange" };

            Panier recolte1 = new Panier();
            recolte1.AddFruit(f1);
            recolte1.AddFruit(f2);

            Panier recolte2 = new Panier();
            recolte2.AddFruit(f3);
            recolte2.AddFruit(f4);
            recolte2.AddFruit(f5);

            Panier recolte3 = new Panier();
            recolte3.AddFruit(f6);

            Panier recolteFinal = recolte1 + recolte2 + recolte3;

            foreach (Fruit f in recolteFinal.Fruits)
            {
                Console.WriteLine(f.Nom);
            }
        }
    }
}