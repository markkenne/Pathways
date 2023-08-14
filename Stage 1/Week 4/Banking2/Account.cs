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
        
        public abstract double GetInterest();  // this is the abstract method that all children must implement (not used in checking)
        public abstract double GetFee();  // this is the abstract method that all children must implement (only used in checking)
        public abstract double GetPenalty();  // this is the abstract method that all children must implement (only used in CDs)  
        public abstract double GetBalance();  // this is the abstract method that all children must implement (only used in all)  
        
        public abstract void Deposit(double amount);
        public abstract void Withdraw(double amount);
        public override abstract string ToString();
       // public override string ToString();
    }
}    