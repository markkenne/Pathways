/* Program Description: Exponent calculator. This program inputs a base and an exponent from the user, 
                        and uses a method to print the value of the base taken to the exponent power.
                        Process repeats until the user wants to quit.

   Programmer: Mark Kenne
   Last Update:  07/20/2023

   Requirements:
   (1) Base value >= 1 obtained from user
   (2) Exponent value >= 1 obtained from user
   (3) Calculate result and display
   (4) Ask user if they want to quit
   (5) Exit on y
    
   Algorithm:
   (1) Define environment
   (2) Initialize Base, Exponent, and Result
   (3) Prompt for Base and validate input (using method later)
   (4) Prompt for Exponent and validate input (using method later)
   (5) Calculate resultant using method and display
   (6) Prompt user to quit in a do-while loop
   (7) If Y then end loop
*/

  // Define environment
using System;
 namespace CalcExponent
 {
   class Program 
  
   {
    static double MyExpMethod(double Number1, double Number2)
    {
       double ResultNum = Math.Pow(Number1, Number2);
      // Console.WriteLine(Number1 + " to the power of " + Number2 + " is " + ResultNum);  
      return ResultNum;
    }

    public static void Main(string[] args)
    {

    // Initialize Base, Exponent, and quitnow  
       double Number1, Number2;
       string? quit = "N";

    // do while loop until quit   
       do 
       {    
    
    // Prompt for Base number  
       Console.WriteLine("Enter Base number:");
       Number1 = Convert.ToDouble(Console.ReadLine());  

    // validate that Base is at least 1                                                            
         while (Number1<1)                                                                                     
         {
          Console.WriteLine("Base can't be less than 1! Input your Base again please.");
          Number1 = Convert.ToDouble(Console.ReadLine());
         }
 
    // Prompt for Exponent number  
       Console.WriteLine("Enter Exponent number:");
       Number2 = Convert.ToDouble(Console.ReadLine());  

    // validate that Exponent is at least 1 ft                                                            
         while (Number2<1)                                                                                     
         {
          Console.WriteLine("Exponent can't be less than 1! Input your Exponent again please.");
          Number2 = Convert.ToDouble(Console.ReadLine());
         }
    // Use method to get result
//       MyExpMethod(Number1,Number2);     
        Console.WriteLine(Number1 + " to the power of " + Number2 + " is " +  MyExpMethod(Number1,Number2));
    // This is here just to test without using the method 
      /* ResultNum = Math.Pow(Number1, Number2);
       Console.WriteLine(Number1 + " to the power of " + Number2 + " is " + ResultNum);     
      */

    // Prompt the user to quit.
       Console.WriteLine("Do you wish to quit? (y/n): ");
       quit  = Console.ReadLine();
 
    // Quit if Y
       } 
       while (quit != "y");
    }
  }
}