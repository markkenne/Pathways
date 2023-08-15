// Membership Class - used to hold MembershipID, Contact email, annual cost and current monthly purchases in dollars

using System;

namespace CustomerMgmt
{
    abstract class Membership
    {
        public string membershipID;  // holds membership ID
        public string type;          // holds membership type (C for corparate, E for Executive, N for Non-profit, R for Regular)
        public string contactEmail;   
        public double annualCost;
        public double currentMonthlyPurchases;
        // primary constructor
        public Membership(string membershipID, string type, string contactEmail, double annualCost, double currentMonthlyPurchases)
        {
            this.membershipID = membershipID;
            this.type = type;
            this.contactEmail = contactEmail;
            this.annualCost = annualCost;
            this.currentMonthlyPurchases = currentMonthlyPurchases;
        }
       // public abstract double GetBalance();  // this is the abstract method that all children must implement (only used in all)        
        public abstract void Purchase(double amount);
        public abstract void Return(double amount);
        public abstract void Cashback(string membershipID, double amount);
        public abstract double GetReward();  // this is the abstract method that all children must implement (not used in checking)
        public override abstract string ToString();
    }
}    
