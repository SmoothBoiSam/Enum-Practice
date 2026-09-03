namespace Enum_Practice.Food
{
    public class Burger
    {
        public Buns Bun { get; set; }
        public Cheeses Cheeses { get; set; }
        public Toppings Toppings { get; set; }
        public Sauces Sauces { get; set; }
        public List<Burger> AllBurgers = new();

        public void AddCheese(Cheeses newCheese)
        {
            Cheeses |= newCheese;
        }

        public void Display()
        {
            foreach (Burger b in AllBurgers)
            {
                Console.WriteLine(b.Bun);
                Console.WriteLine(b.Cheeses);
                Console.WriteLine(b.Toppings);
                Console.WriteLine(b.Sauces);
                Console.WriteLine();
            }
        }
    }
}
