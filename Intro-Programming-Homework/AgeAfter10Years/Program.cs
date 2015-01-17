using System;

namespace AgeAfter10Years
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter Your Age:");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Your age after 10 years will be:{0}", Age + 10);
        }
    }
}
