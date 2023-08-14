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
   (2c) Create a couple rows of test data for membership and make sure they dont work (abstract)
  (3) Create a Child membership class called Regular for regular members

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
    // Add a Membership to test default
      // membershipList.Add (new Membership()); nope this is abstract
       membershipList.Add(new Regular("M001", "mkenne@lincoln.ne.gov.", 100, 2255.00));
       membershipList.Add(new Regular("M002", "tblinker@lincoln.ne.gov.", 100, 255.00));

       


        // Create a list of CustomerMgmt
      //  List<HourlyEmployee> hourlyEmployeeList = new List<HourlyEmployee>();  
        // And, create a list of Salary Employees
        //List<SalaryEmployee> salaryEmployeeList = new List<SalaryEmployee>();   
    

        // Print the membership in the list
        foreach (Regular aMember in membershipList)
            {
                Console.WriteLine(aMember);
            }  // end foreach  




    } // end Main area
  }   // end class Program
} //end namespace