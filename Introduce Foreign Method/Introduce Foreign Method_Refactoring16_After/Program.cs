using System;

namespace Solution_IntroduceForeignMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime previousBillingDate = new DateTime(2025, 10, 15);

            // Gọi phương thức mở rộng một cách gọn gàng
            DateTime nextBillingDate = previousBillingDate.NextBillingDate();

            Console.WriteLine("Previous Billing Date: " + previousBillingDate.ToShortDateString());
            Console.WriteLine("Next Billing Date: " + nextBillingDate.ToShortDateString());
        }
    }

    public static class DateTimeExtensions
    {
        public static DateTime NextBillingDate(this DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1).AddMonths(1);
        }
    }
}