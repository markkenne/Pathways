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
        public Regular(string membershipID, string type, string contactEmail, double annualCost, double currentMonthlyPurchases): base(membershipID, type, contactEmail, annualCost, currentMonthlyPurchases)
        {
          //  newMembershipID = membershipID;
          //  newContactEMail = contactEmail;
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