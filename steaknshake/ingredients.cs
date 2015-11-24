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
            Ingredients ingredient1 = new Ingredients() { Name = "Buttered Bun"};
            Ingredients ingredient2 = new Ingredients() { Name = "Steak Patty"};
            Ingredients ingredient3 = new Ingredients() { Name = "Tomato"};
            Ingredients ingredient4 = new Ingredients() { Name = "Lettuce"};
            Ingredients ingredient5 = new Ingredients() { Name = "Onion"};
            Ingredients ingredient6 = new Ingredients() { Name = "Cheese"};
            Ingredients ingredient7 = new Ingredients() { Name = "Bacon"};
            Ingredients ingredient8 = new Ingredients() { Name = "Pickles"};
            Ingredients ingredient9 = new Ingredients() { Name = "Mayonaise"};
            Ingredients ingredient10 = new Ingredients() { Name = "Ketchup"};
            Ingredients ingredient11 = new Ingredients() { Name = "Mustard"};
            Ingredients ingredient12 = new Ingredients() { Name = "Frisco Sauce"};
            Ingredients ingredient13 = new Ingredients() { Name = "Guacamole"};
            Ingredients ingredient14 = new Ingredients() { Name = "Grilled Egg"};
            Ingredients ingredient15 = new Ingredients() { Name = "Fries"};
            Ingredients ingredient16 = new Ingredients() { Name = "Onion Rings"};
            Ingredients ingredient17 = new Ingredients() { Name = "Fried Onions"};

            List<Ingredients> listIngredents = new List<Ingredients> { ingredient1, ingredient2, ingredient3, ingredient4, ingredient5, ingredient6, ingredient7, ingredient8, ingredient9, ingredient10, ingredient11, ingredient12, ingredient13, ingredient14, ingredient15, ingredient16, ingredient17 };
        }
        public class Ingredients
        {
            public string Name { get; set; }
        }
    }
}
