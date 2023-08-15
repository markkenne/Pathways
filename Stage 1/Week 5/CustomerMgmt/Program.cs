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
  (7) Menus for both Admin and Transaction Use driven by Main menu choice
    (7a) An option to Quit from this menu.
  (8) Admin menu needs these options:
   (8a) C - Create a new membership as Admin.
      (8a1) Validation to prevent duplicate IDs
   (8b) R - Print the memberships in the list to screen
   (8c) U - Update the Membership details
   (8d) D - Delete a membership
   (8e) X - eXit to main menu 
  (9) Transaction menu needs these options:
   (9a) L - List all membership with all info
   (9b) P - Perform Purchase Transaction
     (9b1) amount of the purchase must be > 0
     (9b2) must be valid ID for purchase
     (9b3) current monthly purchases increases by purchase amount
   (9c) T - Perform Return Transaction
     (9c1) amount of the purchase returned must be > 0
     (9c2) must be valid ID for purchase
     (9c3) current monthly purchases decreases by purchase return amount
   (9d) A - Apply Cash Back Rewards
     (9d1) Must input a valid ID
     (9d2) Passes request to rewards system
        (9d2a) Console message "Cash-back reward request for membership xxxxxx in the amount of $yyyy has been made."
        (9d2b) Zero the (monthly purchases spending amount) balance
   (9e) X - eXit to main menu 
   
  
  

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
  (7) Create a two-tiered menu with a Quit option. Each tier is another menu
    (7a) A = Administration with CRUDQ for memberships
    (7b) T = Transaction with LPTAQ
    (7c) Q = Quit
  (8) Create menuOptionsMain List for items in 7 above
  (9) Create menuOptionsAdmin for use in A with these options:
   (9a) C - Create a new Membership
   (9b) R - Read all Memberships
   (9c) U - Update an Exiting Membership
   (9d) D - Delete and Existing Membership
   (9e) X - eXit to Main Menu
  (10) Create menuOptionsAdmin for use in A with these options:
   (10a) L - List all membership with all info
   (10b) P - Perform Purchase Transaction
   (10c) T - Perform Return Transaction
   (10d) A - Apply Cash Back Rewards
   (10e) X - eXit to Main Menu   
  (11)  Create Admin process C for a new user 

  */ // end of comments section

using System;
using System.Collections.Generic;   // needed for Lists
using System.Data;
using System.IO;
using System.Net;
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
       membershipList.Add(new NonProfit("M005", "N", "mbanks@nonprofit.net", 60, 5555.00, "Y"));
       membershipList.Add(new NonProfit("M006", "N", "rfields@nonprofit.net", 60, 6666.00, "N"));
       membershipList.Add(new Corporate("M007", "C", "mbags@corprus.com", 3000, 7777.00));
       membershipList.Add(new Corporate("M008", "C", "slimey@bigcorp.com", 3000, 8888.00));           
     // Create the menus as lists
       List<string> menuOptionsMain = new List<string>();
       menuOptionsMain.Add("A - Admin Menu");
       menuOptionsMain.Add("T - Member Transaction Menu");
       menuOptionsMain.Add("Q - Quit");
       //Choices for Admin
       List<string> menuOptionsAdmin = new List<string>();
       menuOptionsAdmin.Add("C - Create a new Membership");
       menuOptionsAdmin.Add("R - Read all Memberships");
       menuOptionsAdmin.Add("U - Update an Existing Membership");
       menuOptionsAdmin.Add("D - Delete an Existing Membership");       
       menuOptionsAdmin.Add("X - eXit to Main Menu");
       // Choices for Members
       List<string> menuOptionsTrx = new List<string>();
       menuOptionsTrx.Add("L - List all membership with all info");
       menuOptionsTrx.Add("P - Perform Purchase Transaction");
       menuOptionsTrx.Add("T - Perform Return Transaction");
       menuOptionsTrx.Add("A - Apply Cash Back Rewards");       
       menuOptionsTrx.Add("X - eXit to Main Menu");
   
bool isMainMenuLooping = true;

