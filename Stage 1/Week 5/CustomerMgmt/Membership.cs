// Membership Class - used to hold MembershipID, Contact email, annual cost and current monthly purchases in dollars. 
//                    Also defines primary constructor and methods used by children classes

using System;

namespace CustomerMgmt
{
    abstract class Membership
    {
        public string membershipID;            // property holds membership ID
        public string type;                    // property holds membership type (C for corparate, E for Executive, N for Non-profit, R for Regular)
        public string contact;                 // property holds membership Email contact
        public double annualCost;              // property holds calculated annual membership fee
        public double currentMonthlyPurchases; // property holds running monthly purchase total
      
        // primary constructor
        public Membership(string membershipID, string type, string contact, double annualCost, double currentMonthlyPurchases)
        {
            this.membershipID = membershipID;
            this.type = type;
            this.contact = contact;
            this.annualCost = annualCost;
            this.currentMonthlyPurchases = currentMonthlyPurchases;
        }
  
        public abstract void Purchase(double amount); // method used for Purchases
        public abstract void Return(double amount); // method used for Returns
        public abstract void Cashback(string membershipID, double amount); //method used to calculate cashback
        public abstract double GetReward();    // this is the abstract method that all children must implement to return Reward Amount
        public abstract double GetSpecials();  // this is the abstract method that all children must implement to return Membership Special Amount
        public override abstract string ToString();  // this is the abstract method that all children must implement to return to display the list
    }
}    
