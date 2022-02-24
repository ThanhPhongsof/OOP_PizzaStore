using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class HUEGreekPizza : Pizza
    {
        public HUEGreekPizza()
        {
            name = "HUE A good greek pizza";
            dough = "HUE Thin dough";
            sauce = "HUE Chilli sauce";

            toppings.Add("HUE Tomato");
            toppings.Add("HUE Potato");
        }
    }
}
