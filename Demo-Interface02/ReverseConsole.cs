using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface02
{
    internal class ReverseConsole : IWriterConsole
    {
        public void Write(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                char c = text[text.Length-1 - i];
                Console.Write(c);
            }
        }

        public void WriteLine(string text)
        {
            Write(text);
            Console.WriteLine();
        }
    }
}
