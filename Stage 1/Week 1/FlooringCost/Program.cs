/* Program Description: This program inputs a length and width in ft and calculates square feet and square yards and cost 
                        and will tell you if you are within budget
   Programmer: Mark Kenne
   v1.0 07/18/2023

   Requirements:
   set 2000 budget
   prompt Length in ft
   read Length
   prompt Width in ft
   read Length
   prompt Cost/yd
   read Cost/yd
   display inputs     
   initialize area
   calc area as sq ft
   calc area as sq yds
   calc cost
   under or over budget
   display results
    
   Algorythm:
   define environment 
   set a constant for 
   prompt user for Length
   get the Length as in a double     
   prompt user for Width
   get the Width as in a double 
   initialize area as a double
   calc sq ft area by multiplying Length times Width     
   calc sq yd area by dividing Length and Width by 3 and multiplying the two results  
   display the results as Square Yds
   */
    // define environment
using System;
namespace CostCalculator
{
  class Program
  {
   static void Main(string[] args)
   {
       const int myBudget = 2000;                                                                                   // Set a constant as myBudget of 2000
       Console.WriteLine("Enter Room Length in Feet:");                                                             // prompt Length to convert 
       double LengthInFt = Convert.ToDouble(Console.ReadLine());                                                    // get the Length as a double 
       Console.WriteLine("Enter Room Width in Feet:");                                                              // prompt Width to convert 
       double WidthInFt = Convert.ToDouble(Console.ReadLine());                                                     // get the Width as a double   
       Console.WriteLine("Enter Flooring price per yard:");                                                         // prompt flooring Cost per Yard
       double CostPerYd = Convert.ToDouble(Console.ReadLine());                                                     // get the CostPerYd as a double         
       Console.Write("You input a Length of " + LengthInFt + " feet and a Width of " 
        + WidthInFt + " feet at a cost of $" + CostPerYd + " per Yd.");                                             // Show what was entered
       double areaSqFt = 0.00, areaSqYards = 0.00, totalCost = 0.00, budgetDiff = 0.00;                             // initialize sqft,sqyd area, and cost vars as a double
       areaSqFt = LengthInFt * WidthInFt;                                                                           // calc sqft area by multiplying Length times Width 
       areaSqYards = (LengthInFt/3) * (WidthInFt/3);                                                                // calc sqyd area by dividing L and W by 3 and multiplying
       totalCost = areaSqYards * CostPerYd;                                                                         // calc total cost
       budgetDiff = Math.Abs(myBudget - totalCost);                                                                 // calc budget difference
       Console.WriteLine("  The result is an \"AREA\" of " + Math.Round(areaSqFt) 
         + " Sq.Ft. or " + Math.Round(areaSqYards) + " Sq.Yds.");                                                   // display the rounded "area" results as Square Yds  
                                                                                                                    
       // display cost and how  much over or under budget

       if (totalCost > myBudget)
       { 
        Console.WriteLine("This will cost you " + ($"{totalCost:C2}")  
        + ".  You are OVER your budget of " + ($"{myBudget:C2}") +  " by " + ($"{budgetDiff:C2}") );
       }
       else 
       { 
        Console.WriteLine("This will cost you " + ($"{totalCost:C2}")  
        + ".  You are UNDER your budget of " + ($"{myBudget:C2}") +  " by " + ($"{budgetDiff:C2}") );
       }
    }
  }
}