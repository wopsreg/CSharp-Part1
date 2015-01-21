using System;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main()
        {
            string firstName;
            string familyName;
            byte age;
            string gender;
            short id;
            int uniqueEmployeNumber;

            firstName = "John";
            familyName = "Dow";
            age = 74;
            gender = "Male";
            id = 7;
            uniqueEmployeNumber = 27560000;

            Console.WriteLine("First name: {0}\nFamily Name: {1}\nAge: {2}\nGender: {3}\nId: {4}\nUnique Number: {5}", firstName, familyName, age, gender, id, uniqueEmployeNumber);
        }
    }
}
