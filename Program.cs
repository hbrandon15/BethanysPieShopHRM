using System;

namespace BethanysPieShopHRM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Creating an employee");
            Console.WriteLine("-------------------\n");
            Employee bethany = new Employee("Bethany", "Smith", "bethany@snowball.be", new DateTime(1979, 1, 16), EmployeeType.Manager, 25);

            bethany.DisplayEmployeeDetails();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.PerformWork();
            bethany.ReceiveWage();


            Console.ReadLine();

        }
    }
}
