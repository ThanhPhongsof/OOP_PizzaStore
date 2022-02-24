using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore.Stores
{
    public class HUEPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new HUECheesePizza();
                    break;
                case "greek":
                    return new HUEGreekPizza();
                    break;
                case "pepperoni":
                    return new HUEPepperoniPizza();
                    break;
                default:
                    return null;
            }
        }
    }
}
