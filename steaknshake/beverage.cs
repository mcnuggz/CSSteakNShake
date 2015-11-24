using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    public abstract class Beverage : IBeverage
    {
        bool inCup;
        int soda = 0;
        int water = 0;
        public void haveCup()
        {
            inCup = true;
        }
    }
}
