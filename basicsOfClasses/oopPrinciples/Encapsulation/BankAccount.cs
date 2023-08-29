using System;
namespace oopPrinciples.Encapsulation
{
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;
        private string ownerName;

        public BankAccount(string accountNumber, decimal initialBalance, string ownerName)
        {
            this.accountNumber = accountNumber;
            this.balance = initialBalance;
            this.ownerName = ownerName;
        }

        public void Deposit(decimal amount)
        {
            balance += amount;
        }
        public void Withdrew(decimal amount)
        {
            if(balance > amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("not accepted transaction");
            }

        }

        public decimal GetBalance()
        {
            return balance;
        }
    }
}

