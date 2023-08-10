using System;

namespace BankApp
{
  
    abstract class Account : IGetInterest, IGetFee // : IIntRate, ICDPenalty // this is an abstract class so it can't be instantiated (objects of this type can't be created)

    {
        public string accountIDM  // property account ID for primary account
        { get; set; }
        

        public Account()       // default constructor, but not usable as abstract
        {
            accountIDM = ""; 

        }

        public Account(string newaccountIDM)   // another constructor , inherited by children
        {
            accountIDM = newaccountIDM;

        }

        public abstract double GetInterest();  // this is the abstract method that all children must implement (not used in checking)
        public abstract double GetFee();  // this is the abstract method that all children must implement (only used in checking)
        public abstract double GetPenalty();  // this is the abstract method that all children must implement (only used in CDs)  
        public abstract double GetBalance();  // this is the abstract method that all children must implement (only used in all)  
        public override string ToString()
        {
            return "Bank Account ID: " + accountIDM;
        }

    }  // end class Account

}  //end namespace listInterface