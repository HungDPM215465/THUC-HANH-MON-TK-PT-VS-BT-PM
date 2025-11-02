using System;

namespace Problem_IntroduceForeignMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime previousBillingDate = new DateTime(2025, 10, 15);

            // Logic tính toán thủ công và lặp lại
            DateTime nextBillingDate = new DateTime(previousBillingDate.Year, previousBillingDate.Month, 1).AddMonths(1);

            Console.WriteLine("Previous Billing Date: " + previousBillingDate.ToShortDateString());
            Console.WriteLine("Next Billing Date: " + nextBillingDate.ToShortDateString());
        }
    }
}