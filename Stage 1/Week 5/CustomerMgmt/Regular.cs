// Membership Class - used to hold MembershipID, Contact email, annual cost and current monthly purchases in dollars

using System;

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
        public Regular(string membershipID, string contactEmail, double annualCost, double currentMonthlyPurchases): base(membershipID, contactEmail, annualCost, currentMonthlyPurchases)
        {
          //  newMembershipID = membershipID;
          //  newContactEmail = contactEmail;
          //  newAnnualCost = annualCost;
          //  newCurrentMonthlyPurchases = currentMonthlyPurchases;
           //  cashback = 0;
        }



        public override string ToString()
        {
            return $"ID: {membershipID}, Email: {contactEmail}, Annual Fee: {annualCost}, Current Purch:  {currentMonthlyPurchases}, Cashback: {cashback}";
        }
    }
}