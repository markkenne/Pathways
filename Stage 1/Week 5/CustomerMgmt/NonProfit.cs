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
       
        public NonProfit(string membershipID, string type, string contactEmail, double annualCost, double currentMonthlyPurchases, string milEdu): base(membershipID, type, contactEmail, annualCost, currentMonthlyPurchases)
        {
          // newMilEdu = milEdu;
        }

//TODO need to return the mil or Edu flag



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





        public override double GetBalance() // implementation of abstract method
        {
            return currentMonthlyPurchases; // balance
        }

        public override string ToString()
        {
            return $"ID: {membershipID}, Type: {type}, Email: {contactEmail}, Ann Fee: {annualCost}, Cur.Mon.Purchases: {currentMonthlyPurchases}, Cashback: {cashback}";
        }
    }
}