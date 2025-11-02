using System;

class Program
{
    static bool isDead = false;
    static bool isSeparated = false;
    static bool isRetired = true;

    static void Main()
    {
        Console.WriteLine(GetPayAmount());
    }

    static double DeadAmount() => 0;
    static double SeparatedAmount() => 1000;
    static double RetiredAmount() => 2000;
    static double NormalPayAmount() => 3000;

    static double GetPayAmount()
    {
        if (isDead)
            return DeadAmount();
        if (isSeparated)
            return SeparatedAmount();
        if (isRetired)
            return RetiredAmount();

        return NormalPayAmount();
    }
}

