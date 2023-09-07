using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySuperBank
{
    public class BankAccount
    {

        public string Number { get; } //properties
        public string Owner { get; set; } //properties
        public decimal Balance { get; } //properties

        private static int accountNumberSeed = 1234567890;

        public BankAccount(string name, decimal initialBalance)  // constructor
        {
            Owner = name;    //arguments
            Balance = initialBalance;  //arguments
            Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }



        public void MakeDeposit(decimal amount, DateTime date, string note) // method
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note) // method
        {
        }
    }
}
   
