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

        public Checking(string newaccountIDM, string newcheckAcctID, string newAcctType, double newCurBal) : base(newaccountIDM)//  another constructor
        {
            checkAcctID = newcheckAcctID;
            acctType = newAcctType;
            curBal = newCurBal;
        }


/*
        public void Deposit(string newaccountIDM, string newcheckAcctID, double newdepAmt ) : base(newaccountIDM)// 
        //public Deposit(string newcheckAcctID, double newdepAmt) : base(newaccountIDM) // Deposit method
        {
           curBal += newdepAmt; // balance

        }     
*/

        public override double Deposit() // implementation of abstract method
        {
            return curBal * 1; //checking has no interest in this scenario
        }


        public override double GetInterest() // implementation of abstract method
        {
            return curBal * 0; //checking has no interest in this scenario
        }
        public override double GetFee() // implementation of abstract method
        {
            return 60; // Annual Fee of $60
        }
        public override double GetPenalty() // implementation of abstract method
        {
            return 0; //no penalty
        }
        public override double GetBalance() // implementation of abstract method
        {
            return curBal; // balance
        }
        public override string ToString()
        {
            return base.ToString() + " | Checking ID: " + checkAcctID + " | Balance: $" + curBal + " | with Annual Fee of: $" + GetFee();
        }
 

    }  // end class

}  // end namespace