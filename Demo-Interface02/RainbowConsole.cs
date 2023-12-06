using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface02
{
    internal class RainbowConsole : IWriterConsole
    {
        public void Write(string text)
        {
            int maxColor = Enum.GetValues<ConsoleColor>().Length;

            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                Console.BackgroundColor = (ConsoleColor) (i % maxColor);
                Console.ForegroundColor = (ConsoleColor) (maxColor-1 - (i % maxColor));
                Console.Write(c);
            }
            Console.ResetColor();
        }

        public void WriteLine(string text)
        {
            Write(text);
            Console.WriteLine();
        }
    }
}
