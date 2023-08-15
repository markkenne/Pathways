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
        public override string ToString()
        {
            return $"ID: {membershipID}, Type: {type}, Email: {contactEmail}, Annual Fee: {annualCost}, Current Purch:  {currentMonthlyPurchases}, Cashback: {cashback}";
        }
    }
}