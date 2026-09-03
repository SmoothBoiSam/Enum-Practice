using System;
using System.Collections.Generic;
using System.Text;

namespace Enum_Practice.Food
{
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
