// Membership Class - used to hold MembershipID, Contact email, annual cost and current monthly purchases in dollars

using System;

namespace CustomerMgmt
{
    abstract class Membership
    {
        // protected int accountNumber;
        // protected string accountType;
        // protected double balance;
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
        public abstract double GetBalance();  // this is the abstract method that all children must implement (only used in all)        
        public abstract void Purchase(double amount);
        public abstract void Return(double amount);

       /* 
        public abstract double GetInterest();  // this is the abstract method that all children must implement (not used in checking)
        public abstract double GetFee();  // this is the abstract method that all children must implement (only used in checking)
        public abstract double GetPenalty();  // this is the abstract method that all children must implement (only used in CDs)  
        public abstract double GetBalance();  // this is the abstract method that all children must implement (only used in all)  
        

        */
        public override abstract string ToString();


        
    }
}    


















/*
using System;

namespace CustomerMgmt
{
    abstract class Membership
    {
        public string? membershipID // holds membership ID, must be a unique string - PK
       // { get; set; }   
        public string contactEmail  // holds Member email addr
        //{ get; set; } 
        public double annualCost   // holds annual membership cost
       // { get; set; }
        public double currentMonthlyPurchases  // holds current monthly purchas total
       // { get; set; }

      
        public Membership()       // default constructor sets values to 0 or null
        {
            membershipID = "";
            contactEmail = "";
            annualCost = 0;
            currentMonthlyPurchases = 0;
        }
       public Membership(string membershipID, string contactEmail, double annualCost, double currentMonthlyPurchases);
       {}
            {
            this.membershipID = membershipID;
            this.contactEmail = contactEmail;
            this.annualCost = annualCost;
            this.currentMonthlyPurchases = currentMonthlyPurchases;
            }

        //TODO create a constructor for 2 string, 2 double
        //TODO create a purchase method
        //TODO create a return method
        //TODO create an abstract apply cashback rewards method 

        //create a useful toString
        public override string ToString()
        {
            return "Memnership ID: " + membershipID + ", Contact Email: " + contactEmail + " | Current Monthly Purchases: " +  currentMonthlyPurchases;
        }
    

      } // end class Membership
}  // end namespace CustomerMgmt
*/