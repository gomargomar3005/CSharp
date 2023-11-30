using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Operateurs
{
    internal class Fruit
    {
        public string Nom { get; set; }

        public static bool operator ==(Fruit left, Fruit right)
        {
            return left.Nom == right.Nom;
        }

        public static bool operator !=(Fruit left, Fruit right)
        {
            return !(left == right);
        }
    }
}
