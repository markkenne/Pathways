/* Customer Mgmt - a Costco like scenario
   Programmer: Mark Kenne
   First - Last Update:  08/14/2023 - 8/17/2023
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
   
Algorithm:
  (1) Create an Membership.cs class file with namepace of CustomerMgmt
    (1a) Create 4 properties using the get-set automatic method
     (1a1) MembershipID - to hold membership ID, must be a unique string - PK
     (1a2) Contact - string to hold Member email addr
     (1a3) AnnualCost - double to hold annual membership cost
     (1a4) CurrentMonthlyPurchases - double to hold current monthly purchas total
    (1b) Create construct for default, no value passed
    (1c) Create construct for 2 string, 2 double (membershipID, Contact, AnnualCost, CurrentMonthlyPurchases)
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
  (11)  Create Admin process R and Transaction (Trx) L for a list display 
   (11a) use a foreach loop to cycle once through list
   (11b) do a console  wrile line to put the toString values up for each
   (11c) Write the GetReward value and the GetSpecial for each row
  (12) Create the Create Membership routine in the C case of Admin
  (13) Create the Delete Membership routine in the D case of Admin
  (14) Create the Update Membership routine in the U case of Admin
  (15) Create the Return routine in the T case of Trx
  (16) Create the Purchase routine in the P case of Trx
  (17) Create the Apply Cashback routine in the A case of Trx
  (18) Create a two-tiered cashback for Executive
  (19) Create the Military Education Flag and cashback routines 
  */ // end of comments section

using System;
using System.Collections.Generic;   // needed for Lists
using System.ComponentModel.DataAnnotations;
using System.Xml;

