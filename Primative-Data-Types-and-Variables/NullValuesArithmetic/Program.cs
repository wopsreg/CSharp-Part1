using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main()
        {
            int? first = null;
            double? second = null;

            Console.WriteLine("First: {0}, Second: {1}", first, second);
            Console.WriteLine("Adding values 7 and 9!");
            first = 7;
            second = 9;
            Console.WriteLine("First: {0}, Second: {1}", first, second);
        }
    }
}
