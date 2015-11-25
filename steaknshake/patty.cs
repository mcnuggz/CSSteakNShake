using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    internal class Patty : Topping, INeedToBeCooked
    {
        public bool cookedFood;
        public void cookFood()
        {
            cookedFood = true;
        }
    }
}
