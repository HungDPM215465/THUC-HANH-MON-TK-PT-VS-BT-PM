using before;
using System;

namespace ConsolidateConditional
{
    class Program
    {
        static void Main()
        {
            DisabilityCalculator emp1 = new DisabilityCalculator(1, 6, false);
            DisabilityCalculator emp2 = new DisabilityCalculator(5, 13, false);
            DisabilityCalculator emp3 = new DisabilityCalculator(5, 6, true);
            DisabilityCalculator emp4 = new DisabilityCalculator(5, 6, false);

            Console.WriteLine(emp1.DisabilityAmount()); // 0
            Console.WriteLine(emp2.DisabilityAmount()); // 0
            Console.WriteLine(emp3.DisabilityAmount()); // 0
            Console.WriteLine(emp4.DisabilityAmount()); // 1000
        }
    }
}