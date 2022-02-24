
namespace PizzaStore
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();
        protected string type;

        public void Prepare()
        {
            Console.WriteLine($"Preparing { name } ");
            Console.WriteLine($"Tossing dough... { dough }");
            Console.WriteLine($"Adding sauce { dough }");
            Console.WriteLine($"Adding toppings... ");

            // Allow show toppings
            toppings?.ForEach(x => Console.WriteLine($"\t { x }"));
        }

        public void Bake()
        {
            Console.WriteLine($"Baking { name } in 30 mins");
        }

        public void Cut()
        {
            Console.WriteLine($"Cutting { name } ");
        }

        public void Box()
        {
            Console.WriteLine($"Boxing { name }");
            Console.WriteLine($"-------------------------------------");
        }
    }
}
