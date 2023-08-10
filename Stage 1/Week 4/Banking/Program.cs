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
        string userChoiceString;


 // Repeat main loop
      do
      {

        // TODO: Get a valid input
            do
            {
                //  Initialize variables

                userChoice = false;

                //  TODO: Provide the user a menu of options

                Console.WriteLine("What's your pleasure? ");
                Console.WriteLine("L: Load the data file into an array.");
                Console.WriteLine("S: Save the array to the data file.");
                Console.WriteLine("C: Add a name to the array.");
                Console.WriteLine("R: Read a name from the array.");
                Console.WriteLine("U: Update a name in the array.");
                Console.WriteLine("D: Delete a name from the array.");
                Console.WriteLine("Q: Quit the program.");

                //  TODO: Get a user option (valid means its on the menu)

                userChoiceString = Console.ReadLine();

                userChoice = (userChoiceString=="L" || userChoiceString=="l" ||
                            userChoiceString == "S" || userChoiceString == "s" ||
                            userChoiceString == "C" || userChoiceString == "c" ||
                            userChoiceString == "R" || userChoiceString == "r" ||
                            userChoiceString == "U" || userChoiceString == "u" ||
                            userChoiceString == "D" || userChoiceString == "d" ||
                            userChoiceString == "Q" || userChoiceString == "q");

                if (!userChoice)
                {
                    Console.WriteLine("Please enter a valid option.");
                }

            } while (!userChoice);

        //  TODO: If the option is L or l then load the text file (names.txt) into the array of strings (nameArray)

            if (userChoiceString=="L" || userChoiceString=="l")




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
            Console.WriteLine("The search was successful and returned these Account details:"); // let user know account was found
          foreach (Account anAccount in accountsList)  //loop thru accounts
           {
            if (anAccount.accountIDM == findAcct) // that match input acct
             {             
               Console.WriteLine(anAccount); // print the tostrings
               Console.WriteLine("Annual Interest would be " + anAccount.GetInterest());
               Console.WriteLine("Early withdrawal Penalty would be " + anAccount.GetPenalty());
               totBal = totBal + anAccount.GetBalance();
             }
           //  Console.WriteLine("Total Balance = $" + totBal);
             
        }   Console.WriteLine("Total Balance = $" + totBal);
       }


        //  TODO: Else if the option is a Q or q then quit the program

            else 
            {
                Console.WriteLine("Good-bye!");
            }
        } while (!(userChoiceString=="Q") && !(userChoiceString=="q"));




    } // end of Main
  }  // end of class program
} //end of namespace