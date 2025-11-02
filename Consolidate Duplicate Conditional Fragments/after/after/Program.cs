using after;
using System;

namespace ConsolidateDuplicateConditionalFragments
{
    class Program
    {
        static void Main()
        {
            OrderCalculator calc = new OrderCalculator();

            calc.CalculateTotal(1000, true);   // khách đặc biệt
            calc.CalculateTotal(1000, false);  // khách bình thường

            Console.ReadLine(); // giữ console mở
        }
    }
}