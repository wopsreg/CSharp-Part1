using System;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string firstName = "John";
            string middleName = "Vilage";
            string lastName = "Dow";
            decimal moneyAmount = 734;
            string bankName = "First Bank";
            string IBAN = "8375897286";
            string BIC = "9787623408";
            string card1 = "098139485734";
            string card2 = "9870-4798457";
            string card3 = "876034508872";

            Console.WriteLine("{0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Money amound: {0} Bank: {1}", moneyAmount, bankName);
            Console.WriteLine("IBAN: {0} BIC: {1}", IBAN, BIC);
            Console.WriteLine("Credit card 1: {0}\nCredit card 2: {1}\nCredit cart 3: {2}", card1, card2, card3);
        }
    }
}
