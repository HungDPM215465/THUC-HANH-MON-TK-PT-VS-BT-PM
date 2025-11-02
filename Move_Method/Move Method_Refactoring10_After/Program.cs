using System;

namespace Solution_MoveMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var accountType = new AccountType(0.05);
            var account = new Account(accountType, 10000);
            Console.WriteLine("Interest: " + account.CalculateInterest().ToString("C"));
        }
    }

    class AccountType
    {
        public double InterestRate { get; private set; }
        public AccountType(double interestRate)
        {
            InterestRate = interestRate;
        }

        public double CalculateInterest(double balance)
        {
            return balance * this.InterestRate;
        }
    }

    class Account
    {
        private AccountType _type;
        private double _balance;

        public Account(AccountType type, double balance)
        {
            _type = type;
            _balance = balance;
        }

        public double CalculateInterest()
        {
            return _type.CalculateInterest(_balance);
        }
    }
}