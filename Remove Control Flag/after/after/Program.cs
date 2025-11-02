using after;
using System;
using System.Collections.Generic;

namespace RemoveControlFlag
{
    class Program
    {
        static void Main()
        {
            var checker = new OrderChecker();

            var orders1 = new List<int> { 10, 20, 0, 40 };
            var orders2 = new List<int> { 5, 10, 15 };

            checker.CheckOrders(orders1);
            checker.CheckOrders(orders2);

            Console.ReadLine();
        }
    }
}