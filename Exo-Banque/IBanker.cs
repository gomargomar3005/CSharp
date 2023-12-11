using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_Banque
{
    internal interface IBanker : ICustomer
    {
        string Numero { get; }
        Personne Titulaire {  get; }
        void AppliquerInteret();
    }
}
