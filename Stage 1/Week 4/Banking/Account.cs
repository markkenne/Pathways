using System;

namespace BankApp
{
  
    abstract class Account : IGetInterest, IGetFee // : IIntRate, ICDPenalty // this is an abstract class so it can't be instantiated (objects of this type can't be created)

    {
        public string accountID  // property
        { get; set; }

        public Account()       // default constructor
        {
            accountID = "";
        }

        public Account(string newaccountID)   // another constructor
        {
            accountID = newaccountID;
        }



        public abstract double GetInterest();  // this is the abstract method that all children must implement (not used in checking)
        public abstract double GetFee();  // this is the abstract method that all children must implement (only used in checking)

        public override string ToString()
        {
            return "Bank Account: " + accountID;
        }

    }  // end class Account

}  //end namespace listInterface