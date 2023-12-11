namespace Demo_IDisposable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Formation WAD23 = new Formation("WAD23",
                "Hanane",
                "Emanuela",
                "Elena",
                "Najoua",
                "Laurence",
                "Dorine",
                "Hélène",
                "Yusrâ",
                "Hsin-I"
                ))
            {
                WAD23.Listing();
            }
        }
    }
}
