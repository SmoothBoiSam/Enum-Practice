using Enum_Practice.Display;
using Enum_Practice.Food;

namespace Enum_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            MenuSwitch currentMenu = MenuSwitch.Main;

            List<Burger> currentOrder = new();
            Burger newBurger = new();

            while (running)
            {
                switch (currentMenu)
                {
                    case (MenuSwitch.Main):
                        switch (DisplayMenuAndGetInput(MenuLibrary.Main, null, null))
                        {
                            case 0:
                                Console.Clear();

                                Console.WriteLine("Thanks for using my app! :)");
                                Console.WriteLine("Press enter to exit");
                                Console.WriteLine();
                                Console.WriteLine("- SmoothBoiSam");

                                Console.ReadLine();

                                running = false;
                                break;
                            case 1:
                                newBurger = new Burger();
                                currentMenu = MenuSwitch.BurgerBuns;
                                break;
                            case 2:
                                currentMenu = MenuSwitch.DisplayBurgers;
                                break;
                        }
                        break;
                    case (MenuSwitch.BurgerBuns):
                        switch (DisplayMenuAndGetInput(MenuLibrary.BurgerBuns, newBurger, null))
                        {
                            case 0:
                                currentMenu = MenuSwitch.Main;
                                break;
                            case 1:
                                newBurger.Bun = Buns.SesameSeed;
                                break;
                            case 2:
                                newBurger.Bun = Buns.LettuceWrap;
                                break;
                            case 3:
                                newBurger.Bun = Buns.EnglishMuffin;
                                break;
                            case 4:
                                currentMenu = MenuSwitch.BurgerToppings;
                                break;
                        }
                        break;
                    case (MenuSwitch.BurgerToppings):
                        switch (DisplayMenuAndGetInput(MenuLibrary.BurgerToppings, newBurger, null))
                        {
                            case 0:
                                currentMenu = MenuSwitch.BurgerBuns;
                                break;
                            case 1:
                                newBurger.Toppings ^= Toppings.Lettuce;
                                break;
                            case 2:
                                newBurger.Toppings ^= Toppings.Tomato;
                                break;
                            case 3:
                                newBurger.Toppings ^= Toppings.Onion;
                                break;
                            case 4:
                                newBurger.Toppings ^= Toppings.Pickles;
                                break;
                            case 5:
                                newBurger.Toppings ^= Toppings.Jalapenos;
                                break;
                            case 6:
                                currentMenu = MenuSwitch.BurgerCheeses;
                                break;
                        }
                        break;
                    case (MenuSwitch.BurgerCheeses):
                        switch (DisplayMenuAndGetInput(MenuLibrary.BurgerCheeses, newBurger, null))
                        {
                            case 0:
                                currentMenu = MenuSwitch.BurgerToppings;
                                break;
                            case 1:
                                newBurger.Cheeses ^= Cheeses.American;
                                break;
                            case 2:
                                newBurger.Cheeses ^= Cheeses.Cheddar;
                                break;
                            case 3:
                                newBurger.Cheeses ^= Cheeses.Swiss;
                                break;
                            case 4:
                                newBurger.Cheeses ^= Cheeses.Provolone;
                                break;
                            case 5:
                                newBurger.Cheeses ^= Cheeses.PepperJack;
                                break;
                            case 6:
                                currentMenu = MenuSwitch.BurgerSauces;
                                break;
                        }
                        break;
                    case (MenuSwitch.BurgerSauces):
                        switch (DisplayMenuAndGetInput(MenuLibrary.BurgerSauces, newBurger, null))
                        {
                            case 0:
                                currentMenu = MenuSwitch.BurgerCheeses;
                                break;
                            case 1:
                                newBurger.Sauces ^= Sauces.Ketchup;
                                break;
                            case 2:
                                newBurger.Sauces ^= Sauces.Mustard;
                                break;
                            case 3:
                                newBurger.Sauces ^= Sauces.Mayo;
                                break;
                            case 4:
                                newBurger.Sauces ^= Sauces.BBQ;
                                break;
                            case 5:
                                currentMenu = MenuSwitch.BurgerConfirm;
                                break;
                        }
                        break;
                    case (MenuSwitch.BurgerConfirm):
                        switch (DisplayMenuAndGetInput(MenuLibrary.BurgerConfirm, newBurger, null))
                        {
                            case 0:
                                currentMenu = MenuSwitch.BurgerSauces;
                                break;
                            case 1:
                                currentOrder.Add(newBurger);
                                newBurger = new Burger();
                                currentMenu = MenuSwitch.Main;
                                break;
                        }
                        break;
                    case (MenuSwitch.DisplayBurgers):
                        switch(DisplayMenuAndGetInput(MenuLibrary.DisplayBurgers, null, currentOrder))
                        {
                            case 0:
                                currentMenu = MenuSwitch.Main;
                                break;
                            case 1:
                                currentOrder = new List<Burger>();
                                break;
                        }
                        break;
                }
            }
        }

        static int DisplayMenuAndGetInput(Menu menu, Burger currentBurger, List<Burger> allBurgers)
        {
            bool running = true;
            bool displayError = false;
            int returnInt = -1;

            while (running)
            {
                Console.Clear();

                if (displayError)
                {
                    foreach (string s in menu.Error)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine();
                }

                foreach (string s in menu.Title)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();

                if (currentBurger != null)
                {
                    currentBurger.DisplayBurger();
                    Console.WriteLine();
                }

                if (allBurgers != null)
                {
                    if (allBurgers.Count == 0)
                    {
                        Console.WriteLine("No burgers in order :( I'M HUNGRY");
                        Console.WriteLine();
                    }
                    else
                    {
                        for (int i = 0; i < allBurgers.Count; i++)
                        {
                            Burger b = allBurgers[i];
                            Console.WriteLine($"Burger #{i + 1}");
                            b.DisplayBurger();
                            Console.WriteLine();
                        }
                    }
                }

                foreach (string s in menu.Prompt)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();

                foreach (string s in menu.Options)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine();

                string? input = Console.ReadLine();
                if (!string.IsNullOrEmpty(input) & int.TryParse(input, out int inputInt))
                {
                    if (inputInt < 0 || inputInt >= menu.Options.Length)
                    {
                        displayError = true;
                    }
                    else
                    {
                        returnInt = inputInt;
                        running = false;
                    }
                }
                else
                {
                    displayError = true;
                }
            }

            return returnInt;
        }
    }
}