using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
    internal class VoitureAmphibie : Voiture, IVoiture, IBateau
    {
        public int Longueur { get; set; }

        public void Naviguer()
        {
            Console.WriteLine("Plouf! Plouf!");
        }

        public override void Rouler()
        {
            base.Rouler();
            Console.WriteLine("Mais je suis aussi amphibie!");
        }
    }
}