namespace CustomerMgmt
{
  class Program
  {
    static void Main(string[] args)
    {
   // Initialize constants for Annual Fees
      const int aCostReg = 120;  // Regular
      const int aCostExe = 200;  // Executive
      const int aCostCor = 3000; // Corporation
      const int aCostNP  = 60;   // Non-Profit

   // Initialize Lists used in Main
   // Create a list of Membership
      List<Membership> membershipList = new List<Membership>();
   // Add membershipList data using new method to have some test data 
      membershipList.Add(new Regular  ("M001", "R", "mkenne00@lincoln.gov",  100, 111.30));
      membershipList.Add(new Regular  ("M002", "R", "tblinker@lincoln.gov",  100, 222.04));
      membershipList.Add(new Executive("M003", "E", "ablanker@lincoln.gov",  200, 2000.00));
      membershipList.Add(new Executive("M004", "E", "reddward@lincoln.gov",  200, 3000.00));       
      membershipList.Add(new NonProfit("M005", "N", "rinfield@college.edu",   60, 1000.00, "Y"));
      membershipList.Add(new NonProfit("M006", "N", "fbanks@nonprofit.net",   60, 1000.00, "N"));
      membershipList.Add(new Corporate("M007", "C", "monybags@corprus.com", 3000, 2000.00));
      membershipList.Add(new Corporate("M008", "C", "bigbucks@bigcorp.com", 3000, 1000.00));           
   // Create the menus as lists, starting with Main
      List<string> menuOptionsMain = new List<string>();
      menuOptionsMain.Add("A - Admin Menu");
      menuOptionsMain.Add("T - Transaction Menu for Members");
      menuOptionsMain.Add("Q - Quit");
   // Choices for Admin
      List<string> menuOptionsAdmin = new List<string>();
      menuOptionsAdmin.Add("C - Create a new Membership");
      menuOptionsAdmin.Add("R - Read all Memberships");
      menuOptionsAdmin.Add("U - Update an Existing Membership");
      menuOptionsAdmin.Add("D - Delete an Existing Membership");       
      menuOptionsAdmin.Add("X - eXit to Main Menu");
   // Choices for Members
      List<string> menuOptionsTrx = new List<string>();
      menuOptionsTrx.Add("L - List all membership with all info");
      menuOptionsTrx.Add("P - Purchase Transaction Entry");
      menuOptionsTrx.Add("T - Transact a Return");
      menuOptionsTrx.Add("A - Apply Cash Back Rewards");       
      menuOptionsTrx.Add("X - eXit to Main Menu");
   
   // Start the main menu loop 
      bool isMainMenuLooping = true; // looping flag
while (isMainMenuLooping)    // loop until (Q)uit
 {
    Console.WriteLine();
    Console.WriteLine("MAIN MENU - Please select an option:");
    Console.WriteLine();
    foreach (var option in menuOptionsMain) // display the main menu options from list
    {
     Console.WriteLine(option);
    }
    string? mainmenuchoice = Console.ReadLine();
    // Console.WriteLine(menuchoice);
    string? mainmenuchoiceUp = mainmenuchoice!.ToUpper();
    // direct the program to the menu choice using switch/case

// use switch-case to control program flow
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
                  // debug use  Console.WriteLine("In the Admin Create area");
                  // create variables
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

                          Console.WriteLine("Please enter a contact Email address: ");
                          string? newContact = Console.ReadLine() + " ";
                          // prompt for a membership type
                          Console.WriteLine("Please enter a Membership Type from these choices: ");
                          Console.WriteLine("R) Regular");
                          Console.WriteLine("E) Executive");
                          Console.WriteLine("N) Non-Profit");
                          Console.WriteLine("C) Corporation");
                          string? newTypeAnyCase = Console.ReadLine(); //input string for Membership type
                          string newType = newTypeAnyCase!.ToUpper(); //convert Membership type to uppercase
                          // make sure Type is one of the valid types
                          string x = newType;
                          string[] strings = { "R", "E", "N", "C" };
                          bool isInTuple = strings.Any(s => s.Equals(x));
                          if (isInTuple == false)
                          { 
                            Console.WriteLine("That is not a valid choice for Membership Type. Please try again");
                            break;    
                            }

                        double newAnnualCost = 0;
                        // set costs from constants
                        if (newType == "R")  // Regular
                         {
                          newAnnualCost =  aCostReg;
                         }
                        else if (newType == "E") // Executive
                         {
                          newAnnualCost =  aCostExe;
                         }
                        else if (newType == "C") // Corporation
                         {
                          newAnnualCost =  aCostCor;
                         }
                        else if (newType == "N") //Non-Profit, ask for military or educational
                         {
                          newAnnualCost =  aCostNP;
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
                        // prompt for starting balance
                        Console.Write("Please enter a Starting Purchase Balance: ");
                        double newCurrentMonthlyPurchases = Convert.ToDouble(Console.ReadLine());

                        // Create a new list item based on Memnership Type
                        if (newType == "R") 
                        {
                        membershipList.Add(new Regular(newMembershipID, newType, newContact, newAnnualCost, newCurrentMonthlyPurchases));
                         Console.WriteLine("Added new Regular Membership for: " + newMembershipID);
                        }
                        // Create a new list item based on Memnership Type
                        if (newType == "E") 
                        {
                        membershipList.Add(new Executive(newMembershipID, newType, newContact, newAnnualCost, newCurrentMonthlyPurchases));
                         Console.WriteLine("Added new Executive Membership for: " + newMembershipID);
                        }
                        if (newType == "C") 
                        {
                        membershipList.Add(new Corporate(newMembershipID, newType, newContact, newAnnualCost, newCurrentMonthlyPurchases));
                         Console.WriteLine("Added new Corporate Membership for: " + newMembershipID);
                        }
                        if (newType == "N") 
                        {
                        membershipList.Add(new NonProfit(newMembershipID, newType, newContact, newAnnualCost, newCurrentMonthlyPurchases, newMilEdu));
                         Console.WriteLine("Added new Non-Profit Membership for: " + newMembershipID);
                         Console.WriteLine("newMilEdu was set to" + newMilEdu);
                        }

                       } // end of not found so create loop
                    break; // end of Create
       
        case "R": // ADMIN RRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
                  // Read the List as Admin.
                     Console.WriteLine("Membership List:");
                  // Print the memberships in the list
                     foreach (Membership aMember in membershipList)
                     {
                      Console.Write(aMember);
                      // Console.Write(" | Cashback Rewards Value: $" + aMember.GetReward());
                      Console.Write(" | Cashback Rewards Value: " + ($"{aMember.GetReward():C2}"));
                      Console.WriteLine(" | Special Offers: $" + aMember.GetSpecials());
                     }  // end foreach 
                     break;

        case "U": // ADMIN UUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUUU
                  // Update the Membership as Admin.
                     Console.WriteLine("In the Admin Update area");
                     bool updatefound = false;   // set a variable to change to true on found ID
                     string? findUpdateID = ""; // set an input variable to empty
                     int updateRow = 0; 
                  // show a list to make updating easier
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
                        // input email addr from user if changes needed
                        Console.WriteLine();
                        Console.WriteLine("Please enter a contact Email address or 'Enter' to keep current email: " + membershipList[updateRow].contact);
                        
                        string? updateContact = Console.ReadLine() + " ";
                        if (updateContact==" ") 
                        {
                         updateContact = membershipList[updateRow].contact;
                        }
                        Console.WriteLine(updateContact);
                     // save email update to list
                        string? uContact = updateContact + " ";
                        membershipList[updateRow].contact = uContact;
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
                     // save type update to list
                        membershipList[updateRow].type = updateType;
                        Console.WriteLine();
                     // initialize an annual cost variable
                        double updateAnnualCost = 0;
                     // set costs using constants 
                        if (updateType == "R") // Regular
                         {
                          updateAnnualCost =  aCostReg;
                         }
                        else if (updateType == "E") // Executive
                         {
                          updateAnnualCost =  aCostExe;
                         }
                        else if (updateType == "C") // Corporation
                         {
                          updateAnnualCost =  aCostCor;
                         }
                        else if (updateType == "N") // Non-Profit, ask for military or educational
                         {
                          updateAnnualCost =  aCostNP;
                     // note: Military or Educational are not going to change, right Air Force now doing commercial flights...                          
                     // so no point in changing flag
                         }   
                        // save annual cost updates to list
                        membershipList[updateRow].annualCost = updateAnnualCost;
                        double updateCurrentMonthlyPurchases = 0;
                     // Prompt to change balance if needed   
                        Console.WriteLine("Please enter a Current Purchase Balance or 'Enter' to keep: " + membershipList[updateRow].currentMonthlyPurchases);
                     // get balance string  
                        string? cpBal = Console.ReadLine();
                        if (cpBal=="")
                         {
                          updateCurrentMonthlyPurchases = membershipList[updateRow].currentMonthlyPurchases;  
                         }
                        if (cpBal!="") // if you have something...
                         {
                          updateCurrentMonthlyPurchases = Convert.ToDouble(cpBal); // convert to double from string
                         }
                     // for debug Console.WriteLine(updateCurrentMonthlyPurchases);
                     // save cmp update to list
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
                         Console.WriteLine(findUpdateID + " was not found. Please Try again."); // message when not found
                         break;
                        }
                    break; // end of Create
        
        case "D": // ADMIN DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD
                  // Delete a membership as Admin.
                  // Find a Membership to delete in the list
                     bool found = false;   // set a variable to change to true on found ID
                     string? findID = "";  // set an input variable to empty
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
                        } //end of membership found
                    } // end for loop  
                    // add a console message before leaving
                    if (found)
                        { 
                         Console.WriteLine(findID + " was DELETED."); // message about delete
                        }
                    else
                        {
                         Console.WriteLine("Nothing got deleted. Try again."); // or not deleted
                        }
                    break; // end of Delete
        
