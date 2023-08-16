// Executive Child Class

using System;

namespace CustomerMgmt
{
   class NonProfit : Membership
    {
       public double cashback  // property
       { get; set; }
       public string milEdu  // property
       { get; set; }    
       
       public NonProfit(string membershipID, string type, string contact, double annualCost, double currentMonthlyPurchases, string newmilEdu): base(membershipID, type, contact, annualCost, currentMonthlyPurchases)
        {
        milEdu = newmilEdu;
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
           if (milEdu == "Y")
           {
            return currentMonthlyPurchases * .02; // double (2%)  for Mil or Edu NPs
           }
           else
           {
            return currentMonthlyPurchases * .01; // normal rate is 1% for NPs
           }
        }

        public override double GetSpecials() // interface method
        {
            return 0; //no special
        }

        public override string ToString()
        {
         return $"ID: {membershipID}, Type: {type}, Email: {contact}, Annual Fee: " + ($"{annualCost:C2}") + ", Cur.Mon.Purchases: " + ($"{currentMonthlyPurchases:C2}") + ", Mil or Edu: " + milEdu;
        }
    }
}