using System;

namespace BankingApp
{
    class Checking : Account
    {
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
            if (balance < amount)
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