using System;

namespace BankingApp
{
    class Checking : Account
    {

        const double withdrawlimit = .50;  // variable to hold checking withdrawal limit
     //   private string annfeeAmount = "100.00";  // variable to show annual fee in tostring
        private string limitText = "";

        public Checking(int accountNumber, string accountType, double balance)
            : base(accountNumber, accountType, balance)
        {
        }

        public override void Deposit(double amount)
        {
            balance += amount;
        }

        public override void Withdraw(double amount)
        {
            if ((balance * withdrawlimit) < amount)
            {
            limitText = "Insufficient funds to withdraw amount entered. Must be less than 50% of Balance.";
               // Console.WriteLine("Insufficient funds");
            balance += 0;
            }

            balance -= amount;
        }

        public override double GetInterest() // implementation of abstract method
        {
            return balance * 0; //checking has no interest in this scenario
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
            return balance; // balance
        }
        public override string ToString()
        {
            return $"Account number: {accountNumber}, Account type: {accountType}, Balance after withdrawal: {balance}   {limitText}";
        }
    }

}    