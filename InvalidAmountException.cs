using System;

namespace BankingSystem
{
    public class InvalidAmountException : Exception
    {
        public InvalidAmountException(string message) : base(message) { }
    }
}
