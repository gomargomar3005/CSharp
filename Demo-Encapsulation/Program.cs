using Demo_Encapsulation.Structs;

namespace Demo_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login monLogin = new Login();

            do
            {
                Console.Clear();
                Console.WriteLine("Veuillez votre e-mail :");
                monLogin.Email = Console.ReadLine();
                Console.WriteLine("Veuillez entrer votre mot de passe :");
                monLogin.Password = Console.ReadLine();
            }
            while (!monLogin.SeConnecter()) ;

            Console.WriteLine("Bienvenu!");
            //Console.WriteLine(monLogin.Password);
        }
    }
}