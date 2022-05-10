using System;

namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Bethany";
            string lastName = "Smith";


            string fullName = firstName + " " + lastName;
            string employeeIdentification = string.Concat(firstName, lastName);


            string empId = firstName.ToLower() + "-" + lastName.Trim().ToLower();

            int length = empId.Length;

            if (fullName.Contains("beth") || fullName.Contains("Beth"))
            {
                Console.WriteLine("It's Bethany!");
            }

            string subString = fullName.Substring(1, 3);
            Console.WriteLine("Characters 2-4 of fullName are: " + subString);


            Console.ReadLine();
        }
    }
}
