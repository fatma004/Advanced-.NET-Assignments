using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_Day1
{
    public class BankAccount
    {
        public readonly string AccountNumber;
        public string AccountHolderName { get; set; }
        public double Balance { get; private set; }
       
        public BankAccount(string accountHolderName, string accountNumber, double balance = 0)
        {
            AccountHolderName = accountHolderName;
            AccountNumber = accountNumber;
            Balance = balance;
        }
        public void Deposit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid value");
            }
            UpdateBalance(amount);
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("amount must be positive");
            }
            if (amount > Balance)
            {
                throw new InvalidOperationException("Invalid Transaction!");
            }
            UpdateBalance(-amount);
        }
        private void UpdateBalance(double amount) 
        {
            Balance += amount;
        }
    }
}
