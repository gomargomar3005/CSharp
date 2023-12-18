using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Evenements
{
    internal class Chat : Animal
    {
        public override int Faim
        {
            get { return base.Faim; }
            set
            {
                if (value < 0) value = 0;
                else if (value > 10) value = 10;
                _faim = value;
                if (_faim < 4)
                {
                    RaiseAvoirFaimEvent(this, EventArgs.Empty);
                }
            }
        }

        public Chat() : base()
        {
            Name = "Chat";
        }
    }
}
