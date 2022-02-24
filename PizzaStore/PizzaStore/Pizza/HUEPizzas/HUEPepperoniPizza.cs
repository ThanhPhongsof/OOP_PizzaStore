using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    internal class HUEPepperoniPizza : Pizza
    {
        public HUEPepperoniPizza()
        {
            name = "HUE The best pepperoni pizza";
            dough = "HUE Thick dough";
            sauce = "HUE Sweet sauce";

            toppings.Add("HUE Tomato");
        }
    }
}
