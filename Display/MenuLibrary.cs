namespace Enum_Practice.Display
{
    internal class MenuLibrary
    {
        public static Menu Main = new Menu
        {
            Error = new string[] { "*** Invalid Input ***" },
            Title = new string[] { "=== MAIN MENU ===" },
            Prompt = new string[] { "Select an option" },
            Options = new string[] { "0 - QUIT APPLICATION", "1 - Add item to order", "2 - Display and edit order" }
        };
    }
}
