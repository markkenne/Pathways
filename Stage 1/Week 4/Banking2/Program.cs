using System;

namespace BankingApp
{

     class Program
    {
        static void Main(string[] args)
        {
    // Global variables declared here 
        bool userChoice;
        string? userChoiceString = "X";
    
    // Create a list of accounts
        List<Account> accountsList = new List<Account>();

    // Add some accounts to the list
        accountsList.Add(new Checking(22222, "Checking", 1000));
        accountsList.Add(new Savings(11111, "Savings", 5000));
        accountsList.Add(new CD (33333, "CD", 10000));


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
               Console.WriteLine("Listing of All Accounts:"); 
            // Print a list to the screen
               foreach (Account account in accountsList)
            {
               Console.WriteLine(account);
            }
Console.WriteLine();
   } // end of L area


//  TODO: Else if the option is a D or d then do a Deposit Transaction DDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDDD

            else if (userChoiceString=="D" || userChoiceString=="d")
   {
                Console.WriteLine("Welcome to the Deposit Depot!");
                Console.WriteLine();   


      // Find an Account in the list
        bool found = false;   // set a variable to change to true on found acct
        int findAcct = 0; // set an input variable to empty
                foreach (Account account in accountsList)
            {
               Console.WriteLine(account);
            }      
        Console.Write("Please enter an Account Number to access: ");
        findAcct = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(findAcct);
        Console.WriteLine(); 
    
        foreach (Account anAccount in accountsList)
          {
           //  Console.WriteLine(anAccount.accountNumber);
             if (anAccount.accountNumber == findAcct)
               { found = true;
                // debug use Console.WriteLine("Name WAS found." + found);
               } //just set a found flag. do more later
          }  // end foreach  
        if (!(found))  // no account matches input, so let user know
          {
            Console.WriteLine("Account number was not found.");
            Console.WriteLine();
          }

       if ((found))
         {
            Console.WriteLine();
            Console.WriteLine("The search was successful:"); // let user know account was found
            Console.WriteLine();
       
             // Now we have an AcctNo make a deposit transaction here, find out how much
                double newdepAmt = 0;
                string? depAmt = "0";
               
                Console.WriteLine("Please enter a Deposit Amount: ") ;
                depAmt = Console.ReadLine();
                newdepAmt = Convert.ToDouble(depAmt);
                Console.WriteLine( newdepAmt + " has been deposited.") ;
                Console.WriteLine();

                // only deposit in the found account
                foreach (Account depAccount in accountsList)
                if (depAccount.accountNumber == findAcct)
                  {
                    depAccount.Deposit(newdepAmt); //the actual deposit
                    Console.WriteLine(depAccount);
                    Console.WriteLine();
                  }  
             }
   }  // end of D area 

//  TODO: If the option is W or w then make a withdrawal transaction WWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW

            if (userChoiceString=="W" || userChoiceString=="w")
   {         
             Console.WriteLine("In the W/w area");
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

