// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using PizzaStore.Stores;

var huepizzaStore = new HUEPizzaStore();
huepizzaStore.OrderPizza("cheese");

var dnpizzaStore = new DNPizzaStore();
dnpizzaStore.OrderPizza("greek");

var hcmpizzaStore = new HCMPizzaStore();
hcmpizzaStore.OrderPizza("pepperoni");

