using System;

namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int monthlyWage = 1234;
            //int months = 12;
            //int bonus = 1000; 

            ////int yearlyWage = CalculateYearlyWage(monthlyWage, months, bonus);
            ////Console.WriteLine($"Yearly wage (from main): {yearlyWage}");
            //double monthlyWageDouble = 1234;
            //double monthsDouble = 12;
            //double bonusDouble = 1000;

            //double yearlyWageWithBonusDouble = CalculateYearlyWage(monthlyWageDouble, monthsDouble, bonusDouble);

            UsingOutParameters(); 
            Console.ReadLine();
        }

        private static void UsingOutParameters()
        {
            int monthlyWage1 = 1234;
            int months1 = 12;
            int bonus; // notice there is no intial value

            int yearlyWageForEmployee1 = CalculateYearlyWageWithOut(monthlyWage1, months1, out bonus);
            Console.WriteLine($"Yearly wage for employee 1 (Bethany):  {yearlyWageForEmployee1}");
            Console.WriteLine($"Bethany received a bonus of {bonus}");
        }

        private static int CalculateYearlyWageWithOut(int monthlyWage, int numberOfMonthsWorked, out int bonus)
        {
            bonus = new Random().Next(1000); // C# code to generate a random number smaller than 1000
            if (bonus < 500)
            {
                bonus *= 2;
                Console.WriteLine("Bonus doubled! Yay!!");
            }

            Console.WriteLine($"The yearly wage is: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus; 
        }

        public static int CalculateYearlyWage(int monthlyWage, int numberOfMonthsWorked)
        {
            //Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked}");
            return monthlyWage * numberOfMonthsWorked;
        }

        public static double CalculateYearlyWage(double monthlyWage, double numberOfMonthsWorked, double bonus)
        {
            Console.WriteLine($"Yearly wage: {monthlyWage * numberOfMonthsWorked + bonus}");
            return monthlyWage * numberOfMonthsWorked + bonus;
        }
    }
}
