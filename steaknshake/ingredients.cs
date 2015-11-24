using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    public class IngredientList
    {
        public static void Main()
        {
            Ingredients ingredient1 = new Ingredients() { Name = "Buttered Bun", Quantity = 1 };
            Ingredients ingredient2 = new Ingredients() { Name = "Steak Patty", Quantity = 2 };
            Ingredients ingredient3 = new Ingredients() { Name = "Tomato", Quantity = 2 };
            Ingredients ingredient4 = new Ingredients() { Name = "Lettuce", Quantity = 2 };
            Ingredients ingredient5 = new Ingredients() { Name = "Onion", Quantity = 3 };
            Ingredients ingredient6 = new Ingredients() { Name = "Cheese", Quantity = 1 };
            Ingredients ingredient7 = new Ingredients() { Name = "Bacon", Quantity = 3 };
            Ingredients ingredient8 = new Ingredients() { Name = "Pickles", Quantity = 2 };
            Ingredients ingredient9 = new Ingredients() { Name = "Mayonaise", Quantity = 1 };
            Ingredients ingredient10 = new Ingredients() { Name = "Ketchup", Quantity = 1 };
            Ingredients ingredient11 = new Ingredients() { Name = "Mustard", Quantity = 1 };
            Ingredients ingredient12 = new Ingredients() { Name = "Frisco Sauce", Quantity = 1 };
            Ingredients ingredient13 = new Ingredients() { Name = "Guacamole", Quantity = 1 };
            Ingredients ingredient14 = new Ingredients() { Name = "Grilled Egg", Quantity = 1 };
            Ingredients ingredient15 = new Ingredients() { Name = "Fries", Quantity = 20 };
            Ingredients ingredient16 = new Ingredients() { Name = "Onion Rings", Quantity = 4 };
            Ingredients ingredient17 = new Ingredients() { Name = "Fried Onions", Quantity = 20 };

            List<Ingredients> listIngredents = new List<Ingredients> { ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15, ingredient16, ingredient17 };
        }
        public class Ingredients
        {
            public string Name { get; set; }
            public int Quantity { get; set; }
        }
    }
}
