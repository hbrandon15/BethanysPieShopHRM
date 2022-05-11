using System;

namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int monthlyWage = 1234;
            int months = 12; 

            int yearlyWage = CalculateYearlyWage(monthlyWage, months);
            Console.WriteLine($"Yearly wage (from main): {yearlyWage}");

            Console.ReadLine();
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
            return monthlyWage * numberOfMonthsWorked;
        }
    }
}
