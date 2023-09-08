using System;

namespace HouseBuilder
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            var door = new Door();
            var wall = new Wall();
            var window = new Window();
            var floor = new Window();
            var components = new IComponent[] { door, wall, window, floor };

            var house = new House(components);

            var totalCost = house.GetTotalCost();

            Console.WriteLine("The total cost of the house is {0:0.00}", totalCost);
        }
    }
}