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

            //LavageClassique;
        }

        private void Cirer(Voiture v)
        {
            Console.WriteLine($"je cire la voiture : {v.Plaque}");
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

        //public LavageClassique()
        //{
        //    _traitement = Preparer;
        //    _traitement += Laver;
        //    _traitement += Secher;
        //    _traitement += Finaliser;
        //}

        //public LavageAvecCire()
        //{
        //    _traitement = Preparer;
        //    _traitement += Laver;
        //    _traitement += Cirer;
        //    _traitement += Secher;
        //    _traitement += Finaliser;
        //}

        public void Traiter(Voiture v)
        {
            if (_traitement != null) _traitement(v);
        }
    }
}
