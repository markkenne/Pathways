// Program.cs
using System;

namespace CarProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Car object from the Car.cs file
            Car car = new Car("Ford", "Blue", "Mustang", 2023);

            // Print the car's information
            Console.WriteLine("Make: " + car.Make);
            Console.WriteLine("Color: " + car.Color);
            Console.WriteLine("Model: " + car.Model);
            Console.WriteLine("Year: " + car.Year);
        }
    }
}
