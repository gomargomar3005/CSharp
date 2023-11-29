using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_ProprieteAutoCalcule
{
    internal class Personne
    {
        public DateTime DateNaissance {  get; set; }

        public int Age {
            get
            {

                int delta =  (DateTime.Now.Year - DateNaissance.Year);
                return (DateNaissance.Date > DateTime.Now.AddYears(-delta))? delta-1 : delta ;
            }
        }
    }
}
