using System;

namespace BankingApp
{
      class Savings : Account
    {
        public Savings(int accountNumber, string accountType, double balance)
            : base(accountNumber, accountType, balance)
        {
        }

        public override void Deposit(double amount)
        {
            balance += amount;
        }

        public override void Withdraw(double amount)
        {
            if (balance < amount + 5)
            {
                throw new Exception("Insufficient funds");
            }

            balance -= amount;
        }

        public override double GetInterest() // implementation of abstract method
        {
            return balance * .02;
        }

        public override double GetFee() // implementation of abstract method
        {
            return 0; //no Annual Fee
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
            return $"Account number: {accountNumber}, Account type: {accountType}, Balance: {balance}";
        }
    }
}           