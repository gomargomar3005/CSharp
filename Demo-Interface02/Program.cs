namespace Demo_Interface02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWriterConsole writer = new RainbowConsole();
            //IWriterConsole writer = new ReverseConsole();
            //IWriterConsole writer = new VerticaleConsole();

            writer.Write("Hello");
            writer.WriteLine(", world!");
        }
    }
}