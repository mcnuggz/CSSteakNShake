using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    internal class Tomato : Topping, INeedToBeCut
    {
        public bool foodCut;
        public void cutFood()
        {
            foodCut = true;
        }
    }
}
