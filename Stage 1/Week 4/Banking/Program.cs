using System;
using System.Collections.Generic;   // needed for Lists

namespace BankApp
{
  class Program
  {
    static void Main(string[] args)
    {

        // Create a list of Accounts
        List<Account> accountsList = new List<Account>();
        
        // Add an Account or two...
        accountsList.Add(new Savings("MK002", "MK002S", "S", 5023.55));
        accountsList.Add(new Checking("MK002","MK002C", "C", 2532.22));
        accountsList.Add(new CD("MK002", "MK002CD", "CD", 12000.00));
        accountsList.Add(new Savings("MK003", "MK003S", "S", 2023.55));
        accountsList.Add(new Checking("MK003","MK003C", "C", 832.22));
        accountsList.Add(new CD("MK003", "MK003CD", "CD", 4202.90));        

        bool userChoice;
        string? userChoiceString = "X";


 // Repeat main loop
      do
      {

        // TODO: Get a valid input
            do
            {
                //  Initialize variables

                userChoice = false;

                //  TODO: Provide the user a menu of options

                Console.WriteLine("What is your Banking pleasure? ");
                Console.WriteLine("L: List all of the accounts.");
                Console.WriteLine("D: Make a Deposit Transaction.");
                Console.WriteLine("W: Make a Withdrawal Transaction.");
                Console.WriteLine("Q: Quit the program.");

                //  TODO: Get a user option (valid means its on the menu)

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
                            userChoiceString == "D" || userChoiceString == "d" ||                
                            userChoiceString == "W" || userChoiceString == "w" ||
                            userChoiceString == "Q" || userChoiceString == "q");

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }

            } while (!userChoice);

//  TODO: If the option is L or l then List all accounts  LLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLLL

            if (userChoiceString=="L" || userChoiceString=="l")
   {         
             Console.WriteLine("In the L/l area");


       // Print the list
       //double totBal = 0;
        foreach (Account anAccount in accountsList)
        {
            Console.Write(anAccount);
            Console.Write(" with Annual Interest of " + anAccount.GetInterest());
            Console.WriteLine(" with Early Withdrawal Penalty of " + anAccount.GetPenalty());

        //    totBal = totBal + anAccount.GetBalance();
         //   Console.WriteLine(totBal);
        }  // end foreach  
        //Console.WriteLine("Total Balance = $" + totBal);
   } // end of L area


//  TODO: Else if the option is a D or d then do a Deposit Transaction DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD

            else if (userChoiceString=="D" || userChoiceString=="d")
   {
                Console.WriteLine("Welcome to the Deposit Depot!");
                Console.WriteLine();


        // Find an Account in the list
        bool found = false;   // set a variable to change to true on found acct
        string? findAcct = ""; // set an input variable to empty
       
        Console.Write("Please enter an Account ID to access: ");
        findAcct = Console.ReadLine();
        Console.WriteLine(findAcct);
        foreach (Account anAccount in accountsList)
          {
           //  Console.WriteLine(anAccount.accountIDM);
             if (anAccount.accountIDM == findAcct)
              { found = true;
                // debug use Console.WriteLine("Name WAS found." + found);
              } //just set a found flag. do more later
          }  // end foreach  
        if (!(found))  // no account matches input, so let user know
          {
            Console.WriteLine("Name was not found.");
            Console.WriteLine();
          }

       if ((found))
         {
            Console.WriteLine();
             double totBal = 0;
            Console.WriteLine("The search was successful and revealed these Account details:"); // let user know account was found
          foreach (Account anAccount in accountsList)  //loop thru accounts
           {
            if (anAccount.accountIDM == findAcct) // that match input acct
             {             
               Console.WriteLine();
               Console.Write(anAccount); // print the tostrings
               Console.Write(" | Annual Interest: " + anAccount.GetInterest());
               if (anAccount.GetPenalty()!=0)
                   {
                    Console.Write(" | Early Withdrawal Penalty: " + anAccount.GetPenalty());
                   }
               totBal = totBal + anAccount.GetBalance();
               anAccount.Deposit();
                Console.Write(" | Annual Interest: " + anAccount.Deposit());
             }
                       
           }  Console.WriteLine();  
              Console.Write("                    Total Balance All Accounts: $" + totBal);
              Console.WriteLine();  
       
        string? depChoice = "";
        string? choiceUC = "";
        string? childAcct = "";
     do
            {
                Console.WriteLine();
                Console.WriteLine("Please choose one of the following Deposit destinations:");
                Console.WriteLine("C ) Checking Account");
                Console.WriteLine("S ) Savings Account");
                Console.WriteLine("CD) Certificate of Deposit");
                Console.WriteLine("E ) Exit Deposit Transactions");

                depChoice = Console.ReadLine();
                choiceUC = depChoice!.ToUpper();
                
                if (choiceUC == "C" || choiceUC == "S" || choiceUC == "CD")
                {
                    Console.WriteLine("You chose {0}.", choiceUC);
                    Console.WriteLine(findAcct);
                    childAcct = findAcct + choiceUC;
                    Console.WriteLine(childAcct);
               
                // A valid deposit account was chosen so make sure we can leave when done
                   choiceUC = "E";


                // That out of the way, make a deposit transaction here
                double newdepAmt = 0;
                string? depAmt = "0";
                Console.WriteLine("Please enter a Deposit Amount: ") ;
                depAmt = Console.ReadLine();
                newdepAmt = Convert.ToDouble(depAmt);
                Console.WriteLine("You entered: " + newdepAmt + "  Is that correct?: ") ;
                Console.WriteLine();
                

                /*


            // Make a deposit to the account
               foreach (Account anAccount in accountsList)
              {
                if (anAccount.accountIDM == findAcct) // that match input acct
                   {             
                     anAccount.Deposit(newdepAmt);
                  }
               }
               */
                }
                else if (choiceUC == "E")
                {
                    Console.WriteLine("You chose {0}.", choiceUC);
                    Console.WriteLine("Exiting Deposit...");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }
            } while (choiceUC != "E" );
             // Console.WriteLine("Deposit Area Exit");
        }
     }    
   


     // end of D area 


//  TODO: If the option is W or w then make a withdrawal transaction WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW

            if (userChoiceString=="W" || userChoiceString=="w")
   {         
             Console.WriteLine("In the W/w area");


       // Print the list
       //double totBal = 0;
        foreach (Account anAccount in accountsList)
        {
            Console.WriteLine(anAccount);
            Console.WriteLine("Annual Interest would be " + anAccount.GetInterest());
            Console.WriteLine("Early withdrawal Penalty would be " + anAccount.GetPenalty());

        //    totBal = totBal + anAccount.GetBalance();
         //   Console.WriteLine(totBal);
        }  // end foreach  
        //Console.WriteLine("Total Balance = $" + totBal);
   } // end of W area


        //  TODO: Else if the option is a Q or q then quit the program  QQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQQ

            else if (userChoiceString=="Q" || userChoiceString=="q")
            {
                Console.WriteLine("Good-bye!");
            }
        } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));




    } // end of Main
  }  // end of class program
} //end of namespace