/* Program Description: Floor Cost Estimator. This program inputs a budget amount, room length and width in ft, and material cost
                        It then calculates square feet, square yards and costs and displays if you are over/under budget and by how much.
                        This version uses method for input validation.
   Programmer: Mark Kenne
   Last Update:  07/20/2023

   Requirements:
   (1) Budget amount obtained from user.
   (2) Length and Witdth of room obtained from user.
   (3) Price per Square Yard obtained from user.
   (3) A constant for the Sales Tax
   (4) Calculated amounts for area in Square Feet and Square Yards
   (5) Calculated Material Cost
   (6) Calculated Sales Tax
   (7) Calculated Total Cost
   (8) Calculated Budget difference
   (9) Display all results
    
   Algorithm:
   (1) Define environment
   (2) Initialize Variables for budget, tax, L, W, Cost
   (3) Prompt for Budget amount and validate input using method
   (4) Prompt for Room Length and validate input using method
   (5) Prompt for Room Width and validate input using method
   (6) Prompt for flooring cost and validate input using method
   (7) Calculate area, Material Cost, Sales Tax, Total, and Budget Difference
   (8) Display inputs and calculations results
   (9) Determine if over/under budget and display answer and difference
   */

  // Define environment
  using System;
  namespace CostCalculator
{
  class Program
  {
 
 static double ValidateDbl(string tempInpStr)
        {
        string str = tempInpStr;
        
          int number;
          // TryParse returns a Boolean value. True if the conversion was successful, False otherwise.
          bool success = int.TryParse(str, out number);
  
          if (success)
          {
             Console.WriteLine("The string was successfully converted to the integer .", str, number);
          }
         else
         {
              Console.WriteLine("The string could not be converted to an integer.", str);
        }
        }
 /*
   static double ValidateFloat(string tempInpStr)
   {
    double tempInpDbl;
    Console.WriteLine("In ValidateFloat with input of --" + tempInpStr + "--");
    while (!double.TryParse(tempInpStr, out x ))
    { Console.WriteLine("This is not a valid number, try again please.");
      tempInpStr = Console.ReadLine();
      double x = tempInpStr;
        }
      //  tempInpDbl = tempInpStr;
    //tempInpDbl =  Convert.ToDouble(tempInpStr) ;
    Console.WriteLine("before leaving method" + tempInpStr) ;
   }

   */
   static void Main(string[] args)
   {
 
    // Set a constant sales tax rate and initialize input variables below validaion threshold
       const double TaxRate = .065;                                                                                 
       double myBudget = -1, LengthInFt = -1, WidthInFt = -1, CostPerYd = -1;
       string tempInpStr;
       //float tempInpFloat
    // Prompt for Budget amount
       Console.WriteLine("Enter your flooring Budget amount in dollars:");
       tempInpStr = Console.ReadLine();
       //ValidateFloat(tempInpStr);
       ValidateDbl(tempInpStr);
      // myBudget = Convert.ToDouble(tempInpStr);
      myBudget = 2222;
    //  Console.WriteLine("came back with " + tempInpDbl);

       while (myBudget < 1)

    // validate that Budget amount is at least $1
         {
          Console.WriteLine("Your Budget can't be less than $1.00! Input your bugdget amount again please.");
  
          myBudget = Convert.ToDouble(Console.ReadLine());

         }

    // Prompt for Room Length amount  
       Console.WriteLine("Enter Room Length in Feet:");
       LengthInFt = Convert.ToDouble(Console.ReadLine());  

    // validate that length is at least 1 ft                                                            
         while (LengthInFt<1)                                                                                     
         {
          Console.WriteLine("Length can't be less than 1 foot! Input your length again please.");
          LengthInFt = Convert.ToDouble(Console.ReadLine());
         }

    // Prompt for Room Width amount
       Console.WriteLine("Enter Room Width in Feet:");
       WidthInFt = Convert.ToDouble(Console.ReadLine());

    // validate that width is at least 1 ft   
         while (WidthInFt<1)
         {
          Console.WriteLine("Width can't be less than 1 foot! Input your width again please.");
          WidthInFt = Convert.ToDouble(Console.ReadLine());
         }
              
    // prompt flooring Cost per Sq.Yard
       Console.WriteLine("Enter Flooring price per Square Yard:");                                                         
       CostPerYd = Convert.ToDouble(Console.ReadLine());

    // validate that price per sq yd is greater than $0   
         while (CostPerYd<0)                                                                                        
         {
          Console.WriteLine("The cost must be more than $0.00! Input your cost again please.");
          CostPerYd = Convert.ToDouble(Console.ReadLine());
         }

    // Initialize output variables as 0   
        double areaSqFt = 0.00, areaSqYards = 0.00, materialCost = 0.00
            , salesTax = 0.00, totalCost = 0.00,   budgetDiff = 0.00;
       
    // Calculate area in ft and yards, Material Cost, Sales Tax, Total, and Budget Difference
       areaSqFt = LengthInFt * WidthInFt;
       areaSqYards = (LengthInFt/3) * (WidthInFt/3); 
       materialCost = (areaSqYards * CostPerYd);
       salesTax = materialCost * TaxRate ;
       totalCost =  materialCost + salesTax;
       budgetDiff = Math.Abs(myBudget - totalCost);        

    // Display inputs and calculation results
    // Show what was input
       Console.WriteLine("You input a Length of " + LengthInFt + " feet and a Width of " 
        + WidthInFt + " feet at a cost of $" + CostPerYd + " per Yd.");                                             
     
    // display the rounded "approx area" results as Square Yds
       Console.WriteLine("The result is an \"Approximate Area\" of " + Math.Round(areaSqFt) 
         + " Sq.Ft. or " + Math.Round(areaSqYards) + " Sq.Yds.");                                                     
                                                                                                                    
    // display Calculated material, tax, and total costs 
        Console.WriteLine("This flooring will cost you " + ($"{materialCost:C2}")); 
        Console.WriteLine("This sales tax will cost you " + ($"{salesTax:C2}")); 
        Console.WriteLine("Your Total Cost will be " + ($"{totalCost:C2}")); 

    // Determine if over/under budget and display that plus amoun of difference    
        if (totalCost > myBudget)
          {
           Console.WriteLine("You are OVER your budget of " + ($"{myBudget:C2}") +  " by " + ($"{budgetDiff:C2}") );
          }
       else 
          { 
           Console.WriteLine("You are UNDER your budget of " + ($"{myBudget:C2}") +  " by " + ($"{budgetDiff:C2}") );
          }
    }
  }
}
 
