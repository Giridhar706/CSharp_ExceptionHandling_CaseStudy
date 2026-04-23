using System;

namespace BankingSystem
{
    public class BankAccount
    {
        public string AccountHolderName { get; set; }
        public double Balance { get; private set; }

        public BankAccount(string name, double balance)
        {
            AccountHolderName = name;
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Deposit must be greater than 0");

            Balance += amount;
            Console.WriteLine("Deposit successful!");
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
                throw new InsufficientBalanceException("Not enough balance!");

            if (Balance - amount < 1000)
                throw new InsufficientBalanceException("Minimum ₹1000 balance required!");

            Balance -= amount;
            Console.WriteLine("Withdrawal successful!");
        }

        public void CheckBalance()
        {
            Console.WriteLine("Current Balance: ₹" + Balance);
        }
    }
}