using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class DNGreekPizza : Pizza
    {
        public DNGreekPizza()
        {
            name = "DN A good greek pizza";
            dough = "DN Thin dough";
            sauce = "DN Chilli sauce";

            toppings.Add("DN Tomato");
            toppings.Add("DN Potato");
        }
    }
}
