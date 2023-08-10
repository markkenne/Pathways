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

        public CD(string newaccountID, string newcdAcctID, string newAcctType, double newCurBal) : base (newaccountID)       // another constructor
        {
            cdAcctID = newcdAcctID;
            acctType = newAcctType;
            curBal = newCurBal;
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
        public override string ToString()
        {
            return base.ToString() + " | CD Account ID: " + cdAcctID + " | Current Balance: $" + curBal;
        }

    }  // end class

}  // end namespace