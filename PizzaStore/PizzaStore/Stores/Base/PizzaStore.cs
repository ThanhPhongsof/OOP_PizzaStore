using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public abstract class PizzaStore
    {
        public void OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }

        protected abstract Pizza CreatePizza(string type);

            //switch (type)
            //{
            //    case "cheese":
            //        pizza = new CheesePizza();
            //        break;
            //    case "greek":
            //        pizza = new GreekPizza();
            //        break;
            //    case "pepperoni":
            //        pizza = new PepperoniPizza();
            //        break;
            //    default:
            //        Console.WriteLine($"We do not have { type } pizza ");
            //        return;
            //}
    }
}
