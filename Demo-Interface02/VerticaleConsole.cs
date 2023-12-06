using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface02
{
    internal class VerticaleConsole : IWriterConsole
    {
        public void Write(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[i];
                if (c == '\n')
                {
                    Console.SetCursorPosition(Console.CursorLeft+1, 0);
                }
                else
                {
                    Console.WriteLine(c);
                }
            }
        }

        public void WriteLine(string text)
        {
            Write(text);
            Console.SetCursorPosition(Console.CursorLeft + 1, 0);
        }
    }
}
