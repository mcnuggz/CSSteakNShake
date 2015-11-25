using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    internal class patty : ICook
    {
        public bool cookedMeat;
        public void addHeat()
        {
            cookedMeat = true;
        }
    }
}
