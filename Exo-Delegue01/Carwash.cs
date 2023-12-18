using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Delegue01
{
    internal delegate void Vehicule(Voiture v);
    internal class Carwash
    {
        private Vehicule _traitement;

        public Carwash()
        {
            _traitement = Preparer;
            _traitement += Laver;
            _traitement += Secher;
            _traitement += Finaliser;
        }
        private void Preparer(Voiture v)
        {
            Console.WriteLine($"je prepare la voiture : {v.Plaque}");
        }

        private void Laver(Voiture v) 
        {
            Console.WriteLine($"je lave la voiture : {v.Plaque}");
        }

        private void Secher(Voiture v)
        {
            Console.WriteLine($"je sèche la voiture : {v.Plaque}");
        }
        private void Finaliser(Voiture v)
        {
            Console.WriteLine($"je finalise la voiture : {v.Plaque}");
        }

        public void Traiter(Voiture v)
        {
            if (_traitement != null) _traitement(v);
        }
    }
}
