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
            return currentMonthlyPurchases * 1.10; // double (10%)  for Mil or Edu NPs
           }
           else
           {
            return currentMonthlyPurchases * 1.05; // normal rate is 5% for NPs
           }
        }


        public override string ToString()
        {
            return $"ID: {membershipID}, Type: {type}, Mil or Edu: {milEdu} Email: {contact}, Annual Fee: ${annualCost}, Cur.Mon.Purchases: ${currentMonthlyPurchases}";
        }
    }
}