        case "X": // ADMIN XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                 // Quit the Admin menu.
                 // debug use  Console.WriteLine("In the eXit area");
                     isAdminMenuLooping = false; // user chose X so quit the looping Admin menu
                     Console.WriteLine("You chose eXit. back to Main...");
                     break;
        default:
                 // Invalid option. Loop to Admin menu choices.
                    Console.WriteLine("Invalid Option. Please try again.");
                    break;
        }     // end admin menu switch
      }   // end admin menu while
   // end main menu switch
      break;
    
    case "T":  // MAIN TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
   // View the Transaction menu
      Console.WriteLine("In the Member Transaction area");
      bool isTrxMenuLooping = true; // flag to use when looping
      while (isTrxMenuLooping)  // loop the transaction menu until eXit is used
      {
                    Console.WriteLine();
                    Console.WriteLine("TRANSACTION MENU - Please select an option:");
                    foreach (var Trxoption in menuOptionsTrx) // get the list of transaction options from list
                    {
                    Console.WriteLine(Trxoption); // print options to screen
                    }
                    string? trxmenuchoice = Console.ReadLine();
                    //  debug use Console.WriteLine(Adminmenuchoice);
                    string? Trxmenuchoice = trxmenuchoice!.ToUpper(); // set a variable to capture choice and UPPERCASE it to simplify use
   
   // use switch-case to operate from the menu choices
      switch (Trxmenuchoice) //  TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU_TRX_MENU 
        {
        case "L": // TRX LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL
                  // L - List all membership with all info
                  // Read the List as Admin.
                     Console.WriteLine("Membership List:");
                  // Print the memberships in the list
                     foreach (Membership aMember in membershipList)
                     {
                      Console.Write(aMember);
                      Console.Write(" | Cashback Rewards Value: " + ($"{aMember.GetReward():C2}")); // show rewards values
                      Console.WriteLine(" | Special Offers: $" + aMember.GetSpecials()); // show special offers
                     }  // end foreach  
         break;  //end TRX L
        
        case "P": // TRX PPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPPP
                  // P - Perform Purchase Transaction
                  // debug use Console.WriteLine("In the Trx Purchase area");
  {
                     Console.WriteLine("Welcome to Customer Service - PURCHASES"); // let user know where they are
                     Console.WriteLine();   

                  // Find an Membership ID  in the list
                     bool purIDFound = false;   // set a variable to change to true on found ID
                     Console.Write("Please enter a valid Membership ID: ");
                     string? purFindID = Console.ReadLine(); // set an input variable and get MembershipID

                    // linear search thru the membership list
                    int purRow = 0;
                    for (int index = 0; index < membershipList.Count; index++)
                    {
                       if (membershipList[index].membershipID == purFindID) // we found a ID matching input
                        {
                           purIDFound = true; // used for message below
                           purRow = index; // a variable that makes choices easier than index :}
                        }
                    }
                    if (purIDFound!=true)  // no account matches input, so let user know
                     {
                      Console.WriteLine("Membership ID was not found.");
                      Console.WriteLine();
                     }
        
                    if (purIDFound==true)  // found a user. lets buy something!
                     {
                  // find out how much to spend
                     string? purAmt = "0"; // string variable for deposit input 
                     double newpurAmt = 0; // variable to hold Purchase amount
               
                     Console.WriteLine("Please enter a Purchase Amount: "); // user prompt
                     purAmt = Console.ReadLine(); // user inputs an amount as string
                     newpurAmt = Convert.ToDouble(purAmt); // convert string to double
                     if (newpurAmt < 0) // amount must be greater than 0 or transaction is cancelled w a message
                     { 
                        Console.WriteLine ("The amount must be more than 0. Transaction Cancelled.");
                        break;
                     }
                     // double check the input
                     Console.WriteLine("You entered: " + newpurAmt + "  Is that correct?: ") ;
                     string? purchaseYN = "n";  // yes/no variable for check
                     purchaseYN = Console.ReadLine(); // set variable to input
                     if (purchaseYN == "y"|| purchaseYN=="Y") // treat anything but y or Y as a no 
                         {
                          membershipList[purRow].Purchase(newpurAmt); // make the Purchase by changing the membershiplist using Purchase method
                          Console.WriteLine("Purchase of " + newpurAmt + " made to " + purFindID) ;
                         }
                     else
                     {
                      Console.WriteLine("Purchase cancelled.") ;  
                     }
                      Console.WriteLine();
                   }  // end valid memberid
        } // end case P

         break; // end of Purchases
        
        case "T": // TRX TTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTTT
                  // T - Perform Return Transaction
                  // Console.WriteLine("In the Trx Update area");
  {
                     Console.WriteLine("Welcome to Customer Service - RETURNS"); // let user know where they are
                     Console.WriteLine();   

                  // Find an Membership ID  in the list
                     bool retIDFound = false;   // set a variable to change to true on found ID

                     Console.Write("Please enter a valid Membership ID: ");
                     string? retFindID = Console.ReadLine(); // set an input variable and get MembershipID

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
                     retAmt = Console.ReadLine();  // variable to hold return amount as string
                     newRetAmt = Convert.ToDouble(retAmt);  // variable to hold return amount as double

                     if (newRetAmt < 0) // amount must be greater than 0 or transaction is cancelled w a message
                     { 
                        Console.WriteLine ("The amount must be more than 0. Transaction Cancelled.");
                        break;
                     }
                     // double check amount before proceding
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
              }  // end of valid memberid
          } //end T case
         break; // end of returns
        
        case "A": // TRX AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA
                  // A - Apply Cash Back Rewards
                  // debug use Console.WriteLine("In the Trx Cashback area");
         {
                     Console.WriteLine("Welcome to Customer Service - CASHBACK REWARDS!"); // let user know where they are
                     Console.WriteLine();   

                  // Find an Membership ID  in the list
                     bool cashbackIDFound = false;   // set a variable to change to true on found ID
                     Console.Write("Please enter a valid Membership ID: ");
                     string? cashbackFindID = Console.ReadLine(); //set an input variable and get the MemberID

                  // linear search thru the membership list
                    int cashbackRow = 0;
                    for (int index = 0; index < membershipList.Count; index++)
                    {
                       if (membershipList[index].membershipID == cashbackFindID) // we found a ID matching input
                        {
                           cashbackIDFound = true; // used for message below
                           cashbackRow = index; // less confusing than index :}
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
                     double newcashbackAmt = 0; // variable to hold cashback amount

                     Console.WriteLine("Would you like to redeem your cashback reward? y/n:") ; // prompt user
                 
                     string? cashbackYN = "n";  // yes/no variable for check
                     cashbackYN = Console.ReadLine(); // set variable to input
                     if (cashbackYN == "y"|| cashbackYN=="Y") // treat anything but y or Y as a no 
                         {
                        newcashbackAmt =  membershipList[cashbackRow].GetReward(); // get the cashback reward to use in output message
                        // let user know that transaction was processed

                        if (newcashbackAmt > 0)
                        {
                        Console.WriteLine("Cash-back reward request for membership " + cashbackFindID  + " in the amount of " + ($"{newcashbackAmt:C2}") +" has been made." ) ;

                        // now zero the currentMonthlyPurchases ######################################################################
                        membershipList[cashbackRow].currentMonthlyPurchases = 0;
                        }
                        else
                        {
                           Console.WriteLine("No cashback amount exists. Action cancelled.");
                        }
                         }
                     else
                     {
                       Console.WriteLine("cashback cancelled.") ;  
                     }
                     
                     Console.WriteLine();
             }  //end found loop
         } // end case A

         break; // end of cashbacks
        
        case "X": // TRX XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX
                  // Quit the Admin menu.
                  // debug use Console.WriteLine("In the Trx eXit area");
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
    // debug use  Console.WriteLine("In the Q/q area");
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