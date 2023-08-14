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

        public override string ToString()
        {
            return $"ID: {membershipID}, Type: {type}, Email: {contactEmail}, Annual Fee: {annualCost}, Current Purch:  {currentMonthlyPurchases}, Cashback: {cashback}";
        }
    }
}