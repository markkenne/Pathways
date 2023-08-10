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
        accountsList.Add(new Checking("MK00002", "MK00002C", "C", 2532.22));
        accountsList.Add(new CD("MK00002", "MK00002CD", "CD", 12000.00));

       // Print the list
        foreach (Account anAccount in accountsList)
        {
            Console.WriteLine(anAccount);
            Console.WriteLine("Annual Interest would be " + anAccount.GetInterest());
            Console.WriteLine("Early withdrawal Penalty would be " + anAccount.GetPenalty());
        }  // end foreach  


        // Find an Account in the list
        Console.Write("Please enter an Account ID to access: ");
        string findAcct = Console.ReadLine();
        bool found = false;
        foreach (Account anAccount in accountsList)
        {
            if (anAccount.accountID == findAcct)
            {
           //     Console.WriteLine();
           //     Console.WriteLine("The search was successful and returned these Account details:");
           //     Console.WriteLine(anAccount);
                found = true;
            }
        }  // end foreach  
        if (!(found))
        {
            Console.WriteLine("Name was not found.");
        }
        Console.WriteLine();
       if ((found))
       {
          Console.WriteLine();
          Console.WriteLine("The search was successful and returned these Account details:");
       
        foreach (Account anAccount in accountsList)
        {
            if (anAccount.accountID == findAcct)
             {             
               Console.WriteLine(anAccount);
             }
        }
       }
    } // end of Main
  }  // end of class program
} //end of namespace