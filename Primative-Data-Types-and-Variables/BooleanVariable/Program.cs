using System;

namespace BooleanVariable
{
    class BooleanVariable
    {
        static void Main()
        {
            Boolean isFemale;
            String myGender = "Male";

            if (myGender == "Male")
            {
                isFemale = false;
            }
            else
            {
                isFemale = true;
            }
            Console.WriteLine(isFemale);
        }
    }
}
