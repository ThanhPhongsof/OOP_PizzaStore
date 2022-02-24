using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class HCMCheesePizza : Pizza
    {
        public HCMCheesePizza()
        {
            name = "HCM The best cheese pizza";
            dough = "HCM Very thin dough";
            sauce = "HCM Very spicry sauce";

            toppings.Add("HCM Black Olives");
            toppings.Add("HCM Cheese");
        }
    }
}
