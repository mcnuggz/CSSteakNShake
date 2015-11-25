using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
   public class IngredientList
    {
        public static void Toppings()
        {
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

        List<Topping> toppingList = new List<Topping>();
        toppingList.Add(topping1);
        toppingList.Add(topping2);
        toppingList.Add(topping3);
        toppingList.Add(topping4);
        toppingList.Add(topping5);
        toppingList.Add(topping6);
        toppingList.Add(topping7);
        toppingList.Add(topping8);
        toppingList.Add(topping9);
        toppingList.Add(topping10);
        toppingList.Add(topping11);
        toppingList.Add(topping12);
        toppingList.Add(topping13);
        toppingList.Add(topping14);
        toppingList.Add(topping15);
        toppingList.Add(topping16);
        }

        public class Topping {
            public string Name { get; set; }
        }
        
    }
}
