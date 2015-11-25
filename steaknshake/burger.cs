using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    public class burger : IBurger
    {
        public bool hasBuns;
        public int bunAmt;
        public void haveBuns()
        {
            hasBuns = true;
            bunAmt = 1;
        }
        public bool hasPatty;
        public int pattyAmt;
        public void havePatties()
        {
            hasBuns = true;
            pattyAmt = 2;
        }
    }
}
