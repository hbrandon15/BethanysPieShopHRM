using System;
using System.Text;

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

            string nameUsingInterpolation = $"{firstName}-{lastName}";

            string greeting = $"Hello, {firstName.ToLower()}";
            Console.WriteLine(greeting);

            string displayName = $"Welcome!\n{firstName}\t{lastName}";
            Console.WriteLine(displayName);


            //string name1 = "Bethany";
            //string name2 = "bethany";

            //Console.WriteLine("Are both names equal?" + (name1 == name2));
            //Console.WriteLine("Is name equal to Bethany?" + (name1 == "Bethany"));
            //Console.WriteLine("Is name equal to BETHANY?" + name2.Equals("BETHANY"));


            //string name = "Bethany";
            //string anotherName = name;

            //name += " Smith";


            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Another name: " + anotherName);


            StringBuilder builder = new StringBuilder();

            builder.Append("Last name: ");
            builder.AppendLine(lastName);
            builder.Append("First Name: ");
            builder.Append(firstName);
            string result = builder.ToString();
            Console.WriteLine(result);


            Console.WriteLine("Enter the wage:");
            string wage = Console.ReadLine();

            //int wageValue = int.Parse(wage);

            int wageValue;
            if (int.TryParse(wage, out wageValue))
                Console.WriteLine("Parsing success: " + wageValue);
            else
                Console.WriteLine("Parsing failed");




            Console.ReadLine();
        }
    }
}
