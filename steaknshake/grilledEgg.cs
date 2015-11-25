using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    internal class GrilledEgg : Topping, INeedToBeGrilled
    {
        public bool grilledFood;
        public void grillFood()
        {
            grilledFood = true;
        }
    }
}
