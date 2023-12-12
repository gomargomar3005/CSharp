namespace Demo_Delegues_01
{
    delegate double MathFunction(double x, double y);
    internal class Program
    {
        static void Main(string[] args)
        {
            MathFunction functions = MathTools.Addition;
            functions += MathTools.Multiplication;

            /*if (functions != null)
                Console.WriteLine( functions(5,2));*/


            /* //Même si nous passons une variable en paramètre, celle-ci ne change de valeur qu'en fin d'invocation du délégué, et est une copie pas un élément référenciel
            double result = 5;

            if(functions != null)
            {
                result = functions(result, 2);
            }
            
            Console.WriteLine(result);
            */

            Console.WriteLine(functions?.Invoke(5,2));
        }
    }
}
