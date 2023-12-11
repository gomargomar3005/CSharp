using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_IDisposable
{
    internal class Formation : IDisposable
    {
        public string Nom { get; private set; }
        private List<string> _eleves;

        public Formation(string nom,params string[]eleves)
        {
            Nom = nom;
            _eleves = new List<string>(eleves);
        }

        public void Listing()
        {
            foreach (string name in _eleves)
            {
                Console.WriteLine(name);
            }
        }

        public override string ToString()
        {
            return $"La classe des {this.Nom} est composé de {_eleves.Count} élève{((_eleves.Count > 1) ? "s" : "")}";
        }

        public void Dispose()
        {
            Console.WriteLine(this);
        }

        //Destructeur : Aux oubliettes! On préfère l'interface IDisposable
        ~Formation()
        {
            Console.WriteLine(this);
        }
    }
}
