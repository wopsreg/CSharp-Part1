using System;

namespace StringsandObjects
{
    class StringsandObjects
    {
        static void Main()
        {
            string firstWord = "Hello";
            string secondWord = "World";
            object sentence = firstWord + ", " + secondWord;
            string newSentence = (string)sentence;
            Console.WriteLine(newSentence + "!");
        }
    }
}
