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
       accountsList.Add(new Savings("MK00002", "MK00002S", "S", 5000));
      // accountsList.Add(new Account("MK00002"));
        // Add an account only
      //  accountsList.Add(new HourlyEmployee("Enge", "J.S.", "H", 25.00));
        // Add a salary employee
      //  employeeList.Add(new SalaryEmployee("Enge", "Alec", "S", 15000));

                // Print the list
        foreach (Account anAccount in accountsList)
        {
            Console.Write(anAccount);
         //   Console.WriteLine(", and by the way, Commission was " + aVehicle.GetCommission());
        }  // end foreach  


    } // end of Main
  }  // end of class program
} //end of namespace