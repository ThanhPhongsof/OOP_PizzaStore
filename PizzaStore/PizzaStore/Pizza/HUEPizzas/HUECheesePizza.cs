using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class HUECheesePizza : Pizza
    {
        public HUECheesePizza()
        {
            name = "HUE The best cheese pizza";
            dough = "HUE Very thin dough";
            sauce = "HUE Very spicry sauce";

            toppings.Add("HUE Black Olives");
            toppings.Add("HUE Cheese");
        }
    }
}
