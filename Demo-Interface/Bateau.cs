using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
    internal class Bateau : IBateau
    {
        public int Longueur { get; set; }
        public string Motorisation { get; set; }

        public void Naviguer()
        {
            Console.WriteLine("Plouf! Plouf!");
        }
    }
}
