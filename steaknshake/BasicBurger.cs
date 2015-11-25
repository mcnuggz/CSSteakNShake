using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    public class BasicBurger 
    {
        public List<IngredientList> basicBurger;
        BasicBurger()
        {
            basicBurger = new List<IngredientList>();
            Patty patty = new Patty();
            Bun bun = new Bun();
            
            basicBurger.Add(bun);
            basicBurger.Add(patty);
        }
    }
}
