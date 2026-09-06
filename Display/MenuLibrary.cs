namespace Enum_Practice.Display
{
    internal class MenuLibrary
    {
        public static Menu Main = new Menu
        {
            Error = new string[] { "*** Invalid Input ***" },
            Title = new string[] { "=== Build a Burger ===" },
            Prompt = new string[] { "Select an option" },
            Options = new string[] { "0 - QUIT APPLICATION", "1 - Build a new burger", "2 - Display all burgers" }
        };

        public static Menu BurgerBuns = new Menu
        {
            Error = new string[] { "*** Invalid Input ***" },
            Title = new string[] { "=== New Burger ===" },
            Prompt = new string[] { "Select a bun type" },
            Options = new string[] { "0 - BACK", "1 - Sesame Seed", "2 - Lettuce Wrap", "3 - English Muffin", "4 - NEXT" }
        };

        public static Menu BurgerToppings = new Menu
        {
            Error = new string[] { "*** Invalid Input ***" },
            Title = new string[] { "=== New Burger ===" },
            Prompt = new string[] { "Select or deselect toppings" },
            Options = new string[] { "0 - BACK", "1 - Lettuce", "2 - Tomato", "3 - Onion", "4 - Pickles", "5 - Jalapenos", "6 - DONE" }
        };

        public static Menu BurgerCheeses = new Menu
        {
            Error = new string[] { "*** Invalid Input ***" },
            Title = new string[] { "=== New Burger ===" },
            Prompt = new string[] { "Select or deselect cheeses" },
            Options = new string[] { "0 - BACK", "1 - American", "2 - Cheddar", "3 - Swiss", "4 - Provolone", "5 - Pepper Jack", "6 - DONE" }
        };

        public static Menu BurgerSauces = new Menu
        {
            Error = new string[] { "*** Invalid Input ***" },
            Title = new string[] { "=== New Burger ===" },
            Prompt = new string[] { "Select or deselect sauces" },
            Options = new string[] { "0 - BACK", "1 - Ketchup", "2 - Mustard", "3 - Mayo", "4 - BBQ", "5 - DONE" }
        };

        public static Menu BurgerConfirm = new Menu
        {
            Error = new string[] { "*** Invalid Input ***" },
            Title = new string[] { "=== New Burger ===" },
            Prompt = new string[] { "Add this burger to your order?" },
            Options = new string[] { "0 - BACK", "1 - CONFIRM BURGER" }
        };

        public static Menu DisplayBurgers = new Menu
        {
            Error = new string[] { "*** Invalid Input ***" },
            Title = new string[] { "=== Your Burgers ===" },
            Prompt = new string[] { "Select an option" },
            Options = new string[] { "0 - BACK", "1 - Delete all burgers" }
        };
    }
}
