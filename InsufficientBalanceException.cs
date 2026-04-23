using System;

namespace BankingSystem
{
    public class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message) { }
    }
}
