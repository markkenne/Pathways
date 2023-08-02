// Program.cs
using System;
namespace Employees
{
    class Program
    {
     // Main program
        static void Main(string[] args)
        {

// Construct calls
Restaurant r0 = new Restaurant();
Restaurant r1 = new Restaurant("My Restaurant");
Restaurant r2 = new Restaurant (2);
Restaurant r3 = new Restaurant ("Mexican","Full-Service");
Restaurant r4 = new Restaurant (3, "Blaze Pizza", "Fast Food");

// Output
Console.WriteLine("Restaurant  " +  r0.getRestName() + " " + r0.getRating() + "  " + r0.getRestType());
Console.WriteLine("Restaurant Name = " +  r1.getRestName());
Console.WriteLine("Rating Stars = "    +  r2.getRating());
Console.WriteLine("Restaurant Type = " +  r3.getRestType());
Console.WriteLine("Restaurant  " +  r4.getRestName() + " " + r4.getRating() + "  " + r4.getRestType());
        }
    }
}