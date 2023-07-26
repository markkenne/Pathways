// program description: This program inputs a number of yds from user and converts to Ft and inches and outputs both
// programmer: MK
// v1.0 07/17/2023
    // int Ft = 3
    // int Yds =1
    // read distance to convert 
    // get number of yds from user as Int
    // number of feet calculated by taking ysd times 3
    //Algorythm:
    // define environment 
    // prompt user for Yds
    // get the yds
    // divide yds by 3
    // output the number of ft


    // define environment
using System;
namespace YardsToFeet
{
  class Program
  {
   static void Main(string[] args)
   {

    // prompt user for Yds
Console.WriteLine("Enter Yards to convert to feet:");
    // get the yds in a variable 
int numberOfYards = Convert.ToInt32(Console.ReadLine());

    // divide yds by 3
int numberOfFeet = numberOfYards * 3;

    // output the number of ft
        Console.WriteLine("The number of feet in " + numberOfYards + " yards is " + numberOfFeet + ".");
     }
    }
  }