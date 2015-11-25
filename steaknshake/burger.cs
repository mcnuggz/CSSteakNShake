using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    public class burger : IngredientList, ICook
    {
        public bool cookedMeat;
        public string name;
        public int amtofBuns;
        public int amtofPatties;

        public void addHeat()
        {
            cookedMeat = true;
        }
        public burger(string burgerName, int bunCount, int pattyCount)
        {
            name = burgerName;
            amtofBuns = bunCount;
            amtofPatties = pattyCount;
        }
    public static void Main()
    {

            burger deluxeBurger = new burger("Mondo Burger", 2, 2);
            Console.WriteLine(deluxeBurger.name + " has " + deluxeBurger.amtofBuns + " buns and " + deluxeBurger.amtofPatties + " patties!");
            Console.Read();

    }


    }
}
