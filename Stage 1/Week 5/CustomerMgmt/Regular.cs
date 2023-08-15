// Regular Child Class

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
        public Regular(string membershipID, string type, string contactEmail, double annualCost, double currentMonthlyPurchases): base(membershipID, type, contactEmail, annualCost, currentMonthlyPurchases)
        {
          //  newMembershipID = membershipID;
          //  newContactEMail = contactEmail;
          //  newAnnualCost = annualCost;
          //  newCurrentMonthlyPurchases = currentMonthlyPurchases;
           //  cashback = 0;
        }



        public override string ToString()
        {
            return $"ID: {membershipID}, Type: {type}, Email: {contactEmail}, Annual Fee: {annualCost}, Current Purch:  {currentMonthlyPurchases}, Cashback: {cashback}";
        }
    }
}