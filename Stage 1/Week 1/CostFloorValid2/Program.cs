using System;
namespace AreaCalculator
{
  class Program
  {
   static void Main(string[] args)
   {
       const int myBudget = 2000;                                                                                   // Set a constant as myBudget of 2000
       Console.WriteLine("Enter Room Length in Feet:");                                                             // prompt Length to convert 
       double LengthInFt = Convert.ToDouble(Console.ReadLine());                                                    // get the Length as in a double 
       Console.WriteLine("Enter Room Width in Feet:");                                                              // prompt Width to convert 
       double WidthInFt = Convert.ToDouble(Console.ReadLine());                                                     // get the Width as in a double   
       Console.WriteLine("Enter Flooring price per yard:");                                                         // prompt flooring Cost per Yard
       double CostPerYd = Convert.ToDouble(Console.ReadLine());                                                     // get the CostPerYd as in a double         
       Console.Write("You input a Length of " + LengthInFt + " feet and a Width of " + WidthInFt + " feet at a cost of " + CostPerYd " per Yd." ); // Show what was entered
       double areaSqFt = 0.00, areaSqYards = 0.00, totalCost = 0.00;                                                // initialize sqft,sqyd area, and cost vars as a double
       areaSqFt = LengthInFt * WidthInFt;                                                                           // calc sqft area by multiplying Length times Width 
       areaSqYards = LengthInFt/3 * WidthInFt/3;                                                                    // calc sqyd area by dividing L and W by 3 and multiplying
       Console.WriteLine("  The result is an \"AREA\" of " + areaSqFt + " Sq.Ft. or " + areaSqYards + " Sq.Yds.");  // display the "area" results as Square Yds  
     }
    }
  }