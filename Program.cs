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

            List<Object> currentOrder = new();

            while (running)
            {
                switch (currentMenu)
                {
                    case (MenuSwitch.Main):
                        switch (DisplayMenuAndGetInput(MenuLibrary.Main))
                        {
                            case 0:
                                Console.Clear();

                                Console.WriteLine("Thanks for using my app! :)");
                                Console.WriteLine("Press any key to exit");
                                Console.WriteLine();
                                Console.WriteLine("- SmoothBoiSam");

                                Console.ReadLine();

                                running = false;
                                break;
                            case 1:
                                break;
                            case 2:
                                break;
                        }
                        break;
                }
            }
        }

        static int DisplayMenuAndGetInput(Menu menu)
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