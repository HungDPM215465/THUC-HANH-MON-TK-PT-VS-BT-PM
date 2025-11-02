using System;

class BalanceException : Exception
{
    public BalanceException() : base("Insufficient balance!") { }
}

class Account
{
    private int balance = 100;

    public void Withdraw(int amount)
    {
        if (amount > balance)
        {
            throw new BalanceException();
        }

        balance -= amount;
        Console.WriteLine($"Withdraw successful! Remaining: {balance}");
    }
}

class Program
{
    static void Main()
    {
        Account acc = new Account();

        try
        {
            acc.Withdraw(200);
        }
        catch (BalanceException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

