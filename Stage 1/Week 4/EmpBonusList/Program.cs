﻿using System;
using System.Collections.Generic;   // needed for Lists

namespace listAbstractClass
{
  class Program
  {
    static void Main(string[] args)
    {

      List<string> menuOptions = new List<string>();
   
      menuOptions.Add("C - Create");
      menuOptions.Add("R - Read");
      menuOptions.Add("U - Update");
      menuOptions.Add("D - Delete");
      menuOptions.Add("Q - Quit");


bool isMenuLooping = true;

while (isMenuLooping)
{


     Console.WriteLine("Please select an option:");
     foreach (var option in menuOptions)
          {
        Console.WriteLine(option);
          }
string menuchoice = Console.ReadLine();
// Console.WriteLine(menuchoice);
string menuchoiceUp = menuchoice.ToUpper();
// direct the program to the menu choice using switch/case
switch (menuchoiceUp)
{
  case "C":
    // Create a new item.
     Console.WriteLine("In the C/c area");
    break;
  case "R":
    // Read an existing item.
    Console.WriteLine("In the R/r area");
    break;
  case "U":
    // Update an existing item.
     Console.WriteLine("In the U/u area");
    break;
  case "D":
    // Delete an existing item.
     Console.WriteLine("In the D/d area");
    break;
  case "Q":
    // Quit the application.
    Console.WriteLine("In the Q/q area");
    isMenuLooping = false; // user chose Q so quit the looping
    Console.WriteLine("Good Bye...");
    break;
  default:
    // Invalid option.
    break;

} 
} // end menu loop


     } // end main
  }  // end program
} // end namespace

