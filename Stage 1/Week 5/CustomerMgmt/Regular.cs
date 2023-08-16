// Regular Child Class

using System;
using System.Dynamic;

namespace CustomerMgmt
{
   class Regular : Membership
    {
       public double cashback  // property
       { get; set; }
       
       /* public Regular() : base()
        {
            cashback = 0;
        }
*/
        public Regular(string membershipID, string type, string contact, double annualCost, double currentMonthlyPurchases): base(membershipID, type, contact, annualCost, currentMonthlyPurchases)
        {
          //  newMembershipID = membershipID;
          //  newContact = contact;
          //  newAnnualCost = annualCost;
          //  newCurrentMonthlyPurchases = currentMonthlyPurchases;
          //  cashback = 0;
        }
        
     
        public override void Return(double amount)
        {
           if (!(amount > 0))
            {
            string limitText = "The Return must be more than 0.";
            Console.WriteLine(limitText);
            currentMonthlyPurchases -= 0;
            }           
            currentMonthlyPurchases -= amount;
        }

        public override void Purchase(double amount)
        {
            if (!(amount > 0))
            {
            string limitText = "The Purchase must be more than 0.";
            Console.WriteLine(limitText);
            currentMonthlyPurchases += 0;
            }
            currentMonthlyPurchases += amount;
        }

        public override void Cashback(string membershipID, double amount)
        {
            Console.WriteLine("Cash-back reward request for Membership ID " + membershipID + " in the amount of $" + amount + " has been made.");
            currentMonthlyPurchases = 0; // just zero it out
        }
        public override double GetReward() // implementation of abstract method
        {
            return currentMonthlyPurchases *.01; // 1.0% for Regular
        }
        public override double GetSpecials() // interface method
        {
            return annualCost * 0.25; //implementation for a regular membership will simply return 25% of the annual membership cost 
        }
        public override string ToString()
        {
          return $"ID: {membershipID}, Type: {type}, Email: {contact}, Annual Fee: " + ($"{annualCost:C2}") + ", Cur.Mon.Purchases: " + ($"{currentMonthlyPurchases:C2}") + " ";
        }
    }
}