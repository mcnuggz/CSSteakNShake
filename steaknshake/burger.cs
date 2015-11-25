using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    public class Burger : IngredientList
    {

        public Burger(string burgerName, int bunCount, int pattyCount)
        {
            name = burgerName;
            amtofBuns = bunCount;
            amtofPatties = pattyCount;
        }
    public static void Main()
    {

            Burger deluxeBurger = new Burger("Mondo Burger", 1, 2);
            Console.WriteLine(deluxeBurger.name + " has " + deluxeBurger.amtofBuns + " buns and " + deluxeBurger.amtofPatties + " patties!");

    }


    }
}
