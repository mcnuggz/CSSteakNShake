using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace steaknshake
{
    public abstract class Burger : IBurger
    {
        int bunCount;
        int pattyCount;
        public void amtofBuns()
        {
            bunCount = 1;

        }
        public void amtofPatties()
        {
            pattyCount = 2;
        }
    }
}
