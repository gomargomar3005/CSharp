using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Interface
{
    internal interface IVoiture
    {
        public string Plaque { get; set; }
        public int NbRoues { get; set; }
        public string Motorisation { get; set; }

        public void Rouler();
    }
}
