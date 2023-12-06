using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface02
{
    internal interface IWriterConsole
    {
        void Write(string text);
        void WriteLine(string text);
    }
}
