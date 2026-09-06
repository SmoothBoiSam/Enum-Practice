namespace Enum_Practice.Food
{
    public class Burger
    {
        public Buns Bun { get; set; }
        public Cheeses Cheeses { get; set; }
        public Toppings Toppings { get; set; }
        public Sauces Sauces { get; set; }

        public void DisplayBurger()
        {
            Console.WriteLine($"Bun : {Bun}");
            Console.WriteLine($"Cheeses : {Cheeses}");
            Console.WriteLine($"Toppings : {Toppings}");
            Console.WriteLine($"Sauces : {Sauces}");
        }
    }
}
