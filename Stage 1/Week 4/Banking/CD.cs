using System;

namespace BankApp
{
    class CD : Account 
    {
     
        const double cdIntRate = .0475;  // constant for CD interest rate
        public string cdAcctID  // property for checking account ID
            { get; set; }

        public string acctType  // property for account type of C
            { get; set; }

        public double curBal  // property for storing current balance
            { get; set; }


        public CD() : base()      // default constructor
        {
            cdAcctID ="";
            acctType = "CD";
            curBal =  0.0;            
        }

        public CD(string newaccountIDM, string newcdAcctID, string newAcctType, double newCurBal) : base(newaccountIDM)//  another constructor
        {
            cdAcctID = newcdAcctID;
            acctType = newAcctType;
            curBal   = newCurBal;
        }

        public override double GetInterest() // implementation of abstract method
        {
            return curBal * cdIntRate;
        }
        public override double GetFee() // implementation of abstract method
        {
            return 0; // No Annual Fee for CD
        }
        public override double GetPenalty() // implementation of abstract method
        {
            return curBal * cdIntRate / 2; // Penalty for early withdraw is 6 months interest
        }
        public override double GetBalance() // implementation of abstract method
        {
            return curBal; // balance
        }        
        public void Deposit(double depAmt) // Deposit method
        {
            curBal += depAmt; // balance
        }       
        public override string ToString()
        {
            return base.ToString() + " |      CD ID: " + cdAcctID + " | Balance: $" + curBal;
        }

    }  // end class

}  // end namespace