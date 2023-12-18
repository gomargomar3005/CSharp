namespace Exo02_Event
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Login u1 = new Login("u1@email.com", "password");

            u1.LoginOkEvent += LoginOk;
            u1.LoginNotOkEvent += delegate (object sender, EventArgs e)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Identifiants Inorrects.");
                Console.ResetColor();

            };


            u1.CheckLogin("blabla@email.com", "Test1234=");
            u1.CheckLogin("u1@email.com", "password");
        }

        static void LoginOk(object sender, EventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Identifiants Corrects.");
            Console.ResetColor();
        }
    }
}
