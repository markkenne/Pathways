using System;

namespace BankApp
{
    class Checking : Account
    {
        public string checkAcctID  // property for checking account ID
            { get; set; }

        public string acctType  // property for account type of C
            { get; set; }

        public double curBal  // property for storing current balance
            { get; set; }


        public Checking() : base()      // default constructor
        {
            checkAcctID ="";
            acctType = "C";
            curBal =  0.0;            
        }

        public Checking(string newaccountID, string newcheckAcctID, string newAcctType, double newCurBal) : base (newaccountID)       // another constructor
        {
            checkAcctID = newcheckAcctID;
            acctType = newAcctType;
            curBal = newCurBal;
        }
/*
        public override double GetInterest() // implementation of abstract method
        {
            return curBal * .0002;
        }
*/
        public override string ToString()
        {
            return base.ToString() + " | Checking Account ID: " + checkAcctID + " | Current Balance: $" + curBal;
        }

    }  // end class

}  // end namespace