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
        accountsList.Add(new Savings("MK00002", "MK00002S", "S", 5023.55));
        accountsList.Add(new Checking("MK00002","MK00002C", "C", 2532.22));
        accountsList.Add(new CD("MK00002", "MK00002CD", "CD", 12000.00));

       // Print the list
        foreach (Account anAccount in accountsList)
        {
            Console.WriteLine(anAccount);
            Console.WriteLine("Annual Interest would be " + anAccount.GetInterest());
            Console.WriteLine("Early withdrawal Penalty would be " + anAccount.GetPenalty());
        }  // end foreach  


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
            Console.WriteLine("The search was successful and returned these Account details:"); // let user know account was found
          foreach (Account anAccount in accountsList)  //loop thru accounts
           {
            if (anAccount.accountIDM == findAcct) // that match input acct
             {             
               Console.WriteLine(anAccount); // print the tostrings
             }
        }
       }
    } // end of Main
  }  // end of class program
} //end of namespace