/* Program Description: This program inputs a length and width in ft and calculates square feet and square yards
   Programmer: Mark Kenne
   v1.0 07/18/2023

   Requirements:
   prompt Length in ft
   read Length
   prompt Width in ft
   read Length
   display inputs     
   initialize area
   calc area as sq ft
   calc area as sq yds
   display results
    
   Algorythm:
   define environment 
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
namespace AreaCalculator
{
  class Program
  {
   static void Main(string[] args)
   {
       Console.WriteLine("Enter Length in Feet:");                                                                  // prompt Length to convert 
       double LengthInFt = Convert.ToDouble(Console.ReadLine());                                                    // get the Length as in a double 
       Console.WriteLine("Enter Width in Feet:");                                                                   // prompt Width to convert 
       double WidthInFt = Convert.ToDouble(Console.ReadLine());                                                     // get the Width as in a double     
       Console.Write("You input a Length of " + LengthInFt + " feet and a Width of " + WidthInFt + " feet.");       // Show what was entered
       double areaSqFt = 0.00, areaSqYards = 0.00;                                                                  // initialize sqft and sqyd area vars as a double
       areaSqFt = LengthInFt * WidthInFt;                                                                           // calc sqft area by multiplying Length times Width 
       areaSqYards = LengthInFt/3 * WidthInFt/3;                                                                    // calc sqyd area by dividing L and W by 3 and multiplying
       Console.WriteLine("  The result is an \"AREA\" of " + areaSqFt + " Sq.Ft. or " + areaSqYards + " Sq.Yds.");  // display the "area" results as Square Yds  
     }
    }
  }