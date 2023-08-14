/* Customer Mgmt - a Costco like scenario
   Programmer: Mark Kenne
   First - Last Update:  08/14/2023
   Program Description -  End-of-stage competency challenge.
  
   Requirements:                      
  (1) An list of Customer Details in an abstract Class called Membership 
  (2) Membership List holds values of 
     (2a) Membership ID (unique string as PK) 
     (2b) Contact Email as string
     (2c) Annual Cost in dollars as double
     (2d) Current Monthly Purchases in dollars as double
  (3) Constructors to display the values above
  (4) A purchase method 
  (5) A return method
  (6) A cashback reward method (print information and zero Cashback amount)

  (3) Ability to calculate the annual bonus based on the Type. If H then 80 hours times rate, if Salary then 10% of salary amount
  (4) Ability to print the hourly rate or salary amount with bonus using the ToString method
  (5) A menu to operate the CRUD method (Create, Read, Update, and Delete) in regards to the array.
  (6) A menu item Q to exit the program
  (7) A procedure to Create a new row in the array
  (8) A procedure to Read all rows in the array and print them without showing null rows
  (9) A procedure to Update a row in the array
  (10) A procedure to Delete a row in the array



Algorithm:
  (1) Create an Membership.cs class file with namepace of CustomerMgmt
    (1a) Create 4 properties using the get-set automatic method
     (1a1) MembershipID - to hold membership ID, must be a unique string - PK
     (1a2) ContactEmail - string to hold Member email addr
     (1a3) AnnualCost - double to hold annual membership cost
     (1a4) CurrentMonthlyPurchases - double to hold current monthly purchas total
    (1b) Create construct for default, no value passed
    (1c) Create construct for 2 string, 2 double (membershipID, ContactEmail, AnnualCost, CurrentMonthlyPurchases)
    (1d) Ctrate a toString to dislplay the values when used
  (2) In Program.cs, test the Membership Class and construct objects by doing some basic set-up:
   (2a) Create a staic void Main section in Class Program
   (2b) Initialize a list for use to hold the data (as membershipList)
  (3) Create a Child membership class called Regular for regular members
   (3a) Create a constructor to pull Membership detail
   (3b) Create a list reader for Regular using constructor
   (3c) Create test rows in main and test Regular Class in print to screen
  (4) Create a Child membership class called Executive
   (4a) Create a constructor to pull Membership detail
   (4a) Create a list reader for Executive using constructor
   (4b) Create test rows in main and test Executive Class in print to screen
  (5) Create a Child membership class called NonProfit
   (5a) Create a constructor to pull NonProfit Membership detail
   (5a) Create a list reader for NonProfit using constructor
   (5b) Create test rows in main and test NonProfit Class in print to screen
  (6) Create a Child membership class called Corporate
   (6a) Create a constructor to pull Corporate Membership detail
   (6a) Create a list reader for Corporate using constructor
   (6b) Create test rows in main and test Corporate Class in print to screen   


  */ // end of comments section

using System;
using System.Collections.Generic;   // needed for Lists

namespace CustomerMgmt
{
  class Program
  {
    static void Main(string[] args)
    {
        // Initialize Lists
        // Create a list of Membership
        List<Membership> membershipList = new List<Membership>();
      // Add a Regular to test 
       membershipList.Add(new Regular("M001", "R", "mkenne00@lincoln.ne.gov.", 100, 111.00));
       membershipList.Add(new Regular("M002", "R", "tblinker@lincoln.ne.gov.", 100, 222.00));
       membershipList.Add(new Executive("M003", "E", "ablanker@lincoln.ne.gov.", 100, 3333.00));
       membershipList.Add(new Executive("M004", "E", "reddward@lincoln.ne.gov.", 100, 4444.00));       

       


     // Print the memberships in the list
        foreach (Membership aMember in membershipList)
           {
              Console.WriteLine(aMember);
            }  // end foreach  




    }   // end Main area
  }  // end class Program
} //end namespace