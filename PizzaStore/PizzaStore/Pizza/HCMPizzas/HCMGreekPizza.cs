using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class HCMGreekPizza : Pizza
    {
        public HCMGreekPizza()
        {
            name = "HCM A good greek pizza";
            dough = "HCM Thin dough";
            sauce = "HCM Chilli sauce";

            toppings.Add("HCM Tomato");
            toppings.Add("HCM Potato");
        }
    }
}
