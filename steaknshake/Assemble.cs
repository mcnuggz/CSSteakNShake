using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace steaknshake
{
    public class Assemble: IngredientList
    {
        public int bunAmt = 1;
        public int pattyAmt = 2;
        public int lettuceAmt = 0;
        public int tomatoAmt = 0;
        public int pickleAmt = 0;
        public int cheeseAmt = 0;
        public int ketchupAmt = 0;
        public int mustardAmt = 0;
        public int mayonaiseAmt = 0;
        public int friscoAmt = 0;
        public int friedOnionAmt = 0;
        public int grilledEggAmt = 0;
        public int guacamoleAmt = 0;
        public int onionRingAmt = 0;
        public int baconAmt = 0;
        public int onionAmt = 0;

        public void addBun()
        {
            bunAmt = bunAmt + 1;
        }
        public void addPatty()
        {
            pattyAmt = pattyAmt + 1;
        }
        public void addLettuce()
        {
            lettuceAmt = lettuceAmt + 1;
        }
        public void addTomato()
        {
            tomatoAmt = tomatoAmt + 1;
        }
        public void addPickles()
        {
            pickleAmt = pickleAmt + 1;
        }
        public void addCheese()
        {
            cheeseAmt = cheeseAmt + 1;
        }
        public void addOnion()
        {
            onionAmt = onionAmt + 1;
        }
        public void addKetchup()
        {
            ketchupAmt = ketchupAmt +1;
        }
        public void addMustard()
        {
            mustardAmt = mustardAmt + 1;
        }
        public void addFrisco()
        {
            friscoAmt = friscoAmt + 1;
        }
        public void addMayo()
        {
            mayonaiseAmt = mayonaiseAmt + 1;
        }
        public void addFriedOnion()
        {
            friedOnionAmt = friedOnionAmt + 1;
        }
        public void addGrilledEgg()
        {
            grilledEggAmt = grilledEggAmt + 1;
        }
        public void addGuacamole()
        {
            guacamoleAmt = guacamoleAmt + 1;
        }
        public void addOnionRing()
        {
            onionRingAmt = onionRingAmt + 1;
        }
        public void addBacon()
        {
            baconAmt = baconAmt + 1;
        }
    }
}