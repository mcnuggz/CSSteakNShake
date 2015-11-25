using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    internal class OnionRings : Topping, INeedToBeFried
    {
        public bool foodFried;
        public void fryfood()
        {
            foodFried = true;
        }
    }
}
