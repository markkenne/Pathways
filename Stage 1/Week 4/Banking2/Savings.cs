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

        public override string ToString()
        {
            return $"Account number: {accountNumber}, Account type: {accountType}, Balance: {balance}";
        }
    }
}           