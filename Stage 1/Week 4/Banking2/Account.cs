using System;

namespace BankingApp
{
    abstract class Account
    {
        // protected int accountNumber;
        // protected string accountType;
        // protected double balance;
        public int accountNumber;
        public string accountType;
        public double balance;

        public Account(int accountNumber, string accountType, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountType = accountType;
            this.balance = balance;
        }

        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public override abstract string ToString();
       // public override string ToString();
    }
}    