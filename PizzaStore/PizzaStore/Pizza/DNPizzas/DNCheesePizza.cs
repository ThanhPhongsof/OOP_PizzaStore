using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class DNCheesePizza : Pizza
    {
        public DNCheesePizza()
        {
            name = "DN The best cheese pizza";
            dough = "DN Very thin dough";
            sauce = "DN Very spicry sauce";

            toppings.Add("DN Black Olives");
            toppings.Add("DN Cheese");
        }
    }
}
