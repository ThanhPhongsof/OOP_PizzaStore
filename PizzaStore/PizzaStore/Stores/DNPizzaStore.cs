using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Stores
{
    internal class DNPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new DNCheesePizza();
                    break;
                case "greek":
                    return new DNGreekPizza();
                    break;
                case "pepperoni":
                    return new DNPepperoniPizza();
                    break;
                default:
                    return null;
            }
        }
    }
}
