// Executive Child Class

using System;

namespace CustomerMgmt
{
   class Executive : Membership
    {
       public double cashback  // property
       { get; set; }
       
        public Executive(string membershipID, string type, string contactEmail, double annualCost, double currentMonthlyPurchases): base(membershipID, type, contactEmail, annualCost, currentMonthlyPurchases)
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
                return (1000 + ((currentMonthlyPurchases - 1000) * 1.1 )); // 100 % amt under 1000  + 110% amount over 1000
            }
            else
            return currentMonthlyPurchases; // 100% for balance under 1000 for Executive
        }

        public override double GetCMP() // implementation of abstract method
        {
            return currentMonthlyPurchases; // balance
        }

        public override string ToString()
        {
            return $"ID: {membershipID}, Type: {type}, Email: {contactEmail}, Ann Fee: {annualCost}, Cur.Mon.Purchases: {currentMonthlyPurchases}, Cashback: {cashback}";
        }
    }
}