while (isMainMenuLooping)
 {
    Console.WriteLine();
    Console.WriteLine("MAIN MENU - Please select an option:");
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
    case "A":  // MAIN AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
    // View the Admin Menu
      // debug use Console.WriteLine("In the Admin area");
      bool isAdminMenuLooping = true;
      while (isAdminMenuLooping)
      {
                    Console.WriteLine();
                    Console.WriteLine("ADMIN MENU - Please select an option:");
                    foreach (var Adminoption in menuOptionsAdmin)
                    {
                    Console.WriteLine(Adminoption);
                    }
                    string? adminmenuchoice = Console.ReadLine();
                    // Console.WriteLine(Adminmenuchoice);
                    string? Adminmenuchoice = adminmenuchoice!.ToUpper();
                  
      
      switch (Adminmenuchoice)  // ADMINMENU_ADMINMENU_ADMINMENU_ADMINMENU_ADMINMENU_ADMINMENU_ADMINMENU_ADMINMENU_ADMINMENU_ADMINMENU_ADMINMENU
        {
        case "C": // ADMIN CCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCCC
                  // Create a new membership as Admin.
                     Console.WriteLine("In the Admin Create area");


   // Experiment with Creating (adding) an employee to the list
        //======================================================================
 // TODO for now, just manually enter an ID and validate it is not in use, later pick the next valid number automatically

                     bool newfound = false;   // set a variable to change to true on found ID
                     string? findNewID = ""; // set an input variable to empty
                     
                     // show a list to make deleting easier
                     foreach (Membership aMember in membershipList)
                     {
                      Console.WriteLine(aMember);
                     }
                    Console.WriteLine();
                    Console.Write("Please enter a unique Membership ID to ADD: "); //prompt for ID
                    findNewID = Console.ReadLine(); // set findNewID to input
                    if (findNewID == null) 
                       { 
                        findNewID = "Nothing Entered Here";
                       }
                    // linear search thru the membership list
                    for (int index = 0; index < membershipList.Count; index++)
                    {
                       if (membershipList[index].membershipID == findNewID) // we found a ID matching input
                        {
                           newfound = true; // used for message below
                        }
                    }
                     // end for loop  
                    if (newfound==true)
                        { 
                         Console.WriteLine(findNewID + " was already being used. Please Try again."); // message
                         break;
                        }
                    else
                        {
                        string newMembershipID = findNewID;
                        string newMilEdu = "N";
                        string? newContactEMail;
                        // prompt for an email addr
                        Console.Write("Please enter a contact Email address: ");
                        
                        newContactEMail = (Console.ReadLine());
                        if (newContactEMail=="") 
                        {
                            newContactEMail ="None Provided";
                        }
                        
                        // prompt for a membership type
                        Console.WriteLine("Please enter a Membership Type from these choices: ");
                        Console.WriteLine("R) Regular");
                        Console.WriteLine("E) Executive");
                        Console.WriteLine("N) Non-Profit");
                        Console.WriteLine("C) Corporation");
                        string? newTypeAnyCase = Console.ReadLine(); //input string for Membership type
                        string newType = newTypeAnyCase!.ToUpper(); //convert Membership type to uppercase
                        double newAnnualCost = 0;
                        if (newType == "R")
                         {
                          newAnnualCost =  120;
                         }
                        else if (newType == "E")
                         {
                          newAnnualCost =  200;
                         }
                        else if (newType == "C")
                         {
                          newAnnualCost =  3000;
                         }
                        else if (newType == "N") //ask for military or educational
                         {
                          newAnnualCost =  60;
                          Console.Write("Is this Non-Profit Military or Educational? y/n: ");
                          string? ynstring = "n";  // yes/no variable for check
                          // default to not being Mil or Ed
                          // move to higher context  string newMilEdu = "N";
                          
                          ynstring = Console.ReadLine(); // set variable to input
                          if (ynstring == "y"|| ynstring=="Y") // treat anything but y or Y as a no 
                           {
                            newMilEdu = "Y"; //used for cashback calculation of Non-Profit
                           }
                         }   

                        Console.Write("Please enter a Current Purchase Balance: ");
                        double newCurrentMonthlyPurchases = Convert.ToDouble(Console.ReadLine());

                        // Create a new list item based on Memnership Type
                        if (newType == "R") 
                        {
                        membershipList.Add(new Regular(newMembershipID, newType, newContactEMail, newAnnualCost, newCurrentMonthlyPurchases));
                         Console.WriteLine("Added new Regular Membership for: " + newMembershipID);
                        }
                        // Create a new list item based on Memnership Type
                        if (newType == "E") 
                        {
                        membershipList.Add(new Executive(newMembershipID, newType, newContactEMail, newAnnualCost, newCurrentMonthlyPurchases));
                         Console.WriteLine("Added new Executive Membership for: " + newMembershipID);
                        }
                        if (newType == "C") 
                        {
                        membershipList.Add(new Corporate(newMembershipID, newType, newContactEMail, newAnnualCost, newCurrentMonthlyPurchases));
                         Console.WriteLine("Added new Corporate Membership for: " + newMembershipID);
                        }
                        if (newType == "N") 
                        {
                        membershipList.Add(new NonProfit(newMembershipID, newType, newContactEMail, newAnnualCost, newCurrentMonthlyPurchases, newMilEdu));
                         Console.WriteLine("Added new Non-Profit Membership for: " + newMembershipID);
                        }

                       } // end of not found so create loop
                    break; // end of Create
       
        case "R": // ADMIN RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
                  // Read the List as Admin.
                     Console.WriteLine("Membership List:");
                  // Print the memberships in the list
                     foreach (Membership aMember in membershipList)
                     {
                      Console.WriteLine(aMember);
                     }  // end foreach  
                     break;

        case "U": // ADMIN UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU
                  // Update the Membership as Admin.
                     Console.WriteLine("In the Admin Update area");
                                     bool updatefound = false;   // set a variable to change to true on found ID
                     string? findUpdateID = ""; // set an input variable to empty
                     int updateRow = 0; 
                     // show a list to make deleting easier
                     foreach (Membership aMember in membershipList)
                     {
                      Console.WriteLine(aMember);
                     }
                    Console.WriteLine();
                    Console.Write("Please choose a Membership ID to Update: "); //prompt for ID
                    findUpdateID = Console.ReadLine(); // set findUpdateID to input
                    if (findUpdateID == null) 
                       { 
                        findUpdateID = "Nothing Entered Here";
                       }
                    // linear search thru the membership list
                    for (int index = 0; index < membershipList.Count; index++)
                    {
                       if (membershipList[index].membershipID == findUpdateID) // we found a ID matching input
                        {
                           updatefound = true; // used for message below
                           updateRow = index;
                        }
                    }
                     // end for loop  
                    if (updatefound==true)
                         {
                       // don't change ID  string newMembershipID = findUpdateID;
                        string updateMilEdu = "";
                        string? updateContactEMail = "";
                        // prompt for an email addr
                        // debug use Console.Write(membershipList[updateRow].contactEmail);
                        Console.WriteLine();
                        Console.WriteLine("Please enter a contact Email address or 'Enter' to keep current email: " + membershipList[updateRow].contactEmail);
                        
                        updateContactEMail = (Console.ReadLine());
                        if (updateContactEMail=="") 
                        {
                         updateContactEMail = membershipList[updateRow].contactEmail;
                        }
                        Console.WriteLine(updateContactEMail);
                       //save email update to list
                       membershipList[updateRow].contactEmail = updateContactEMail;
                       Console.WriteLine();
                        
                        Console.WriteLine();
                        // prompt for a membership type
                        Console.WriteLine("Please enter a Membership Type from these choices or 'Enter' to keep current: " + membershipList[updateRow].type);
                        Console.WriteLine("R) Regular");
                        Console.WriteLine("E) Executive");
                        Console.WriteLine("N) Non-Profit");
                        Console.WriteLine("C) Corporation");
                        string? updateTypeAnyCase = Console.ReadLine(); //input string for Membership type
                        string updateType = updateTypeAnyCase!.ToUpper(); //convert Membership type to uppercase
                        if (updateType=="") 
                        {
                            updateType = membershipList[updateRow].type;
                        }

                        Console.WriteLine(updateType);
                       //save type update to list
                       membershipList[updateRow].type = updateType;
                       Console.WriteLine();

                        double updateAnnualCost = 0;
                        if (updateType == "R")
                         {
                          updateAnnualCost =  120;
                         }
                        else if (updateType == "E")
                         {
                          updateAnnualCost =  200;
                         }
                        else if (updateType == "C")
                         {
                          updateAnnualCost =  3000;
                         }
                        else if (updateType == "N") //ask for military or educational
                         {
                          updateAnnualCost =  60;

                       /* removed this Military or Educational are not going to change, right Air Force now doing commercial flights...                          
                          Console.Write("Is this Non-Profit Military or Educational? y/n: ");
                          string? ynstring = "n";  // yes/no variable for check
                          // default to not being Mil or Ed
                          // move to higher context  string newMilEdu = "N";
                          
                          ynstring = Console.ReadLine(); // set variable to input
                          if (ynstring == "y"|| ynstring=="Y") // treat anything but y or Y as a no 
                           {
                            updateMilEdu = "Y"; //used for cashback calculation of Non-Profit
                           }
                           */
                         }   
                        // save annual cost updates to list
                        membershipList[updateRow].annualCost = updateAnnualCost;

                        double updateCurrentMonthlyPurchases = 0;
                        string cpBal = "";
                        Console.WriteLine("Please enter a Current Purchase Balance or 'Enter' to keep: " + membershipList[updateRow].currentMonthlyPurchases);
                       
                        cpBal = Console.ReadLine();
                        if (cpBal=="")
                         {
                          updateCurrentMonthlyPurchases = membershipList[updateRow].currentMonthlyPurchases;  
                         }
                        if (cpBal!="")
                         {
                          updateCurrentMonthlyPurchases = Convert.ToDouble(cpBal);
                         }
                        Console.WriteLine(updateCurrentMonthlyPurchases);
                        //save updates to list
                        membershipList[updateRow].currentMonthlyPurchases = updateCurrentMonthlyPurchases;
                        Console.WriteLine();
                        // show the list again
                         foreach (Membership aMember in membershipList)
                         {
                          Console.WriteLine(aMember);
                         }
                       } // end of not found so create loop
                    else  //
                                               { 
                         Console.WriteLine(findUpdateID + " was not found. Please Try again."); // message
                         break;
                        }
                    break; // end of Create
        
        case "D": // ADMIN DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
                  // Delete a membership as Admin.
                  // Find a Membership to delete in the list
                     bool found = false;   // set a variable to change to true on found ID
                     string? findID = ""; // set an input variable to empty
                     // show a list to make deleting easier
                     foreach (Membership aMember in membershipList)
                     {
                      Console.WriteLine(aMember);
                     }
                    Console.WriteLine();
                    Console.Write("Please enter a Membership ID to DELETE: "); //prompt for ID
                    findID = Console.ReadLine(); // set findID to input
                    // linear search thru the membership list
                    for (int index = 0; index < membershipList.Count; index++)
                    {
                       if (membershipList[index].membershipID == findID) // we found a ID matching input
                        {
                          // double check before delete
                          Console.WriteLine("Are you sure you want to DELETE " + findID + "? y/n");
                         string? stryn = "n";  // yes/no variable for check
                         stryn = Console.ReadLine(); // set variable to input
                        if (stryn == "y"|| stryn=="Y") // treat anything but y or Y as a no 
                         {
                           membershipList.RemoveAt(index); // remove that index# line from list
                           found = true; // used for message below
                         }
                        }
                    } // end for loop  
                    if (found)
                        { 
                         Console.WriteLine(findID + " was DELETED."); // message
                        }
                    else
                        {
                         Console.WriteLine("Nothing got deleted. Try again.");
                        }
                    break; // end of Delete
        
        case "X": // ADMIN XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
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
    
    case "T":  // MAIN TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
   // View the Transaction menu
      Console.WriteLine("In the Member Transaction area");
      bool isTrxMenuLooping = true;
      while (isTrxMenuLooping)
      {
                    Console.WriteLine();
                    Console.WriteLine("TRANSACTION MENU - Please select an option:");
                    foreach (var Trxoption in menuOptionsTrx)
                    {
                    Console.WriteLine(Trxoption);
                    }
                    string? trxmenuchoice = Console.ReadLine();
                    // Console.WriteLine(Adminmenuchoice);
                    string? Trxmenuchoice = trxmenuchoice!.ToUpper();
                  
      
      switch (Trxmenuchoice) //  TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU 
        {
        case "L": // TRX LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL
                  // L - List all membership with all info
                  // Read the List as Admin.
                     Console.WriteLine("Membership List:");
                  // Print the memberships in the list
                     foreach (Membership aMember in membershipList)
                     {
                      Console.WriteLine(aMember);
                     }  // end foreach  
                    
                     break;
        
        case "P": // TRX PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP
                  // P - Perform Purchase Transaction
                  // Console.WriteLine("In the Trx Purchase area");
  {
                     Console.WriteLine("Welcome to Customer Service - PURCHASES");
                     Console.WriteLine();   

                  // Find an Membership ID  in the list
                     bool purIDFound = false;   // set a variable to change to true on found ID
                     string  purFindID = ""; // set an input variable to empty

                     Console.Write("Please enter a valid Membership ID: ");
                     purFindID = (Console.ReadLine());

                    // linear search thru the membership list
                    int purRow = 0;
                    for (int index = 0; index < membershipList.Count; index++)
                    {
                       if (membershipList[index].membershipID == purFindID) // we found a ID matching input
                        {
                           purIDFound = true; // used for message below
                           purRow = index;
                        }
                    }
                    if (purIDFound!=true)  // no account matches input, so let user know
                     {
                      Console.WriteLine("Membership ID was not found.");
                      Console.WriteLine();
                     }
        
                    if (purIDFound==true)
                     {
                     // Now we have an Member ID, make a Purchase transaction here, find out how much
                     string? purAmt = "0"; // string variable for deposit input 
                     // That out of the way, get the amount and make a Purchase transaction here
                     double newpurAmt = 0; // variable to hold Purchase amount
               
                     Console.WriteLine("Please enter a Purchase Amount: ");
                     purAmt = Console.ReadLine();
                     newpurAmt = Convert.ToDouble(purAmt);
                     Console.WriteLine("You entered: " + newpurAmt + "  Is that correct?: ") ;
                 
                     string? purchaseYN = "n";  // yes/no variable for check
                     purchaseYN = Console.ReadLine(); // set variable to input
                     if (purchaseYN == "y"|| purchaseYN=="Y") // treat anything but y or Y as a no 
                         {
                          membershipList[purRow].Purchase(newpurAmt); // make the Purchase
                           Console.WriteLine("Purchase of " + newpurAmt + " made to " + purFindID) ;
                         }
                     else
                     {
                       Console.WriteLine("Purchase cancelled.") ;  
                     }
                     
                     Console.WriteLine();
             }  
        } //end found loop

                     break; // end of Purchases
        
        case "T": // TRX TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
                  // T - Perform Return Transaction
                  // Console.WriteLine("In the Trx Update area");
  {
                     Console.WriteLine("Welcome to Customer Service - RETURNS");
                     Console.WriteLine();   

                  // Find an Membership ID  in the list
                     bool retIDFound = false;   // set a variable to change to true on found ID
                     string  retFindID = ""; // set an input variable to empty

                     Console.Write("Please enter a valid Membership ID: ");
                     retFindID = (Console.ReadLine());

                    // linear search thru the membership list
                    int retRow = 0;
                    for (int index = 0; index < membershipList.Count; index++)
                    {
                       if (membershipList[index].membershipID == retFindID) // we found a ID matching input
                        {
                           retIDFound = true; // used for message below
                           retRow = index;
                        }
                    }
                    if (retIDFound!=true)  // no account matches input, so let user know
                     {
                      Console.WriteLine("Membership ID was not found.");
                      Console.WriteLine();
                     }
        
                    if (retIDFound==true)
                     {
                     // Now we have an Member ID, make a Return transaction here, find out how much
                     string? retAmt = "0"; // string variable for deposit input 
                     // That out of the way, get the amount and make a return transaction here
                     double newRetAmt = 0; // variable to hold return amount
               
                     Console.WriteLine("Please enter a Return Amount: ");
                     retAmt = Console.ReadLine();
                     newRetAmt = Convert.ToDouble(retAmt);
                     Console.WriteLine("You entered: " + newRetAmt + "  Is that correct?: ") ;
                 
                     string? returnYN = "n";  // yes/no variable for check
                     returnYN = Console.ReadLine(); // set variable to input
                     if (returnYN == "y"|| returnYN=="Y") // treat anything but y or Y as a no 
                         {
                          membershipList[retRow].Return(newRetAmt); // make the return
                           Console.WriteLine("RETURN of " + newRetAmt + " made to " + retFindID) ;
                         }
                     else
                     {
                       Console.WriteLine("RETURN cancelled.") ;  
                     }
                     
                     Console.WriteLine();
             }  
        } //end found loop

                     break; // end of returns
        
        case "A": // TODO TRX AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
                  // A - Apply Cash Back Rewards
                  // Console.WriteLine("In the Trx Cashback area");
  {
                     Console.WriteLine("Welcome to Customer Service - CASHBACK REWARDS!");
                     Console.WriteLine();   

                  // Find an Membership ID  in the list
                     bool cashbackIDFound = false;   // set a variable to change to true on found ID
                     string  cashbackFindID = ""; // set an input variable to empty

                     Console.Write("Please enter a valid Membership ID: ");
                     cashbackFindID = (Console.ReadLine());

                    // linear search thru the membership list
                    int cashbackRow = 0;
                    for (int index = 0; index < membershipList.Count; index++)
                    {
                       if (membershipList[index].membershipID == cashbackFindID) // we found a ID matching input
                        {
                           cashbackIDFound = true; // used for message below
                           cashbackRow = index;
                        }
                    }
                    if (cashbackIDFound!=true)  // no account matches input, so let user know
                     {
                      Console.WriteLine("Membership ID was not found.");
                      Console.WriteLine();
                     }
        
                    if (cashbackIDFound==true)
                     {
                     // Now we have an Member ID, make a cashback transaction here, find out how much
                     string? cashbackAmt = "0"; // string variable for deposit input 
                     // That out of the way, get the amount and make a cashback transaction here
                     double newcashbackAmt = 0; // variable to hold cashback amount
               
                 //    Console.WriteLine("Please enter a Cashback Amount to Redeem: ");
                 //    cashbackAmt = Console.ReadLine();
                 //    newcashbackAmt = Convert.ToDouble(cashbackAmt);
                     Console.WriteLine("Would you like to redeem your cashback reward? y/n:") ;
                 
                     string? cashbackYN = "n";  // yes/no variable for check
                     cashbackYN = Console.ReadLine(); // set variable to input
                     if (cashbackYN == "y"|| cashbackYN=="Y") // treat anything but y or Y as a no 
                         {
                        newcashbackAmt =  membershipList[cashbackRow].GetReward(); // make the cashback
                           Console.WriteLine("cashback of " + newcashbackAmt + " made to " + cashbackFindID) ;
                         }
                     else
                     {
                       Console.WriteLine("cashback cancelled.") ;  
                     }
                     
                     Console.WriteLine();
             }  
        } //end found loop

                     break; // end of cashbacks
        
        case "X": // TRX XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                  // Quit the Admin menu.
                  // Console.WriteLine("In the Trx eXit area");
                     isTrxMenuLooping = false; // user chose X so quit the looping Admin menu
                     Console.WriteLine("You chose eXit. back to Main...");
                     break;
        default:
                 // Invalid option. Loop to Admin menu choices.
                    Console.WriteLine("Invalid Option. Please try again.");
                    break;
        }        // end trx menu switch
      }        // end trx menu while
   // end main menu switch
      break;
    
    case "Q": // MAIN QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ
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