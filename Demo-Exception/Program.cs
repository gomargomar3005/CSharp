namespace Demo_Exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nb;
            double result;
            bool noError = false;
            do
            {
                try
                {
                    nb = int.Parse(Console.ReadLine()); //FormatException

                    result = 5 / nb; //DivideByZeroException

                    Console.WriteLine(result);
                    noError = true;
                }
                catch (DivideByZeroException ex)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("Une division par 0 tend vers l'infini...");
                    Console.ResetColor();
                }
                catch(FormatException ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"Le format doit être numérique : {ex.Message }");
                    Console.ResetColor();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Fin de la boucle...");
                Console.ReadLine();
                Console.Clear();
            } while (!noError);
            
        }
    }
}
