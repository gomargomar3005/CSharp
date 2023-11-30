using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Operateurs
{
    internal class Panier
    {
        private List<Fruit> _fruits = new List<Fruit>();            
        public Fruit[] Fruits
        {
            get { return _fruits.ToArray(); }
        }


        public void AddFruit(Fruit fruit)
        {
            _fruits.Add(fruit);
        }
        public void AddFruit(/*params*/ Fruit[] fruits)
        {
            foreach (Fruit f in fruits)
            {
                _fruits.Add(f);
            }
        }

        public static Panier operator +(Panier left, Panier right)
        {
            Panier result = new Panier();

            foreach (Fruit f in left._fruits)
            {
                result.AddFruit(f);
            }

            foreach (Fruit f in right._fruits)
            {
                result.AddFruit(f);
            }

            return result;
        }

        //public static int operator +(Panier left, Panier right)
        //{
        //    return left.Fruits.Length + right.Fruits.Length;
        //}
    }
}
