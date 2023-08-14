using System;

namespace BankingApp
{
   class CD : Account
    {
      
       const int earlyWithdrawalFee = 50;  // variable to hold early withdrawal fee
       private string ewfAmount = "";  // variable to show fee in tostring
       const double cdIntRate = .0475;  // constant for CD interest rate

        public CD(int accountNumber, string accountType, double balance)
            : base(accountNumber, accountType, balance)
        {
             // earlyWithdrawalFee = 50;

        }

        public override void Deposit(double amount)
        {
            balance += amount;
        }

        public override void Withdraw(double amount)
        {
            if (balance < amount + earlyWithdrawalFee)
            {
            ewfAmount = "Insufficient funds to withdraw amount entered.";
               // Console.WriteLine("Insufficient funds");
            balance += 0;
            }
      
           
            if (balance > (amount + earlyWithdrawalFee))
            {
             ewfAmount = "Early Withdrawal Penalty of $50.00 included";
             balance -= (amount + earlyWithdrawalFee);
            }
        }


        public override double GetInterest() // implementation of abstract method
        {
            return balance * cdIntRate;
        }
        public override double GetFee() // implementation of abstract method
        {
            return 0; // No Annual Fee for CD
        }
        public override double GetPenalty() // implementation of abstract method
        {
            return balance * cdIntRate / 2; // Penalty for early withdraw is 6 months interest
        }
        public override double GetBalance() // implementation of abstract method
        {
            return balance; // balance
        }               

        public override string ToString()
        {
            return $"Account number: {accountNumber}, Account type: {accountType}, Balance after withdrawal: {balance},  {ewfAmount}";
        }
    }
}        