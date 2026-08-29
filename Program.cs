namespace Enum_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Burger newBurger = new()
            {
                Bun = Buns.SesameSeedBun,
                Cheeses = Cheeses.Provolone | Cheeses.American
            };

            Console.WriteLine(newBurger.Bun);
            Console.WriteLine(newBurger.Cheeses);
        }
    }

    public class Burger
    {
        public Buns Bun { get; set; }
        public Cheeses Cheeses { get; set; }
        public Toppings Toppings { get; set; }
        public Sauces Sauces { get; set; }

        public void AddCheese(Cheeses newCheese)
        {
            Cheeses |= newCheese;
        }
    }

    public enum Buns
    {
        SesameSeedBun = 1,
        LettuceWrap = 2,
        EnglishMuffin = 3
    }

    [Flags]
    public enum Cheeses
    {
        None = 0,
        Cheddar = 1,
        American = 2,
        Swiss = 4,
        PepperJack = 8,
        Provolone = 16
    }

    [Flags]
    public enum Toppings
    {
        None = 0,
        Lettuce = 1,
        Tomato = 2,
        Onion = 4,
        Pickles = 8,
        Jalapenos = 16
    }

    [Flags]
    public enum Sauces
    {
        None = 0,
        Ketchup = 1,
        Mustard = 2,
        Mayo = 4,
        BBQ = 8,
    }
}
