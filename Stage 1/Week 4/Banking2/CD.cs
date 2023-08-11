using System;

namespace BankingApp
{
   class CD : Account
    {
      
       private int  earlyWithdrawalFee;

        public CD(int accountNumber, string accountType, double balance)
            : base(accountNumber, accountType, balance)
        {
           // this.maturityDate = maturityDate;
              earlyWithdrawalFee = 50;
        }

        public override void Deposit(double amount)
        {
            balance += amount;
        }

        public override void Withdraw(double amount)
        {
            if (balance < amount + earlyWithdrawalFee)
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