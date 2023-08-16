// Executive Child Class

using System;

namespace CustomerMgmt
{
   class Executive : Membership
    {
       public double cashback  // property
       { get; set; }
       
        public Executive(string membershipID, string type, string contact, double annualCost, double currentMonthlyPurchases): base(membershipID, type, contact, annualCost, currentMonthlyPurchases)
        {
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


        public override double GetReward() // implementation of abstract method for Executive
        {
            if (currentMonthlyPurchases > 1000)
            { 
                return (1000 *.01 + ((currentMonthlyPurchases - 1000) * .02 )); // 1 % amt under 1000  + 2% amount over 1000
            }
            else
            return currentMonthlyPurchases; // 100% for balance under 1000 for Executive
        }

        public override double GetSpecials() // interface method
        {
            return annualCost * .50; //implementation for the executive membership will return 50% of the annual membership cost.
        }

        public override string ToString()
        {
         return $"ID: {membershipID}, Type: {type}, Email: {contact}, Annual Fee: " + ($"{annualCost:C2}") + ", Cur.Mon.Purchases: " + ($"{currentMonthlyPurchases:C2}") + " ";
        }
    }
}