using System;

namespace ExchangeVariables
{
    class ExchangeVariables
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
        }
    }
}
