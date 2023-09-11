using System;
using System.ComponentModel;

namespace HomeBuilder
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the cost of one DOOR:");
            double doorAmt = double.Parse(Console.ReadLine());
            Console.WriteLine("Door Cost = " + doorAmt + ". Enter how many doors you need:");
            int doorCt = int.Parse(Console.ReadLine());
            var door = new Door(doorCt, doorAmt);
            Console.WriteLine("Doors will cost $" + (doorCt * doorAmt));

            Console.WriteLine("Enter the cost of one WINDOW:");
            double winAmt = double.Parse(Console.ReadLine());
            Console.WriteLine("Door Cost = " + winAmt + ". Enter how many windows you need:");
            int winCt = int.Parse(Console.ReadLine());
            var window = new Window(winCt,winAmt);
            Console.WriteLine("Windows will cost $" + (winCt * winAmt));

            Console.WriteLine("Enter the cost of one WALL:");
            double wallAmt = double.Parse(Console.ReadLine());
            Console.WriteLine("Wall Cost = " + wallAmt + ". Enter how many walls you need:");
            int wallCt = int.Parse(Console.ReadLine());
            var wall = new Window(wallCt, wallAmt);
            Console.WriteLine("Walls will cost $" + (wallCt * wallAmt));

            Console.WriteLine("Enter the cost of one FLOOR:");
            double floorAmt = double.Parse(Console.ReadLine());
            Console.WriteLine("Floor Cost = " + floorAmt + ". Enter how many floors you need:");
            int floorCt = int.Parse(Console.ReadLine());
            var floor = new Window(floorCt, floorAmt);

            var components = new IComponents[] { door, wall, window, floor };
            var house = new HouseService(components);
            var totalCost = house.GetTotalCost();

            Console.WriteLine("The total cost of the house is {0:0.00}", totalCost);
        }
    }
}