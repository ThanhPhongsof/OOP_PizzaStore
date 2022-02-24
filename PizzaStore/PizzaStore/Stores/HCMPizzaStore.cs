using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Stores
{
    public class HCMPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new HCMCheesePizza();
                    break;
                case "greek":
                    return new HCMGreekPizza();
                    break;
                case "pepperoni":
                    return new HCMPepperoniPizza();
                    break;
                default:
                    return null;
            }
        }
    }
}
