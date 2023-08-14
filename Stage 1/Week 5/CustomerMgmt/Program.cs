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
  (7) Create a two-tiered menu 
    (7a) Administration with CRUDQ for memberships
    (7b) User with LPTAQ



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
       membershipList.Add(new Regular("M001", "R", "mkenne00@lincoln.ne.gov", 100, 111.00));
       membershipList.Add(new Regular("M002", "R", "tblinker@lincoln.ne.gov", 100, 222.00));
       membershipList.Add(new Executive("M003", "E", "ablanker@lincoln.ne.gov", 200, 3333.00));
       membershipList.Add(new Executive("M004", "E", "reddward@lincoln.ne.gov", 200, 4444.00));       
       membershipList.Add(new NonProfit("M005", "N", "mbanks@nonprofit.net", 300, 5555.00));
       membershipList.Add(new NonProfit("M006", "N", "rfields@nonprofit.net", 300, 6666.00));
       membershipList.Add(new Corporate("M007", "C", "mbags@corprus.com", 400, 7777.00));
       membershipList.Add(new Corporate("M008", "C", "slimey@bigcorp.com", 400, 8888.00));           
     // Create the menus as lists
       List<string> menuOptionsMain = new List<string>();
       menuOptionsMain.Add("A - Admin Menu");
       menuOptionsMain.Add("M - Member Menu");
       menuOptionsMain.Add("Q - Quit");
       List<string> menuOptionsAdmin = new List<string>();
       menuOptionsAdmin.Add("C - Create a new Membership");
       menuOptionsAdmin.Add("R - Read all Memberships");
       menuOptionsAdmin.Add("U - Update an Exiting Membership");
       menuOptionsAdmin.Add("D - Delete and Existing Membership");       
       menuOptionsAdmin.Add("X - eXit to Main Menu");
       List<string> menuOptionsMember = new List<string>();
       menuOptionsMember.Add("A - Admin Menu");
       menuOptionsMember.Add("M - Member Menu");
       menuOptionsMember.Add("Q - Quit");
    
    
     // Print the memberships in the list
        foreach (Membership aMember in membershipList)
           {
              Console.WriteLine(aMember);
            }  // end foreach  


bool isMainMenuLooping = true;

while (isMainMenuLooping)
 {
    Console.WriteLine("Please select an option:");
    foreach (var option in menuOptionsMain)
    {
     Console.WriteLine(option);
    }
    string? mainmenuchoice = Console.ReadLine();
    // Console.WriteLine(menuchoice);
    string? mainmenuchoiceUp = mainmenuchoice!.ToUpper();
    // direct the program to the menu choice using switch/case

switch (mainmenuchoiceUp)
 {
    case "A":  // TODO AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // Create a new item.
    Console.WriteLine("In the Admin area");
      bool isAdminMenuLooping = true;
      while (isAdminMenuLooping)
      {
                    Console.WriteLine("Please select an Admin option:");
                    foreach (var Adminoption in menuOptionsAdmin)
                    {
                    Console.WriteLine(Adminoption);
                    }
                    string? adminmenuchoice = Console.ReadLine();
                    // Console.WriteLine(Adminmenuchoice);
                    string? Adminmenuchoice = adminmenuchoice!.ToUpper();
                  
      
      switch (Adminmenuchoice)
        {
        case "C": // TODO CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC
                  // Create a new membership as Admin.
                     Console.WriteLine("In the Admin Create area");
                     break;
        case "R": // TODO RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
                  // Read the List as Admin.
                     Console.WriteLine("In the Admin Read area");
                     break;
        case "U": // TODO UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU
                  // Update the Membership as Admin.
                     Console.WriteLine("In the Admin Update area");
                     break;
        case "D": // TODO DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
                  // Delete a membership as Admin.
                     Console.WriteLine("In the Admin Delete area");
                     break;
        case "X": // TODO XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                  // Quit the Admin menu.
                     Console.WriteLine("In the eXit area");
                     isAdminMenuLooping = false; // user chose X so quit the looping Admin menu
                     Console.WriteLine("You chose eXit. back to Main...");
                     break;
        default:
                 // Invalid option. Loop to Admin menu choices.
                    Console.WriteLine("Invalid Option. Please try again.");
                    break;
        }        // end admin menu switch
      }          // end admin menu while
   // end main menu switch
      break;
    
    case "M":  // TODO MMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMMM
    // Read an existing item.
    Console.WriteLine("In the Member area");
    break;
    case "Q": // TODO QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
    // Quit the application.
    //  Console.WriteLine("In the Q/q area");
    isMainMenuLooping = false; // user chose Q so quit the looping
    Console.WriteLine("You chose Quit. Good Bye...");
    break;
    default:
    // Invalid option. Loop to menu choices.
    Console.WriteLine("Invalid Option. Please try again.");
    break;
      
  } // end main menu switch
 } // end main menu while
    }   // end Main area
  }  // end class Program
} //end namespace