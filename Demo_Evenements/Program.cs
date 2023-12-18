namespace Demo_Evenements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal tamagotchi;

            switch(new Random().Next(2))
            {
                case 0:
                    tamagotchi = new Chien();
                    break;
                case 1:
                    tamagotchi = new Chat();
                    break;
            }

            tamagotchi.AvoirFaim += NotifierFaim;
            tamagotchi.AvoirFaim += BeepFaim;


            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;
            tamagotchi.Faim--;
        }

        private static void NotifierFaim(object sender, EventArgs args)
        {
            Console.WriteLine($"{sender} a faim!");
        }

        private static void BeepFaim(object sender, EventArgs args)
        {
            Console.Beep(244,200);
        }
    }
}
