using System;

class Account
{
    private int balance = 100;

    public int Withdraw(int amount)
    {
        if (amount > balance)
        {
            return -1; // error code: không đủ tiền
        }
        else
        {
            balance -= amount;
            return 0; // thành công
        }
    }
}

class Program
{
    static void Main()
    {
        Account acc = new Account();
        int result = acc.Withdraw(200);

        if (result == -1)
        {
            Console.WriteLine("Error: insufficient balance!");
        }
        else
        {
            Console.WriteLine("Withdraw successful!");
        }
    }
}

