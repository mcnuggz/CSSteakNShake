﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    internal class Lettuce : Topping, INeedToBeCut
    {
        public bool foodCut;
        public void cutFood()
        {
            foodCut = true;
        }
    }
}
