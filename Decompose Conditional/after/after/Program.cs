using after;
using System;

namespace DecomposeConditional
{
    class Program
    {
        static void Main()
        {
            ChargeCalculator calc = new ChargeCalculator();

            Console.WriteLine(calc.GetCharge(new DateTime(2025, 7, 10), 100));   // 50
            Console.WriteLine(calc.GetCharge(new DateTime(2025, 12, 10), 100));  // 40
        }
    }
}