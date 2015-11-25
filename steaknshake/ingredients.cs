using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    public class IngredientList
    {
        public class Topping
        {
            public string Name { get; set; }

        }
        Topping topping1 = new Topping() { Name = "Bun" };
        Topping topping2 = new Topping() { Name = "Patty" };
        Topping topping3 = new Topping() { Name = "Cheese" };
        Topping topping4 = new Topping() { Name = "Tomato" };
        Topping topping5 = new Topping() { Name = "Onion" };
        Topping topping6 = new Topping() { Name = "Lettuce" };
        Topping topping7 = new Topping() { Name = "Pickles" };
        Topping topping8 = new Topping() { Name = "Mayonaise" };
        Topping topping9 = new Topping() { Name = "Ketchup" };
        Topping topping10 = new Topping() { Name = "Mustard" };
        Topping topping11 = new Topping() { Name = "Frisco Sauce" };
        Topping topping12 = new Topping() { Name = "Bacon" };
        Topping topping13 = new Topping() { Name = "Guacamole" };
        Topping topping14 = new Topping() { Name = "Grilled Egg" };
        Topping topping15 = new Topping() { Name = "Onion Rings" };
        Topping topping16 = new Topping() { Name = "Fried Onion" };

       public List<string> ToppingsList()
        {
            List<string> toppingList = new List<string>
            { "Bun", "Patty", "Cheese", "Tomato", "Onion", "Lettuce", "Pickles", "Mayonaise", "Ketchup",
              "Mustard", "Frisco Sauce", "Bacon", "Guacamole", "Grilled Eggs", "Onion Rings", "Fried Onion" };

            return toppingList;
        }
    }
}
