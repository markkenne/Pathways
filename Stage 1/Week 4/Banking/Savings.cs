using System;

namespace BankApp
{
    class Savings : Account
    {
        public string savAcctID  // property for savings account ID
            { get; set; }

        public string acctType  // property for account type of S
            { get; set; }

        public double curBal  // property for storing current balance
            { get; set; }


        public Savings() : base()      // default constructor
        {
            savAcctID ="";
            acctType = "S";
            curBal =  0.0;            
        }

        public Savings(string newaccountID, string newSavAcctID, string newAcctType, double newCurBal) : base (newaccountID)       // another constructor
        {
            savAcctID = newSavAcctID;
            acctType = newAcctType;
            curBal = newCurBal;
        }

        public override double GetInterest() // implementation of abstract method
        {
            return curBal * .02;
        }

        public override double GetFee() // implementation of abstract method
        {
            return 0; //no Annual Fee
        }


        public override string ToString()
        {
            return base.ToString() + " | Savings Account ID: " + savAcctID + " | Current Balance: $" + curBal;
        }

    }  // end class

}  // end namespace