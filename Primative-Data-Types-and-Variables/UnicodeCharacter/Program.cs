﻿using System;

namespace UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main()
        {
            char symbol = '\u002A';
            Console.WriteLine("The symbol that has Unicode code {0} is {1}"
                                , (int)symbol, symbol);
        }
    }
}
