using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
    internal interface IBateau
    {
        public int Longueur { get; set; }

        public string Motorisation { get; set; }
        public void Naviguer();
    }
}
