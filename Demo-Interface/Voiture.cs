using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
    internal class Voiture : IVoiture
    {
        public string Plaque { get; set; }
        public string Couleur { get; set; }
        public int NbPlace { get; set; }
        public int NbRoues { get; set; }
        public string Motorisation { get; set; }

        public virtual void Rouler()
        {
            Console.WriteLine("Vroum!Vroum! Je suis une voiture!");
        }
    }
}
