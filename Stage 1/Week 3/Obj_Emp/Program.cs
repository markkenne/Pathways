// Program.cs   Used to test Objects and Constructs  mk 8/1/23

using System;

namespace Employees
{
    class Program
  {
     // Main program
    static void Main(string[] args)
    {
    // constant for hourly rate
       const int hourly = 75;

    // Class Construct calls
       Employee e0 = new Employee();
       Employee e1 = new Employee("Kenne","Mark");
       Employee e2 = new Employee("Programming Engineer");
       Employee e3 = new Employee(hourly, 1);
       Employee e4 = new Employee(hourly, 26);
       Employee e5 = new Employee(hourly, 52);
       Employee e6 = new Employee(hourly);

    // Output
       Console.WriteLine("Employee type = "   +  e0);
       Console.WriteLine("Employee Name = "   +  e1.Name);
       Console.WriteLine("Job Title = "       +  e2.Job);
       Console.WriteLine("Annual Salary = "   +  e3.Salary);
       Console.WriteLine("Biweekly Salary = " +  e4.Salary);
       Console.WriteLine("Weekly Salary = "   +  e5.Salary);
       Console.WriteLine("Hourly Salary = "   +  e6.Salary);

    } // end of Main
  } // end of class
}  // end of namespace